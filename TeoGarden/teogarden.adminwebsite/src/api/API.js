import axios from "axios";

const API = axios.create({
    baseURL: process.env.REACT_APP_API_URL,
    timeout: 300000,
    headers: {
        "content-type": "application/json"
    },
    refreshHeader: () =>{
        API.interceptors.request.use(async (config) => {
            var newConfig = {};
            newConfig = {
              ...config,
              headers: {
                "content-type": "application/json"
              },
            };
            return newConfig;
        });
    }
});

API.interceptors.response.use(
(response) => {
    if (response && response.data) {
    return response.data;
    }
},
(error) => {
    console.error(error);
}
);

export default API;
