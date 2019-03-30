import React, { Component } from "react";
import "./App.css";
import Genre from "./Genre";

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

  render() {
    const genreList = this.state.genres.map(genre => (
      <Genre key={genre.genreId} genre={genre} />
    ));
    return (
      <div className="app">
        <ul className="genre-list">{genreList}</ul>
      </div>
    );
  }
}

export default App;
