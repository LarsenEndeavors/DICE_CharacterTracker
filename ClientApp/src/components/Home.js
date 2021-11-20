import React, { useState } from 'react';

const Home = () => {
    const [name, setName] = useState("");

    const handleNameChange = ({target}) => {
        setName(target.value);
    }

    return (
        <div>
            <label htmlFor={"name"} />
            <input id={"name"} name={"name"} value={name} type={"text"} onChange={handleNameChange}/>
            <p>{name}</p>
        </div>
    )
}
export default Home;