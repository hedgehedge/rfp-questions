import React, { useState, useEffect } from 'react'
import './Component.css';
import Highlighter from "react-highlight-words";

export default function RfpQuestion({searchVal}) {
  const [foundItems, initFind] = useState([])
  const fetchData = async () => {
    const response = await fetch('https://localhost:7249/RfpQuestion?searchVal=' + searchVal)
    if (!response.ok) {
        throw new Error('Data coud not be fetched!')
    } else {
        return response.json()
    }
  }

  useEffect(() => {
    if(searchVal !== '') {
      fetchData()
        .then((res) => {
          initFind(res)
        })
        .catch((e) => {
          console.log(e.message)
        })
    }
    else {
      initFind([])
    }
  }, [searchVal])

  const convertTorray = () => {
    const specialWords = ["AND", "OR"];
    const arrWords = [];
    const singleWords = searchVal.split(" ");
    //const singleWords = searchVal.split(/["]/);
    //console.log("SingleWord: " + singleWords[0]);
    singleWords.forEach(singleWord => {
      if(specialWords.findIndex(el => {
        return el === singleWord;
      }) === -1)
        arrWords.push(singleWord);
    });
    return arrWords;
  }

  return (
    <div>
      {foundItems.map((item, idx) => {
        return (
          <div className="mb-3" key={idx}>
            <div className="card text-white bg-dark border-dark h-100">
              <div className="card-header">
                {item.name}
              </div>
              {/* <div className="card-body">
                <h5 className="card-title">{item.name}</h5>
              </div> */}
              <ul className="list-group list-group-flush">
                <li className="list-group-item">
                  <div>
                    <div>
                      <strong>Document Url:</strong>
                    </div>
                    <div>
                      <a href={item.url}>{item.url}</a>
                    </div>
                  </div>
                </li>
                <li className="list-group-item">
                  <div>
                    <div>
                      <strong>Content:</strong>
                    </div>
                    <div>
                      <div className="scrollable">
                        <Highlighter
                          highlightClassName="highlight"
                          searchWords={convertTorray()}
                          autoEscape={true}
                          textToHighlight={item.content}
                        />
                      </div>
                    </div>
                  </div>
                </li>
                <li className="list-group-item">
                  <div>
                    <div>
                      <strong>Date:</strong>
                    </div>
                    <div>
                      {item.date}
                    </div>
                  </div>
                </li>
              </ul>
            </div>
          </div>
        )
      })}
    </div>
  )
};

// RfpQuestion.propTypes = {
//   searchVal: PropTypes.string.isRequired
// };