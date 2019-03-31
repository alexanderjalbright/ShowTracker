import React, { Component } from "react";
import "./App.css";
import Genre from "./Genre";

class App extends Component {
  constructor() {
    super();
    this.state = {
      genres: [],
      name: "",
      description: "",
      seasons: 0
    };
  }

  componentDidMount() {
    fetch("https://localhost:44387/api/genre")
      .then(res => res.json())
      .then(json => this.setState({ genres: json }));
  }

  submitGenre = submittedGenreId => {
    const newShow = {
      name: this.state.name,
      description: this.state.description,
      seasons: this.state.seasons,
      genreId: submittedGenreId
    };
    fetch("https://localhost:44387/api/show", {
      method: "POST",
      headers: {
        "Content-type": "application/json"
      },
      body: JSON.stringify(newShow)
    }).then(res => {
      if (res.ok) {
        const index = submittedGenreId - 1;
        const newShows = [...this.state.genres[index].shows, newShow];
        const newGenre = this.state.genres[index];
        newGenre.shows = newShows;
        const newGenres = this.state.genres;
        newGenres[index] = newGenre;
        this.setState({ genres: newGenres });
      }
    });
  };

  submitShow = (submittedShowId, submittedGenreId) => {
    const updatedShow = {
      name: this.state.name,
      description: this.state.description,
      seasons: this.state.seasons,
      genreId: submittedGenreId,
      showId: submittedShowId
    };
    const url = "https://localhost:44387/api/show/" + submittedShowId;
    fetch(url, {
      method: "POST",
      headers: {
        "Content-type": "application/json"
      },
      body: JSON.stringify(updatedShow)
    }).then(res => {
      if (res.ok) {
        const genreIndex = submittedGenreId - 1;
        const newShows = [...this.state.genres[genreIndex].shows];
        let whichShow = 0;
        newShows.forEach((show, index) => {
          if (show.showId === submittedShowId) {
            whichShow = index;
          }
        });
        newShows[whichShow] = updatedShow;
        const newGenre = this.state.genres[genreIndex];
        newGenre.shows = newShows;
        const newGenres = this.state.genres;
        newGenres[genreIndex] = newGenre;
        this.setState({ genres: newGenres });
      }
    });
  };

  setName = text => {
    this.setState({ name: text });
  };

  setDescription = text => {
    this.setState({ description: text });
  };

  setSeasons = number => {
    this.setState({ seasons: number });
  };

  render() {
    const genreList = this.state.genres.map(genre => (
      <Genre
        key={genre.genreId}
        genre={genre}
        name={this.state.name}
        description={this.state.description}
        seasons={this.state.seasons}
        setName={this.setName}
        setDescription={this.setDescription}
        setSeasons={this.setSeasons}
        submitGenre={this.submitGenre}
        submitShow={this.submitShow}
      />
    ));
    return (
      <div className="app">
        <ul className="genre-list">{genreList}</ul>
      </div>
    );
  }
}

export default App;
