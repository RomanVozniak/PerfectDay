import React, { Component } from 'react';
import './FetchData.css';

export class FetchData extends Component {
  static displayName = FetchData.name;
  constructor(props){
    super(props);

    this.state = {
      email: "",
      password: "",
      password_confirmation: "",
      registrationErrors: ""
    }

    this.handleSubmit = this.handleSubmit.bind(this);
    this.handleChange = this.handleChange.bind(this);
  }

  handleChange(event){
    this.setState({
      [event.target.name]: event.target.value
    })
  }

  handleSubmit(event){
    console.log("form submitted")
    event.preventDefault();
  }

  render() {
      return (
        <div class = "myPadding">
          <form onSubmit = {this.handleSubmit}>
            <div className="form-group">
              <div class = "myLabel">
                <label className="text-mask">Email</label>
              </div>
              <input type = "email" 
              name = "email" 
              placeholder = "Email" 
              value = {this.state.email} 
              onChange = {this.handleChange} 
              required
              />
            </div>

            <div className="form-group">
              <div class = "myLabel">
                <label className="text-mask">Password</label>
              </div>
              <input type = "password" 
              name = "password" 
              placeholder = "Password" 
              value = {this.state.password} 
              onChange = {this.handleChange} 
              required
              />
            </div>

            <div className="form-group">
              <div class = "myLabel">
              <label className="text-mask">Password confirmation</label>
              </div>
              <input type = "password" 
              name = "password_confirmation" 
              placeholder = "Password confirmation" 
              value = {this.state.password_confirmation} 
              onChange = {this.handleChange} 
              required
              />
            </div>

            <button type = "submit">Register</button>
          </form>
        </div>
      );
  }
}