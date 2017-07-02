import React, { Component } from 'react';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import {
	BrowserRouter as Router,
	Route,
	Link
} from 'react-router-dom';
import Home from "./pages/Home/HomePage";
import createHistory from "history/createBrowserHistory";
const history = createHistory();


class App extends Component {
  render() {
    return (
      <Router history={history}>
        <div className="container">
          <nav className="navbar navbar-default">
            <div className="navbar-header">
              <div className="navbar-brand">
                <Link to="/">Demo</Link>
              </div>
            </div>
            <ul className="nav navbar-nav">
              <li><Link to="/">Home</Link></li>
            </ul>
          </nav>
			    {this.props.children}
          <Route exact path={"/"} component={Home}/>
        </div>
      </Router>
    );
  }
}

export default App;
