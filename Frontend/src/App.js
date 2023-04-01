import "./App.css";
import {
  Route,
  Routes,
  unstable_HistoryRouter as HistoryRouter
} from "react-router-dom";
import { createBrowserHistory } from "history";
import MapComponent from "./components/map/MapComponent";
import GridstationDetail from "./components/gridstation/GridstationDetail";
import GridstationNew from "./components/gridstation/GridstationNew";
import GridplannerMain from "./routes/GridplannerMain";
import Header from "./components/header/Header";
import AuthenticationService from "./services/authenticationService";
import Login from "./routes/Login";

export let history = createBrowserHistory({ window });

function App() {
  const user = AuthenticationService.getUser();

  if (!user) {
    return <Login />;
  }

  return (
    <HistoryRouter history={history}>
      <div className="App">
        <Header>
          <MapComponent />
          <Routes>
            <Route exact path="/" element={<GridplannerMain />} />
            <Route
              exact
              path="/gridstation/:id"
              element={<GridstationDetail />}
            />
            <Route exact path="/gridstation" element={<GridstationNew />} />
          </Routes>
        </Header>
      </div>
    </HistoryRouter>
  );
}

export default App;
