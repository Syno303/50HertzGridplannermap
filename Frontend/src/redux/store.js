import { configureStore } from "@reduxjs/toolkit";
import gridstationsReducer from "./reducers/gridstationSlice";
import { combineReducers } from "redux";

const reducer = combineReducers({
  gridstation: gridstationsReducer
});

const store = configureStore({
  reducer,
  middleware: getDefaultMiddleware => getDefaultMiddleware(),
  devTools: true
});

export default store;
