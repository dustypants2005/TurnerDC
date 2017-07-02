/**
 * Created by Dustin on 7/2/2017.
 */
import React, {Component} from "react";

export default class Title extends Component{
	constructor(props){
		super(props);
		this.state = {
			title: {...props.title}
		}
	}
	render(){
		return(
			<div>Name: {this.props.title.titleName}</div>
		)
	}
}
