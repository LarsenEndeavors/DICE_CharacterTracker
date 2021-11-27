import axios from "axios";

const baseUrl = "https://localhost:5001/api/"

export default {
    character(url = baseUrl + "Character/") {
        return {
            fetchByUserId: (id) => axios.get(url + "user/" + id)
        }
    }
}