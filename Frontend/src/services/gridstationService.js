import instance from "../api/webapi";

class GridStationService {
  getGridStationById(id) {
    return instance.get(`gridstation/${id}`).then(response => {
      return response.data;
    });
  }

  getAllGridstations() {
    return instance.get(`gridstation`).then(response => response.data);
  }

  getAllGridstationsInProximityOfCoordinate(coordinate, distance) {
    return instance
      .post(`gridstation/proximity/${distance}`, coordinate)
      .then(response => {
        return response.data;
      });
  }

  addGridstation(gridstation) {
    return instance
      .post(`gridstation`, gridstation)
      .then(response => response.data);
  }

  updateGridstation(gridstation) {
    return instance
      .put(`gridstation/${gridstation.id}`, gridstation)
      .then(response => response.data);
  }
}
export default new GridStationService();
