import React, { Component } from "react";
import Show from "./Show";

export default class Genre extends Component {
  displayAddForm = () => {
    const add = document.querySelector(`.add${this.props.genre.genreId}`);
    add.style.display = "none";
    const form = document.querySelector(`.form${this.props.genre.genreId}`);
    form.style.display = "block";
  };
  cancel = () => {
    const add = document.querySelector(`.add${this.props.genre.genreId}`);
    add.style.display = "block";
    const form = document.querySelector(`.form${this.props.genre.genreId}`);
    form.style.display = "none";
    this.props.setName("");
    this.props.setDescription("");
    this.props.setSeasons(0);
  };
  submitClick = () => {
    this.props.submit(this.props.genre.genreId);
    this.cancel();
  };
  nameChange = event => {
    this.props.setName(event.target.value);
  };
  descriptionChange = event => {
    this.props.setDescription(event.target.value);
  };
  seasonsChange = event => {
    this.props.setSeasons(event.target.value);
  };
  render() {
    const { genre, name, description, seasons } = this.props;
    const showList = genre.shows.map(show => (
      <Show key={show.showId} className="show" show={show} />
    ));
    return (
      <li key={genre.genreId} className="genre">
        <h1>{genre.name}</h1>
        <p>{genre.description}</p>
        <ul>{showList}</ul>
        <div className={`form form${genre.genreId}`}>
          <div>
            <label>Name:</label>
            <input type="text" value={name} onChange={this.nameChange} />
          </div>
          <div>
            <label>Description:</label>
            <input
              type="text"
              value={description}
              onChange={this.descriptionChange}
            />
          </div>
          <div>
            <label>Seasons:</label>
            <input
              type="number"
              value={seasons}
              onChange={this.seasonsChange}
            />
          </div>{" "}
          <div>
            <button onClick={this.submitClick}>Submit</button>
            <button onClick={this.cancel}>Cancel</button>
          </div>
        </div>
        <button
          className={`add add${genre.genreId}`}
          onClick={this.displayAddForm}
        >
          Add Show
        </button>
      </li>
    );
  }
}
