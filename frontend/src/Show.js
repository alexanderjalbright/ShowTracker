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

  editClick = () => {
    const show = document.querySelector(
      `.show-content${this.props.show.showId}`
    );
    show.style.display = "none";
    const update = document.querySelector(`.update${this.props.show.showId}`);
    update.style.display = "block";
  };

  cancel = () => {
    const show = document.querySelector(
      `.show-content${this.props.show.showId}`
    );
    show.style.display = "block";
    const update = document.querySelector(`.update${this.props.show.showId}`);
    update.style.display = "none";
    this.props.setName("");
    this.props.setDescription("");
    this.props.setSeasons(0);
  };

  submitClick = () => {
    this.props.submitShow(this.props.show.showId, this.props.show.genreId);
    this.cancel();
  };

  render() {
    const { show } = this.props;
    return (
      <li key={show.showId} className={`show show${show.showId}`}>
        <div className={`show-content show-content${show.showId}`}>
          <h2>{show.name}</h2>
          <small>({show.seasons} Seasons)</small>
          <p>{show.description}</p>
        </div>
        <div className={`update update${show.showId}`}>
          <div>
            <label>Name:</label>
            <input
              type="text"
              value={this.props.name}
              onChange={this.props.nameChange}
            />
          </div>
          <div>
            <label>Description:</label>
            <input
              type="text"
              value={this.props.description}
              onChange={this.props.descriptionChange}
            />
          </div>
          <div>
            <label>Seasons:</label>
            <input
              type="number"
              value={this.props.seasons}
              onChange={this.props.seasonsChange}
            />
          </div>
          <button onClick={this.submitClick}>Submit</button>
          <button onClick={this.cancel}>Cancel</button>
        </div>
        <button onClick={this.editClick}>Edit</button>
        <button onClick={() => this.deleteShow(show.showId)}>Delete</button>
      </li>
    );
  }
}
