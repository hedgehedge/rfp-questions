import React, {Component} from 'react';
import RfpQuestion from './RfpQuestions'
import { SearchData } from './SearchData';

class SearchResult extends Component {
    state = {
        searchVal: "",
        searchValFinal: ""
    };

    handleInputChange = event => {
        const target = event.target;
        const value = target.value;
        const name = target.name;
        console.log(value);
        this.setState({
          [name]: value
        });
      };

    searchPhrase = event => {
        event.preventDefault();
        this.setState({
            searchValFinal: this.state.searchVal
        });
    };

    render() {
        const {searchVal, searchValFinal} = this.state;
        return (
            <div>
                <SearchData
                    searchVal={searchVal}
                    onChange={this.handleInputChange}
                    onSubmit={this.searchPhrase}
                />
                <br/>
                <br/>
                <div>
                    <RfpQuestion 
                        searchVal={searchValFinal}
                    />
                </div>
            </div>
        )
    }
}

export default SearchResult;