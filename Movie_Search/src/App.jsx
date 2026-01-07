import './App.css'
import { useRef, useState } from 'react'
import { useMovies } from './Components/usemovies.js'
import { Movies } from './Components/Movies'
// import wihtoutmovies from './mocks/without-result.json'

export function App () {
  const inputRef = useRef()
  const firstinput = useRef(true)
  const [Search, SetSearch] = useState('')
  const { movies, getMovies } = useMovies({ Search })

  function Getmovies (e) {
    e.preventDefault()
    getMovies()
  }

  function SetSearchs (e) {
    const Valor = e.target.value
    if (firstinput.current) {
      firstinput.current = Valor === ''
    }
    if (Search === e.target.value) return
    if (Valor.startsWith(' ')) return

    SetSearch(Valor)
    getMovies()
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
