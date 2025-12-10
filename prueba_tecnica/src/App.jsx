
import { useEffect, useState } from "react"

export function App() {

    const [Hecho, setHecho] = useState("Lorem ipsum cat fact whatever ")

    useEffect(() => {
        const url = 'https://catfact.ninja/fact'
        fetch(url)
            .then(res => {
                res.json()

            })
            .then(data => (setHecho(data.fact)))

    }, [])
    function SearchFact() {

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