import React, { Component } from 'react';
import './Home.css';
import { Link } from 'react-router-dom';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
    <div className="div-content">
    <div className="div-content">
      <div className="text-mask">
        <h1>Your motivation for a life</h1>
      </div>
    </div>
    <div className="microcontent">
      <p className="text-mask-white">Welcome to the site that will change your life in 5 minutes!!!</p>
      <Link to="/fetch-data">
      <button className="btn btn-primary">Register</button>
      </Link>
      <p className="text-mask-white">Register now and we will sent you check list "How to set the right goals"</p>
    </div>
    </div>
   );
  }
}
