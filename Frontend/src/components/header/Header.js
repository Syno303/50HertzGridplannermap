import { Button } from "@mui/material";
import React from "react";
import { history } from "../../App";
import AuthenticationService from "../../services/authenticationService";

export default function Header(props) {
  const handleLogout = () => {
    AuthenticationService.setUser(null);
    window.location = "/";
  };
  return (
    <div style={{ height: "250px" }}>
      <Button
        onClick={() => {
          history.push("/");
        }}
      >
        HOME
      </Button>
      {AuthenticationService.isUserGridPlanner() && (
        <Button
          onClick={() => {
            history.push("/gridstation");
          }}
        >
          NEW GRIDSTATION
        </Button>
      )}

      <Button onClick={() => handleLogout()}>LOGOUT</Button>

      <div>{props.children}</div>
    </div>
  );
}
