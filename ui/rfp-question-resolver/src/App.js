import logo from './logo.svg';
import './App.css';
import "bootstrap/dist/css/bootstrap.min.css"
// import RfpQuestion from './components/RfpQuestions'
// import { SearchData } from './components/Search';
import SearchResult from './components/SearchResult'

function App() {
  return (
    <div className="container mt-5">
      <SearchResult />
    </div>
  );
}

export default App;
