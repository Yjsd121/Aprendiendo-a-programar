
const options=[
    [0,1,2],
    [3,4,5],
    [6,7,8],
    [0,3,6],
    [1,4,7],
    [2,5,8],
    [0,4,8],
    [2,4,6],
]


export function Revisar(newboard) {

    const i = 0

    for (let i =0; i < options.length; i++) {
        const [a,b,c] = options[i]
        if (newboard[a] && newboard[a] === newboard[b] && newboard[a] === newboard[c]) {
            return true
        }
    }
    
    for (let i = 0; i < newboard.length; i++) {
        if (newboard[i]) {
            i++
        }
    }
    if (i === 9) {
        return false
    }
    return null
}
