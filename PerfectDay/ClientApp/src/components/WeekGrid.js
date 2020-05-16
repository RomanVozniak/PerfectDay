import React, { Component } from 'react'
import { Container, Row, Col } from 'react-grid-system'
import axios from 'axios'

import './Grid.css'


const ListOfHours = ['0:00', '1:00', '2:00', '3:00', '4:00', '5:00', '6:00', '7:00', '8:00', '9:00', '10:00',
 '11:00', '12:00', '13:00', '14:00', '15:00', '16:00', '17:00', '18:00', '19:00', '20:00', '21:00', '22:00', '23:00']
  const GridOfHours = ListOfHours.map(hour => {
    return(
      <Col style = {{backgroundColor : 'BlueViolet'}} debug key={hour}>{hour}</Col>
    )
  })

 function checkDay(day, index){
   let event = new Date()
  if (index == new Date().getDay()-1)
  {
     return(
       <React.Fragment>
      <strong style={{color: 'FireBrick'}}>{day}</strong>
      <p>{new Date().getDate()}</p>
     </React.Fragment>
     )
    }
  else
  {
    event.setDate(new Date(event.getDate() - (event.getDay() -index-1)))
    return(
      <React.Fragment>
      <strong>{day}</strong>
      <p>{event.getDate()}</p>
      </React.Fragment>
    )
  }
}
const ListOfDays = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']  
  const GridOfDays = ListOfDays.map(day =>{
    return(
        <Col style={{backgroundColor : "MediumPurple"}} xs={1} debug key = {day}>
        {checkDay(day,ListOfDays.indexOf(day))}
        <Row>        
          {GridOfHours}
        </Row>
        </Col>
    )
  })

export class WeekGrid extends Component {
  state = {
    tasks: [],
    curTime:  new Date().toLocaleString(),
    curDate: new Date().toLocaleDateString(),
    DateTime: new Date()
  }
  componentDidMount(){
    axios.get('https://localhost:5001/api/task').then(res =>{
      console.log(res)
      this.setState({
        tasks: res.data
      })
    })
}
    render() {
      const { tasks } = this.state;
      const tasksList = tasks.length ? (
        tasks.map(task =>{
          return(
            <div className = "post card" key = {task.id}>
              <div className = "card-component">
                <span className = "card-title">{task.id}</span>
                <p>{task.category}</p>
                <p>{new Date(task.startDateTime).toLocaleString()}</p>
                <p>{new Date(task.endDateTime).toLocaleString()}</p>
              </div>
            </div>
          )
        })
      ) : (
        <div className="center">No tasks</div>
      )
        return (
            <Container className="week" fluid>
            {tasksList}
            <p>Current full time is {this.state.curTime}</p>
            <p>Current date is {this.state.curDate}</p>
            <p>Current day is {this.state.DateTime.getDate()}</p>
            <p>Current day of week is {this.state.DateTime.getDay()}</p>
            <br/>
            <Row justify="center" debug>
            {GridOfDays}
              </Row>
            </Container>
            )
    }
}