import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { setRadius, updateRadius } from "../../redux/reducers/gridstationSlice";
import { Button } from "@mui/material";

export default function RadiusSelector() {
  const dispatch = useDispatch();
  const radius = useSelector(state => state.gridstation.radius);
  return (
    <div style={{ display: "flex", justifyContent: "center" }}>
      <h5 style={{ marginRight: "15px" }}>Search radius:</h5>
      <div>
        <input
          type="number"
          min={1}
          value={radius}
          onChange={e => dispatch(setRadius(e.target.value))}
        ></input>
      </div>
      <div>
        <Button onClick={e => dispatch(updateRadius())}>Set</Button>
      </div>
    </div>
  );
}
