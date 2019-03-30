import React, { Component } from "react";

export default class Show extends Component {
  deleteShow = id => {
    const url = "https://localhost:44387/api/show/" + id;
    fetch(url, {
      method: "POST",
      headers: {
        "Content-type": "application/json"
      }
    })
      .then(res => {
        if (res.ok) {
          console.log("good");
        }
      })
      .catch(err => {
        console.error(err);
      });
  };
  render() {
    const { show } = this.props;
    return (
      <li key={show.showId} className="show">
        <h2>{show.name}</h2>
        <small>({show.seasons} Seasons)</small>
        <p>{show.description}</p>
        <button onClick={() => this.deleteShow(show.showId)}>Delete</button>
      </li>
    );
  }
}
