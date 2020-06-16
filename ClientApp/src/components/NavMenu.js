import React, { Component } from 'react';
//import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import { Col, Navbar, Nav, NavItem } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';
import { LinkContainer } from 'react-router-bootstrap';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    //return (
    //  <header>
    //    <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
    //      <Container>
    //        <NavbarBrand tag={Link} to="/">myTestCICD</NavbarBrand>
    //        <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
    //        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
    //          <ul className="navbar-nav flex-grow">
    //            <NavItem>
    //              <NavLink tag={Link} className="text-dark" to="/">Home</NavLink>
    //            </NavItem>
    //            <NavItem>
    //              <NavLink tag={Link} className="text-dark" to="/counter">Counter</NavLink>
    //            </NavItem>
    //            <NavItem>
    //              <NavLink tag={Link} className="text-dark" to="/fetch-data">Fetch data</NavLink>
    //            </NavItem>
    //          </ul>
    //        </Collapse>
    //      </Container>
    //    </Navbar>
    //  </header>
    //);
      return (
          <Col md={12} >
              <Navbar inverse collapseOnSelect>

                  <Navbar.Header>
                      <Navbar.Brand>
                          <NavLink to={'/'} exact >Account-Owner  </NavLink>
                      </Navbar.Brand>
                      <Navbar.Toggle />
                  </Navbar.Header>

                  <Navbar.Collapse>
                      <Nav>
                          <LinkContainer to={'/owner-list'} exact>
                              <NavItem eventKey={1}>
                                  Owner Actions
                            </NavItem>
                          </LinkContainer>
                          <LinkContainer to={'/account-list'}>
                              <NavItem eventKey={2}>
                                  Account Actions
                            </NavItem>
                          </LinkContainer>
                      </Nav>
                  </Navbar.Collapse>
              </Navbar>
          </Col>
      )
  }
}
