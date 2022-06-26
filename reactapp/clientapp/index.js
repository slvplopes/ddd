import React, { useState, useEffect } from 'react'
import ReactDOM from 'react-dom'

const restEndpoint = "https://localhost:44354/api/CatFact";

const callRestApi = async () => {
    const response = await fetch(restEndpoint);
    const jsonResponse = await response.json();
    console.log(jsonResponse);
    return jsonResponse
};

function RenderResult() {
  const [apiResponse, setApiResponse] = useState("*** now loading ***");

  useEffect(() => {
      callRestApi().then(
          result => setApiResponse(result));
  },[]);

  const CatFact = (props) => {
    return [
        <div>
            <p>{props.content.fact}</p>
            <p>This cat fact was created on: {props.content.createdOn}</p>
            
            <p>JSON:</p>
            {JSON.stringify(props.content)}
        </div>
    ]
 }
 
  return(
        <div class="row">
        <div class="col s12 m6">
        <div class="card blue-grey darken-1">
            <div class="card-content white-text">
            <span class="card-title">Did you know that</span>
                <CatFact content={apiResponse}/>
            </div>
        </div>
        </div>
        </div>
  );
};

ReactDOM.render(<RenderResult/>, document.getElementById('root'))
