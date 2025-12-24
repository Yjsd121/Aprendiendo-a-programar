import './App.css'
import { useRef, useState } from 'react'
import { useMovies } from './Components/usemovies'
import { Movies } from './Components/Movies'

// import wihtoutmovies from './mocks/without-result.json'

export function App () {
  // const API_KEY = process.env.APIKEY
  // const url = `https://www.omdbapi.com/?apikey=${API_KEY}&S=avengers`

  const { movies } = useMovies()
  const inputRef = useRef()
  const [Search, SetSearch] = useState('')
  const firstinput = useRef(true)

  function Getmovies (e) {
    e.preventDefault()
    const value = inputRef.current.value
    console.log(value)
  }
  function SetSearchs (e) {
    console.log(firstinput)
    const Valor = e.target.value
    if (firstinput.current) {
      firstinput.current = Valor === ''
    }
    if (Valor.startsWith(' ')) return
    SetSearch(Valor)
    console.log(Valor)
  }

  return (
    <div className='main'>
      <header>
        <label>Search movies</label>
        <form className='search' onSubmit={Getmovies}>
          <input onChange={SetSearchs} value={Search} ref={inputRef} placeholder='How to take your Dragon...' />
          <button type='submit'>
            Search
          </button>
        </form>
      </header>

      <main className='Ress'>
        <Movies movies={movies} />
      </main>
    </div>

  )
}
