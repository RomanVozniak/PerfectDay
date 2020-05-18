import React, { Component } from 'react'
import { Container, Row, Col } from 'react-grid-system'
import axios from 'axios'

import './Grid.css'
import { NavLink } from 'react-router-dom'


const ListOfHours = ['0:00', '1:00', '2:00', '3:00', '4:00', '5:00', '6:00', '7:00', '8:00', '9:00', '10:00',
 '11:00', '12:00', '13:00', '14:00', '15:00', '16:00', '17:00', '18:00', '19:00', '20:00', '21:00', '22:00', '23:00']

function GetDayByTheirName(day, index) {
    let event = new Date()
    if (index == new Date().getDay()) {
        return event.toLocaleDateString()
    }
    else {
        event.setDate(new Date(event.getDate() - (event.getDay() - index)))
        return event.toLocaleDateString()
    }

}

 function checkDay(day, index){
   let event = new Date()
  if (index == new Date().getDay()) //-1
  {
     return(
       <React.Fragment>
      <strong style={{color: 'FireBrick'}}>{day}</strong>
      <p style={{color: 'FireBrick'}}>{new Date().getDate()}</p>
     </React.Fragment>
     )
    }
  else
  {
    event.setDate(new Date(event.getDate() - (event.getDay() -index))) //-1
    return(
      <React.Fragment>
      <strong>{day}</strong>
            <p>{event.getDate()}</p>
            <p>{event.toLocaleDateString()}</p>
      </React.Fragment>
    )
  }
}


  const ListOfDaysInThisWeek = ListOfDays.map(dayInWeek =>{
    let event = new Date()
    return event.getDate(event.setDate(new Date(event.getDate() - (event.getDay() -ListOfDays.indexOf(dayInWeek))))) //-1
  })
//   function checkHour (tasks, ListOfHours){
//     var starts = tasks.map(returnStart)
//     var ends = tasks.map(returnEnd)
//     for(var i = 0; i < ListOfDaysInThisWeek.length; i++){
//       if(ListOfDaysInThisWeek[i] == starts.getDate()){
//         for (var j = 0; j < ListOfHours.length;j++){
//           // if (j == )
//         }
//       }
//     }
// }
// function returnStart(tasks){
//   return new Date(tasks.startDateTime).toLocaleString()
// }
// function returnEnd(tasks){
//   return new Date(tasks.endDateTime).toLocaleString()
// }
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
        const ListOfDays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"]//['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']  
        const GridOfDays = ListOfDays.map(day => {
            return (
                <Col style={{ backgroundColor: "MediumPurple" }} xs={1} debug key={day}>
                    {checkDay(day, ListOfDays.indexOf(day))}
                    <Row>
                        {ListOfHours.map(hour => {
                            var task = tasks.find((hour, GetDayByTheirName(day, ListOfDays.indexOf(day))) => {
                            return 
                                      }
                                          return (
                                <Col style={{ backgroundColor: 'BlueViolet' }} debug key={hour}>{hour} {day}</Col>
                            )
                        })}
                    </Row>
                </Col>
            )
        })
        return (
            <Container className="week" fluid>
            <Row justify="center" debug>
            {GridOfDays}
              </Row>
            </Container>
            )
    }
}