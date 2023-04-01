import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { addGridstation } from "../../redux/reducers/gridstationSlice";
import { Button, Input, InputLabel, Switch } from "@mui/material";
import "./GridstationNew.css";
import { history } from "../../App";

export default function GridstationNew() {
  const [name, setName] = useState("Contact name");
  const [stationName, setStationName] = useState("Station X");
  const [long, setLong] = useState("4.7874048");
  const [lat, setLat] = useState("50.8755968");
  const [status, setStatus] = useState(false);
  const [kilovoltage, setKilovoltage] = useState(380);
  const dispatch = useDispatch();

  const saveGridstation = () => {
    let gridstation = {
      contact: { name: name },
      stationName: stationName,
      coordinate: {
        longitude: long,
        latitude: lat
      },
      status: status,
      kilovoltage: kilovoltage
    };
    dispatch(addGridstation(gridstation));
    history.push("/");
  };
  return (
    <div style={{ width: "500px", margin: "auto" }}>
      <h5 style={{ marginBottom: "45px" }}>Create new gridstation</h5>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Stationname</InputLabel>
        <Input
          type={"text"}
          style={{ width: "100%" }}
          value={stationName}
          onChange={e => setStationName(e.target.value)}
        />
      </div>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Contactname</InputLabel>
        <Input
          type={"text"}
          style={{ width: "100%" }}
          value={name}
          onChange={e => setName(e.target.value)}
        />
      </div>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Latitude</InputLabel>
        <Input
          type={"number"}
          style={{ width: "100%" }}
          value={lat}
          onChange={e => setLat(e.target.value)}
        />
      </div>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Longitude</InputLabel>
        <Input
          type={"number"}
          style={{ width: "100%" }}
          value={long}
          onChange={e => setLong(e.target.value)}
        />
      </div>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Kilovoltage</InputLabel>
        <Input
          type={"number"}
          value={kilovoltage}
          style={{ width: "100%" }}
          onChange={e => setKilovoltage(e.target.value)}
        />
      </div>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Status</InputLabel>
        <Switch checked={status} onClick={() => setStatus(!status)} />
      </div>

      <div style={{ textAlign: "right" }}>
        <Button onClick={() => saveGridstation()}>CREATE</Button>
      </div>
      <div></div>
    </div>
  );
}
