import React, { Component } from 'react';
import './Home.css';

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
      <p className="text-mask-white">Text TextTextTextText  TextTextTextText TextTextTextText TextTextTextText TextTextTextText</p>
    </div>

    </div>
   );
  }
}
