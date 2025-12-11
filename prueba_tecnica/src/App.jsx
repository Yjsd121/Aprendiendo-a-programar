
import { useEffect, useState } from "react"
import './app.css'
import { randon } from "./service/randon_service"
//const END_POINT_IMG=`https://cataas.com/cat/says/${word}?fontSize=50&fontColor=red&json=true`



export function App() {

    const [Hecho, setHecho] = useState(null)
    const [Img, setImg] = useState(null)
    const [Estadobtn, setEstadobtn] = useState(false)

    useEffect(() => {
        async function fetchRandon() {
            const fact=await randon()
            setHecho(fact)
        }
        fetchRandon()
    }, [Estadobtn])

    useEffect(() => {
        if (Hecho == null) { return }
        const word = Hecho.split(' ', 1)

        fetch(`https://cataas.com/cat/says/${word}?fontSize=50&fontColor=red&json=true`)
            .then(res => res.json())
            .then(data => setImg(data.url))
    }, [Hecho])


    function SearchFact() {
        setEstadobtn(!Estadobtn)
    }
    return (
        <main>
            <h1>App de gatos miau miau</h1>

            <button onClick={SearchFact}>
                Randon
            </button>
            <div className="Information">
                {Hecho && <p>{Hecho}</p>}
                {Img && <img src={Img} alt="Image estracted by Api"></img>}
            </div>

        </main>

    )
}