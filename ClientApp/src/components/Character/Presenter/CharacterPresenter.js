import React, {useEffect, useState} from "react";
import CharacterSelection from "./CharacterSelection";

export const CharacterPresenter = (props) => {
    const [newCharacterName, setNewCharacterName] = useState("");
    const [characters, setCharacters] = useState([]);
    
    const handleNameChange = ({target}) => {
        setNewCharacterName(target.value);
    }
    
    const [showNewCharacter, setShowNewCharacter] = useState(false);
    const showNewCharacterName = () => {
        setShowNewCharacter(prevState => !prevState);
    }
    
    const addCharacter = (newCharacterName) => {
        setNewCharacterName("");
        setShowNewCharacter(false);
        let additionalCharacter = {name: newCharacterName, id: crypto.randomUUID(), characterSheets: []};
        setCharacters([...characters, additionalCharacter]);
    }
    
    const fetchCharacters = async () => {
        const response = await fetch("/api/Character/user/f5f3fc04-3389-4911-8550-e9014a185127");
        const data = await response.json();
        console.log(data);
        setCharacters(data);
    }
    
    useEffect(() => {
        fetchCharacters();
    }, [])
    
    return (
        <div>
            {!showNewCharacter &&
            <button id={"newCharacterButton"} value={"+ New Character"} onClick={showNewCharacterName}>+ New
                Character</button>}
            {showNewCharacter && (
                <>
                    <input id={"name"} name={"name"} value={newCharacterName} type={"text"} onChange={handleNameChange}/>
                    <button id={"addCharacterButton"} value={"Add Character"} onClick={addCharacter}>Add Character
                    </button>
                </>
            )}
            {characters.map((character) => {
                return (
                    <CharacterSelection character={character}/>
                );
            })}
        </div>
    )
} 