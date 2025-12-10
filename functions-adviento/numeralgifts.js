const arra = ['#hola', '#mundo', 'como', '#estas']

console.log(arra)
const newss = filterGifts(arra)

console.log(newss)

function filterGifts (gifts) {
  const newarr = [...gifts]
  for (let i = 0; i < newarr.length; i++) {
    for (const cararcter of newarr[i]) {
      if (cararcter === '#') {
        newarr.splice(i, 1)
        i--
      }
    }
  }

  return newarr
}
