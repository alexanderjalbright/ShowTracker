import React, { Component } from "react";
import Show from "./Show";

export default class Genre extends Component {
  render() {
    const { genre } = this.props;
    const showList = genre.shows.map(show => (
      <Show key={show.showId} className="show" show={show} />
    ));
    return (
      <li key={genre.genreId} className="genre">
        <h1>Genre: {genre.name}</h1>
        <p>Description: {genre.description}</p>
        <ul>{showList}</ul>
      </li>
    );
  }
}
