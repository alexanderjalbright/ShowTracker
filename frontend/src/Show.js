import React, { Component } from "react";

export default class Show extends Component {
  render() {
    const { show } = this.props;
    return (
      <li key={show.showId} className="show">
        <h2>{show.name}</h2>
        <small>({show.seasons} Seasons)</small>
        <p>{show.description}</p>
      </li>
    );
  }
}
