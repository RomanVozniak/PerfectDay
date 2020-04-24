import React, { Component } from 'react'
import { Container, Row, Col} from 'react-grid-system'

import './Grid.css' 


export class Grid extends Component {
    render() {
        return (
            <Container fluid>
            <Row justify="start" debug>
            <Col xs={1.5} debug>Monday</Col>
            <Col xs={1.5} debug>Tuesday</Col>
            <Col xs={1.5} debug>Wednesday</Col>
            <Col xs={1.5} debug>Thursday</Col>
            <Col xs={1.5} debug>Friday</Col>
            <Col xs={1.5} debug>Saturday</Col>
            <Col xs={1.5} debug>Sunday</Col>
              </Row>
            </Container>
            
            )
    }
}