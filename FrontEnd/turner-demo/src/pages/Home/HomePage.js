import React, {Component} from "react";
import Search from "./Search";

export default class HomePage extends Component {
	render() {
		return (
		<div>
			{this.props.children}
			<Search/>
		</div>
		);
	}
}