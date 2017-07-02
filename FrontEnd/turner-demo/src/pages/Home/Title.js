/**
 * Created by Dustin on 7/2/2017.
 */
import React, {Component} from "react";
import TitleDetails from "./TitleDetails";

export default class Title extends Component{
	constructor(props){
		super(props);
		this.state = {
			title: {...props.title}
		}
	}
	render(){
		return(
			<div>
				Name: {this.props.title.titleName} <TitleDetails title={this.props.title}/>
				
			</div>
		)
	}
}
