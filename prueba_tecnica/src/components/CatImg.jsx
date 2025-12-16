import { useEffect, useState } from "react";


export function useCatimg({ Hecho }) {
    const [Img, setImg] = useState(null)

    useEffect(() => {
        if (Hecho == null) { return }
        const word = Hecho.split(' ', 2).join(" ")

        fetch(`https://cataas.com/cat/says/${word}?fontSize=50&fontColor=red&json=true`)
            .then(res => res.json())
            .then(data => setImg(data.url))
    }, [Hecho])

    return Img
}