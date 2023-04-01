import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { updateCoordinate } from "../../redux/reducers/gridstationSlice";
import CurrentLocation from "../currentLocation/CurrentLocation";
import GridstationMap from "./GridstationMap";
import RadiusSelector from "../radiusSelector/RadiusSelector";

export default function MapComponent() {
  const gridstations = useSelector(state => state.gridstation.gridstations);

  const dispatch = useDispatch();
  const currentCoordinate = useSelector(
    state => state.gridstation.currentCoordinate
  );

  const getLocation = () => {
    if (!navigator.geolocation) {
      console.log("Fetching geodata not possible");
    } else {
      navigator.geolocation.getCurrentPosition(p => {
        if (p)
          dispatch(
            updateCoordinate({
              latitude: p.coords.latitude,
              longitude: p.coords.longitude
            })
          );
      });
    }
  };

  useEffect(() => {
    getLocation();
  });

  return (
    <React.Fragment>
      <div style={{ marginBottom: "35px", marginTop: "50px" }}>
        <div
          style={{
            display: "flex",
            justifyContent: "space-between",
            width: "80%",
            margin: "auto"
          }}
        >
          <CurrentLocation />
          <RadiusSelector />
        </div>

        <GridstationMap
          coordinate={currentCoordinate}
          gridstations={gridstations}
        />
      </div>
    </React.Fragment>
  );
}
