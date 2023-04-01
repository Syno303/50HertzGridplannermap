import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { updateGridstation } from "../../redux/reducers/gridstationSlice";
import { Input, InputLabel, Switch } from "@mui/material";
import AuthenticationService from "../../services/authenticationService";

export default function Gridstation() {
  const gridstation = useSelector(state => state.gridstation.gridstation);
  const canEdit = AuthenticationService.isUserGridPlanner();

  const dispatch = useDispatch();

  const switchStatus = () => {
    dispatch(
      updateGridstation({
        id: gridstation.id,
        stationName: gridstation.stationName,
        contact: { name: gridstation.contact.name },
        status: !gridstation.status
      })
    );
  };

  useEffect(() => {}, [gridstation]);

  return (
    gridstation && (
      <div style={{ width: "500px", margin: "auto" }}>
        <h5 style={{ marginBottom: "45px" }}>
          Details of gridstation {gridstation.contact.name}
        </h5>

        <div style={{ marginBottom: "25px" }}>
          <InputLabel>Stationname</InputLabel>
          <Input
            type={"text"}
            style={{ width: "100%" }}
            value={gridstation.stationName}
          />
        </div>
        <div style={{ marginBottom: "25px" }}>
          <InputLabel>Contactname</InputLabel>
          <Input
            type={"text"}
            style={{ width: "100%" }}
            value={gridstation.contact.name}
          />
        </div>
        <div style={{ marginBottom: "25px" }}>
          <InputLabel>Latitude</InputLabel>
          <Input
            type={"text"}
            style={{ width: "100%" }}
            value={gridstation.coordinate.latitude}
          />
        </div>
        <div style={{ marginBottom: "25px" }}>
          <InputLabel>Longitude</InputLabel>
          <Input
            type={"text"}
            style={{ width: "100%" }}
            value={gridstation.coordinate.longitude}
          />
        </div>
        <div style={{ marginBottom: "25px" }}>
          <InputLabel>Kilovoltage</InputLabel>
          <Input
            type={"text"}
            value={gridstation.kilovoltage}
            style={{ width: "100%" }}
          />
        </div>
        <div style={{ marginBottom: "25px" }}>
          <InputLabel>Status</InputLabel>
          <Switch
            disabled={!canEdit}
            checked={gridstation.status}
            onClick={() => switchStatus()}
          />
        </div>
      </div>
    )
  );
}
