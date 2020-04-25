import React, { Component } from 'react'
import { Container, Row, Col, Visible, Hidden,Grid} from 'react-grid-system'

import './Grid.css'


const ListOfHours = ['0:00', '1:00', '2:00', '3:00', '4:00', '5:00', '6:00', '7:00', '8:00', '9:00', '10:00',
 '11:00', '12:00', '13:00', '14:00', '15:00', '16:00', '17:00', '18:00', '19:00', '20:00', '21:00', '22:00', '23:00']
  const GridOfHours = ListOfHours.map(hour => {
    return(
      <Col debug>{hour}</Col>
    )
  })
const ListOfDays = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']  
  const GridOfDays = ListOfDays.map(day =>{
    return(
        <Col xs={1} debug>
        <strong>{day}</strong>
        <Row>
          {GridOfHours}
        </Row>
        </Col>
    )
  })
export class WeekGrid extends Component {
    render() {
        return (
            <Container className="week" fluid>
            <Row  justify="center" debug>
            {GridOfDays}
              </Row>
            </Container>           
            )
    }
}