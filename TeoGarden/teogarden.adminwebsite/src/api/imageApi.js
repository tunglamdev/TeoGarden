import API from "./API.File";

const imageApi = {
  Upload: (content, folder) => {
    return API.post(`/Images/${folder}`,content);
  },
  Delete: (folder, fileName) => {
    return API.delete(`/Images/${folder}/${fileName}`);
  }
}

export default imageApi;