
import { useEffect, useState } from "react"
import './app.css'
//const END_POINT_IMG=`https://cataas.com/cat/says/${word}?fontSize=50&fontColor=red&json=true`
const END_POINT_RANDON = 'https://catfact.ninja/fact'


export function App() {

    const [Hecho, setHecho] = useState(null)
    const [Img, setImg] = useState(null)
    const [Estadobtn, setEstadobtn] = useState(false)

    useEffect(() => {
        fetch(END_POINT_RANDON)
            .then(res => (res.json()))
            .then((data) => { setHecho(data.fact) })

    }, [Estadobtn])

    useEffect(() => {
        if(Hecho==null){return}
        const word = Getfirstword(Hecho)

        fetch(`https://cataas.com/cat/says/${word}?fontSize=50&fontColor=red&json=true`)
            .then(res => res.json())
            .then(data => setImg(data.url))
    },[Hecho])

    function Getfirstword(value) {
        const arr = value.split(' ')
        let word = arr[0]
        return word

    }

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