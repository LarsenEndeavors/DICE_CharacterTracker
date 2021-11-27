import React, {useState} from "react";

export const CharacterPresenter = (props) => {
    const [newCharacterName, setNewCharacterName] = useState("");
    const handleNameChange = ({target}) => {
        setNewCharacterName(target.value);
    }
    
    const [showNewCharacter, setShowNewCharacter] = useState(false);
    const showNewCharacterName = () => {
        setShowNewCharacter(prevState => !prevState);
    }
    
    const addCharacter = () => {
        let newCharacter = newCharacterName;
        setNewCharacterName("");
        setShowNewCharacter(false);
        props.addCharacter({name: newCharacter, id: crypto.randomUUID()});
    }
    
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
            {props.characters.map((character) => {
                return (
                    <>
                        <p>Name: {character.name}</p>
                        <p>Id: {character.id}</p>
                    </>
                );
            })}
        </div>
    )
} 