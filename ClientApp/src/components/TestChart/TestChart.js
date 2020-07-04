import React, { Component } from 'react';
import Chart from './chart';
import { getData } from "./utils"
import { TypeChooser } from "react-stockcharts/lib/helper";


export class ChartComponent extends Component {
	componentDidMount() {
		getData().then(data => {
			this.setState({ data })
		})
	}
	render() {
		if (this.state == null) {
			return <div>Loading...</div>
		}
		return (
			<TypeChooser>
				{type => <Chart type={type} data={this.state.data} />}
			</TypeChooser>
		)
	}
}

//render(
//	<ChartComponent />,
//	document.getElementById("root")
//);



