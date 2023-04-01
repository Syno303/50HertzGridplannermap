import instance from "../api/webapi";

class AuthenticationService {
  login(username, password) {
    const data = {
      username,
      password
    };
    console.log(username, password);
    return instance.post(`login`, data).then(response => {
      return response.data;
    });
  }

  isUserGridPlanner() {
    const userString = sessionStorage.getItem("user");
    const user = JSON.parse(userString);
    return user && user.claims.findIndex(x => x === "gridplanner") >= 0;
  }

  setUser(user) {
    sessionStorage.setItem("user", JSON.stringify(user));
  }

  getUser() {
    const userString = sessionStorage.getItem("user");
    const user = JSON.parse(userString);
    return user;
  }
}
export default new AuthenticationService();
