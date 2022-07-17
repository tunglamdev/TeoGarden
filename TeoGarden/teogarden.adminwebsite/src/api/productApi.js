import API from "./API";

const productApi = {
  GetAll: () => {
    return API.get("/Vegetables");
  },
  GetById: (id) => {
    return API.get(`/Vegetables/${id}`);
  },
  Update: (request) => {
    return API.put("/Vegetables",request);
  },
  Create: (request) => {
    return API.post("/Vegetables", request);
  },
  Delete: (id) => {
    return API.delete(`/Vegetables/${id}`);
  }
}

export default productApi;