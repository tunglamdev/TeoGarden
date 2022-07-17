import API from "./API";

const productApi = {
  GetAll: () => {
    return API.get("/Users");
  }
}

export default productApi;