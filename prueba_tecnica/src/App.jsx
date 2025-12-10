
import { useEffect, useState } from "react"
// let word = "Hello"
// const END_POINT_IMG=`https://cataas.com/cat/says/${word}?fontSize=50&fontColor=red&json=true`
const END_POINT_RANDON = 'https://catfact.ninja/fact'


export function App() {
    const [Hecho, setHecho] = useState("Lorem ipsum cat fact whatever ")
    const [Estadobtn, setEstadobtn] = useState(false)
    useEffect(() => {
        fetch(END_POINT_RANDON)
            .then(res => (res.json()))
            .then(data => setHecho(data.fact))

    }, [Estadobtn])

    function SearchFact() {
        setEstadobtn(!Estadobtn)
    }
    return (
        <>
            <h1>App de gatos miau miau</h1>

            <button onClick={SearchFact}>
                Press to Search
            </button>

            <p>{Hecho}</p>
        </>

    )
}