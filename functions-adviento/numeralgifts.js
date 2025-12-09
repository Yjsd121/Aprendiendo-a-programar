
let arra = ['#hola', '#mundo', 'como', '#estas']

console.log(arra)
let newss = filterGifts(arra)

console.log(newss)

function filterGifts(gifts) {
    let newarr = [...gifts]
    for (let i = 0; i < newarr.length; i++) {
        for (let cararcter of newarr[i]) {

            if (cararcter == '#') {
                newarr.splice(i, 1)
                i--
            }

        }
    }

    return newarr
}