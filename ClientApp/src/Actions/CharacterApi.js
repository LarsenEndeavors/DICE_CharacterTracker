import api from "./Api";

export const CHARACTER_ACTION_TYPES = {
    CREATE: 'CREATE',
    UPDATE: 'UPDATE',
    DELETE: 'DELETE',
    FETCH: 'FETCH',
    FETCH_ALL: 'FETCH_ALL',
    FETCH_ALL_FOR_USERID: 'FETCH_ALL_FOR_USERID'
};

export const fetchByUserId = (userId) => dispatch => {
    api.character().fetchByUserId(userId).then(response => {
        dispatch({
            type:CHARACTER_ACTION_TYPES.FETCH_ALL_FOR_USERID,
            payload:response.data
        });
    }).catch(err => alert(JSON.stringify(err, null, 2)));
};