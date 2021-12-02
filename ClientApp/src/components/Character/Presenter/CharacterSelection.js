import React from "react";

export const CharacterSelection = (props) => {
    return (
        <>
            <p>Name: {props.character.name}</p>
            <p>Id: {props.character.id}</p>
            {/*{props.character.characterSheets.map(characterSheet => {
                return (
                    <button>Edit {characterSheet.name}</button>
                )
            })}*/}
        </>
    )
}

export default CharacterSelection;