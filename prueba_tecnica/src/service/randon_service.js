const END_POINT_RANDON = 'https://catfact.ninja/fact'

export async function randon(params) {
    const res = await fetch(END_POINT_RANDON)
    const data = await res.json()
    const {fact} = data
    return fact

}