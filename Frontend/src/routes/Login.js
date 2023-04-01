import { Button, Input, InputLabel } from "@mui/material";
import React, { useState } from "react";
import AuthenticationService from "../services/authenticationService";

export default function Login() {
  const [password, setPassword] = useState("");
  const [username, setUsername] = useState("");
  const [error, setError] = useState("");
  const handleLogin = async () => {
    setError("");
    const user = await AuthenticationService.login(username, password);
    AuthenticationService.setUser(user);
    console.log(AuthenticationService.getUser());
    if (user) {
      window.location = "/";
    } else {
      setError("unable to login");
    }
  };
  return (
    <div style={{ width: "500px", margin: "auto" }}>
      <div
        style={{ textAlign: "center", marginTop: "50px", marginBottom: "50px" }}
      >
        <h1>Login</h1>
      </div>

      <div style={{ marginBottom: "25px" }}>
        <InputLabel>UserName</InputLabel>
        <Input
          type={"text"}
          style={{ width: "100%" }}
          value={username}
          onChange={e => setUsername(e.target.value)}
        />
      </div>
      <div style={{ marginBottom: "25px" }}>
        <InputLabel>Password</InputLabel>
        <Input
          type={"password"}
          style={{ width: "100%" }}
          value={password}
          onChange={e => setPassword(e.target.value)}
        />
      </div>
      {error && <p style={{ color: "red", textAlign: "center" }}>{error}</p>}
      <div style={{ textAlign: "right" }}>
        <Button onClick={() => handleLogin()}>Login</Button>
      </div>
    </div>
  );
}
