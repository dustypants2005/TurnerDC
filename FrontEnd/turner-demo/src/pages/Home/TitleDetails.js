import React, {Component} from "react";
import './Modal.css';

class TitleDetails extends Component {
	constructor(props){
		super(props);
		this.state = {
			title: {...props.title}
		}
	}
	
	LoadModal(e){
		let modal = document.getElementById("modal");
		let caption = document.getElementById("caption");
		
		modal.style.display = "block";
		caption.innerHTML = JSON.stringify(this.state.title);
		
	}
	
	CloseModal(e){
		// e.target.style.display = "none";
		Array.from(document.getElementsByClassName("modal")).forEach(function(i) { i.style.display = "none"});
	}
	
	render() {
		return (
			<div >
				<button onClick={this.LoadModal.bind(this)}>More Info</button>
				<div id="modal" className="modal container" onClick={this.CloseModal.bind(this)}>
					<span className="close">&times;</span>
					<div>
						<div id="caption" className="caption"></div>
					</div>
				</div>
			</div>
		);
	}
}


export default TitleDetails;