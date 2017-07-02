/**
 * Created by Dustin on 7/2/2017.
 */
import React, {Component} from "react"
import Title from "./Title";

class TitleList extends Component {
	constructor(props){
		super(props);
		this.state = {
			titles: this.props.titles
		}
	}
	
	GetTitles(titles){
		if(titles && titles.length > 0){
			return titles.map((t,i) =>
				 <Title title={t} key={i}/>
			);
		}
	}
	
	render(){
		return(
			<div>
				{this.GetTitles(this.props.titles)}
			</div>
		)
	}
}

export default TitleList;