import React from "react";
import { useSelector } from "react-redux";

export default function CurrentLocation(props) {
  const currentCoordinate = useSelector(
    state => state.gridstation.currentCoordinate
  );
  return (
    <div style={{ display: "flex", justifyContent: "center" }}>
      <div>
        <h5 style={{ marginRight: "10px" }}>Current location:</h5>
      </div>
      <div style={{ marginTop: "1px" }}>
        <p>
          {`Latitude:   ${currentCoordinate.latitude} - Longitude:   ${currentCoordinate.longitude}`}
        </p>
      </div>
    </div>
  );
}
