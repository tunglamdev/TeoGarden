import API from "./API";

const categoryApi = {
  GetAll: () => {
    return API.get("/Categories");
  },
  GetById: (id) => {
    return API.get(`/Categories/${id}`);
  },
  Create: (request) => {
    return API.post("/Categories",request);
  },
  Update: (request) => {
    return API.put("/Categories",request);
  },
  Delete: (id) => {
    return API.delete(`/Categories/${id}`);
  }
}

export default categoryApi;