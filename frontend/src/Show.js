import React, { Component } from "react";

export default class Show extends Component {
  render() {
    const { show } = this.props;
    return (
      <li key={show.showId} className="show">
        <h2>Show: {show.name}</h2>
        <p>Description: {show.description}</p>
        <p>Seasons: {show.seasons}</p>
      </li>
    );
  }
}
