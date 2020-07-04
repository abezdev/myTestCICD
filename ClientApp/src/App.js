import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { StockMainPage } from './components/StockMainPage/StockMainPage';
import { ChartComponent } from './components/TestChart/TestChart';

import './custom.css'


import { TestHome } from './components/TestHome/TestHome';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route path='/fetch-data' component={FetchData} />
                <Route exact path='/TestHome' component={TestHome} />
                <Route exact path='/StockMainPage' component={StockMainPage} />
                <Route exact path='/TestChart' component={ChartComponent} />
            </Layout>
        );
    }
}
