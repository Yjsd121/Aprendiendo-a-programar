
import { useState } from "react"
import './app.css'
import { useCatFacts } from "./components/CatFact"
import { useCatimg } from "./components/CatImg"


export function App() {

    const [Estadobtn, setEstadobtn] = useState(false)

    const Hecho = useCatFacts({ Estadobtn })
    const Img = useCatimg({ Hecho })


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
                {Hecho && <p data-testid= "fact" >{Hecho}</p>}
                {Img && <img data-testid= "fact-img" src={Img} alt="Image estracted by Api"></img>}
            </div>

        </main>

    )
}