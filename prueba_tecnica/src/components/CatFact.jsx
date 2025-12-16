import { useEffect, useState } from "react"
import { randon } from "../service/randon_service"

export function useCatFacts({ Estadobtn }) {

    const [Hecho, setHecho] = useState(null)

    useEffect(() => {
        async function fetchRandon() {
            const fact = await randon()
            setHecho(fact)

        }
        fetchRandon()
    }, [Estadobtn])

    return Hecho
}