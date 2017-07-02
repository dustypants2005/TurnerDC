import React, {Component} from "react";
import {SearchTitles} from "./SearchApi";
import TitleList from "./TitleList";

export default class Search extends Component {
	constructor(props) {
		super(props);
		
		this.state = {
			title: '',
			titleList: [],
			filteredTitleList: [],
			error: {}
		}
	}
	
	OnChangeHandler(e){
		e.preventDefault();
		const value = e.target.value;
		this.setState( {title: value} );
	}
	
	GetTitles(e){
		e.preventDefault();
		SearchTitles( this.state.title , this.SetTitle.bind(this))
	}
	
	SetTitle(error, titles){
		if(error){
			console.log(error);
			this.setState({error});
		}
		else {
			this.setState(titles);
			const filtered = this.state.titleList.filter((title) => title.titleName.includes(this.state.title));
			console.log("filtered : ", filtered);
			this.setState({filteredTitleList: filtered})
			// need to filter the list by name
		}
	}
	
	render() {
		return (
			<div>
				{this.props.children}
				<form>
					<label>Title : </label> <input type="text" name="title" onChange={this.OnChangeHandler.bind(this)} value={this.state.title}/>
					<button onClick={this.GetTitles.bind(this)}><span className="glyphicon glyphicon-search"/> Search</button>
				</form>
				<TitleList titles={this.state.filteredTitleList}/>
				<br/><br/>
				{this.props.children}
			</div>
		);
	}
};