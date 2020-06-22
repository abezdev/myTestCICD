import React, { Component } from 'react';


export class StockMainPage extends Component {
    constructor(props) {
        super(props);
        this.state = {
            input: '',
            submit: '',
            li: []
        };

        //TODO SEND LIST TO CONTEROLLER TO MAKE API CALLS
        //CONTRTOLLER TO EVENTUALLY SAVE SEARCHES VALUES INTO DB (HAVE RECENT API VALUES TOO)
        //
        //https://stackoverflow.com/questions/47298702/how-to-send-data-from-react-to-controller-in-asp-net-mvc
        //https://stackoverflow.com/questions/58032403/react-post-data-to-asp-net


        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleChange(event) {
        this.setState({
            input: event.target.value
        });
    }
    handleSubmit(event) {
        event.preventDefault()
        let newGrocery = this.state.input
        this.setState({
            submit: this.state.input,
            li: [...this.state.li, newGrocery]
        });
    }


    render() {
        //const listItems = this.state.li.map((li) =>
        //    <li>{li}</li>
        //);
        const listItems = this.state.li.map((TICKER) =>
            <li key={TICKER.toString()}>
                {TICKER}
            </li>
        );

        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <input
                        value={this.state.input}
                        onChange={this.handleChange} />
                    <button type='submit'>add!</button>
                </form>
                <h1>{this.state.submit}</h1>

                <ul>{listItems}</ul>

            </div>

        );
    }
};