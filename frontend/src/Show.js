import React, { Component } from "react";

export default class Show extends Component {
  deleteShow = id => {
    const url = "https://localhost:44387/api/show/" + id;
    fetch(url, {
      method: "DELETE",
      headers: {
        "Content-type": "application/json"
      }
    })
      .then(res => {
        if (res.ok) {
          const hideShow = document.querySelector(`.show${id}`);
          hideShow.style.display = "none";
        }
      })
      .catch(err => {
        console.error(err);
      });
  };

  render() {
    const { show } = this.props;
    return (
      <li key={show.showId} className={`show show${show.showId}`}>
        <h2>{show.name}</h2>
        <small>({show.seasons} Seasons)</small>
        <p>{show.description}</p>
        <button onClick={() => this.deleteShow(show.showId)}>Delete</button>
      </li>
    );
  }
}
