import React, { Component } from 'react';
import * as formUtilityActions from '../../Utility/FormUtility';
import { Form, Well, Button, FormGroup, Col } from 'react-bootstrap';
import { returnInputConfiguration } from '../../Utility/InputConfiguration';
import SuccessModal from '../../components/Modals/SuccessModal/SuccessModal';
import ErrorModal from '../../components/Modals/ErrorModal/ErrorModal';
import Input from '../../UI/Inputs/Input';

export class TestHome extends Component {
    static displayName = TestHome.name;


    state = {
        ownerForm: {},
        isFormValid: false
    }

    componentWillMount = () => {
        this.setState({ ownerForm: returnInputConfiguration() });
    }

    handleChangeEvent = (event, id) => {
        const updatedOwnerForm = { ...this.state.ownerForm };
        updatedOwnerForm[id] = formUtilityActions.executeValidationAndReturnFormElement(event, updatedOwnerForm, id);

        const counter = formUtilityActions.countInvalidElements(updatedOwnerForm);

        this.setState({ ownerForm: updatedOwnerForm, isFormValid: counter === 0 })
    }
    createOwner = (event) => {
        event.preventDefault();

        const ownerToCreate = {
            name: this.state.ownerForm.name.value,
            address: this.state.ownerForm.address.value,
            dateOfBirth: this.state.ownerForm.dateOfBirth.value
        }

        const url = '/api/owner';
        this.props.onCreateOwner(url, ownerToCreate, { ...this.props });
    }
    redirectToOwnerList = () => {
        this.props.history.push('/owner-List');
    }
    render() {
        const formElementsArray = formUtilityActions.convertStateToArrayOfFormObjects({ ...this.state.ownerForm });


        return (
            <Well>
                <Form horizontal onSubmit={this.createOwner}>
                    {
                        formElementsArray.map(element => {
                            return <Input key={element.id} elementType={element.config.element}
                                id={element.id} label={element.config.label}
                                type={element.config.type} value={element.config.value}
                                changed={(event) => this.handleChangeEvent(event, element.id)}
                                errorMessage={element.config.errorMessage}
                                invalid={!element.config.valid} shouldValidate={element.config.validation}
                                touched={element.config.touched}
                                blur={(event) => this.handleChangeEvent(event, element.id)} />
                        })
                    }
                    <br /><FormGroup>
                        <Col mdOffset={6} md={1}>
                            <Button type='submit' bsStyle='info' disabled={!this.state.isFormValid}>Create</Button>
                        </Col>
                        <Col md={1}>
                            <Button bsStyle='danger' onClick={this.redirectToOwnerList}>Cancel</Button>
                        </Col>
                    </FormGroup>
                    <SuccessModal show={this.props.showSuccessModal}
                        modalHeaderText={'Success message'}
                        modalBodyText={'Action completed successfully'}
                        okButtonText={'OK'}
                        successClick={() => this.props.onCloseSuccessModal('/owner-List', { ...this.props })} />

                    <ErrorModal show={this.props.showErrorModal}
                        modalHeaderText={'Error message'}
                        modalBodyText={this.props.errorMessage}
                        okButtonText={'OK'} closeModal={() => this.props.onCloseErrorModal()} />
                </Form>
            </Well>
        )
    }



    //constructor(props) {
    //    super(props);
    //    this.state = { forecasts: [], loading: true };
    //}

    //componentDidMount() {
    //    this.CALLCONTROLLER();
    //}

    //static renderForecastsTable(forecasts) {
    //    return (
    //        <table className='table table-striped' aria-labelledby="tabelLabel">
    //            <thead>
    //                <tr>
    //                    <th>Date</th>
    //                    <th>Temp. (C)</th>
    //                    <th>Temp. (F)</th>
    //                    <th>Summary</th>
    //                </tr>
    //            </thead>
    //            <tbody>
    //                {forecasts.map(forecast =>
    //                    <tr key={forecast.date}>
    //                        <td>{forecast.date}</td>
    //                        <td>{forecast.temperatureC}</td>
    //                        <td>{forecast.temperatureF}</td>
    //                        <td>{forecast.summary}</td>
    //                    </tr>
    //                )}
    //            </tbody>
    //        </table>
    //    );
    //}

    //render() {
    //    let contents = this.state.loading
    //        ? <p><em>Loading...</em></p>
    //        : TestHome.renderForecastsTable(this.state.forecasts);

    //    return (
    //        <div>
    //            <h1 id="tabelLabel" >Weather forecast</h1>
    //            <p>This component demonstrates fetching data from the server.</p>
    //            {contents}
    //        </div>
    //    );
    //}

    //async CALLCONTROLLER() {
    //    const response = await fetch('test');
    //    const data = await response.json();
    //    this.setState({ forecasts: data, loading: false });
    //}


}
