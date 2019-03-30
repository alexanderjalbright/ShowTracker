import React, { Component } from "react";
import "./App.css";

class App extends Component {
  constructor() {
    super();
    this.state = {
      genres: []
    };
  }

  componentDidMount() {
    fetch("https://localhost:44387/api/genre")
      .then(res => res.json())
      .then(json => this.setState({ genres: json }));
  }

  showList = shows =>
    shows.map(show => (
      <li key={show.showId}>
        <h2>Show: {show.name}</h2>
        <p>Description: {show.description}</p>
        <p>Seasons: {show.seasons}</p>
      </li>
    ));

  render() {
    const genreList = this.state.genres.map(genre => (
      <li key={genre.genreId} className="genres">
        <h1>Genre: {genre.name}</h1>
        <p>Description: {genre.description}</p>
        <ul>{this.showList(genre.shows)}</ul>
      </li>
    ));

    return (
      <div className="App">
        <ul>{genreList}</ul>
      </div>
    );
  }
}

export default App;
