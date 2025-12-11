const END_POINT_RANDON = 'https://catfact.ninja/fact'

export const randon = async () => {
    const res = await fetch(END_POINT_RANDON)
    const data = await res.json()
    const fact = await data.fact
    return fact
    
}