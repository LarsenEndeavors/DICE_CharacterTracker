import React, {useState} from "react";
import {CharacterPresenter} from "../Presenter/CharacterPresenter";

export const CharacterContainer = () => {
    const [characters, setCharacters] = useState([]);

    const addCharacter = (newCharacter) => {
        setCharacters(prevState => [...prevState, newCharacter]);
    }

    return (
        <CharacterPresenter characters={characters} addCharacter={addCharacter}/>
    )
}
