import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import GridStationService from "../../services/gridstationService";
import { history } from "../../App";

const initialState = {
  currentCoordinate: { longitude: 51, latitude: 50 },
  gridstations: [],
  newGridstation: {
    name: "",
    stationName: "",
    longitude: 0,
    lattitude: 0,
    status: false
  },
  radius: 50,
  gridStationsNearby: [],
  gridstation: null
};

export const getGridStationById = createAsyncThunk(
  "gridstation/getGridStationById",
  async (id, { rejectWithValue }) => {
    try {
      return await GridStationService.getGridStationById(id);
    } catch (err) {
      return rejectWithValue(null, err);
    }
  }
);

export const updateCoordinate = createAsyncThunk(
  "gridstation/updateCoordinate",
  async (coordinate, { rejectWithValue, getState, dispatch }) => {
    try {
      const radius = getState().gridstation.radius;
      dispatch(getAllGridstationsInRadius({ coordinate, radius }));
      return coordinate;
    } catch (err) {
      return rejectWithValue(null, err);
    }
  }
);

export const updateRadius = createAsyncThunk(
  "gridstation/updateRadius",
  async (_, { rejectWithValue, getState, dispatch }) => {
    try {
      const state = getState().gridstation;
      const coordinate = state.currentCoordinate;
      const radius = state.radius;
      dispatch(getAllGridstationsInRadius({ coordinate, radius }));
    } catch (err) {
      return rejectWithValue(null, err);
    }
  }
);

export const updateGridstation = createAsyncThunk(
  "gridstation/updateGridstation",
  async (gridstation, { rejectWithValue, getState, dispatch }) => {
    try {
      const updatedGridstation = await GridStationService.updateGridstation(
        gridstation
      );
      const state = getState().gridstation;
      dispatch(
        getAllGridstationsInRadius({
          coordinate: state.currentCoordinate,
          radius: state.radius
        })
      );
      return updatedGridstation;
    } catch (err) {
      return rejectWithValue(null, err);
    }
  }
);

export const getAllGridstationsInRadius = createAsyncThunk(
  "gridstation/getAllGridstationsInRadius",
  async (data, { rejectWithValue }) => {
    try {
      return await GridStationService.getAllGridstationsInProximityOfCoordinate(
        data.coordinate,
        data.radius
      );
    } catch (err) {
      return rejectWithValue(null, err);
    }
  }
);

export const addGridstation = createAsyncThunk(
  "gridstation/addGridstation",
  async (gridstation, { rejectWithValue, getState, dispatch }) => {
    try {
      const newgridstation = await GridStationService.addGridstation(
        gridstation
      );
      const state = getState().gridstation;
      dispatch(
        getAllGridstationsInRadius({
          coordinate: state.currentCoordinate,
          radius: state.radius
        })
      );
      history.push(`/gridstation/${newgridstation.id}`);
    } catch (err) {
      return rejectWithValue(null, err);
    }
  }
);

const { actions, reducer } = createSlice({
  name: "gridstation",
  initialState,
  reducers: {
    setRadius: (state, action) => {
      state.radius = action.payload;
    },
    setGridStation: (state, action) => {
      const gridstation = state.gridstations.find(g => g.id === action.payload);
      state.gridstation = gridstation;
    },
    updateNewGridstation: (state, action) => {
      state.newGridstation = action.payload.gridStation;
    }
  },
  extraReducers: {
    [getGridStationById.fulfilled]: (state, { meta, payload }) => {
      state.gridstation = payload;
    },
    [updateCoordinate.fulfilled]: (state, { meta, payload }) => {
      state.currentCoordinate = payload;
    },
    [getAllGridstationsInRadius.fulfilled]: (state, { meta, payload }) => {
      state.gridstations = payload;
    },
    [updateGridstation.fulfilled]: (state, { meta, payload }) => {
      if (payload) {
        let gridstations = [...state.gridstations];
        const index = gridstations.findIndex(x => x.id === payload.id);
        if (index >= 0) {
          state.gridstations[index] = payload;
        }
        if (state.gridstation.id === payload.id) {
          state.gridstation = payload;
        }
        state.gridstations = gridstations;
      }
    }
  }
});

export const { updateNewGridstation, setRadius } = actions;
export default reducer;
