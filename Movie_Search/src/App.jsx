import './App.css'
import { useCallback, useRef, useState } from 'react'
import { useMovies } from './Components/usemovies.js'
import { Movies } from './Components/Movies'
import debounce from 'just-debounce-it'
// import wihtoutmovies from './mocks/without-result.json'

export function App () {
  const [sort, setSort] = useState(false)
  const inputRef = useRef()
  const [Search, SetSearch] = useState('')
  const { movies, getMovies } = useMovies({ Search, sort })

  const debounceMovies = useCallback(debounce(Search => {
    console.log(Search)
    getMovies({ Search })
  }, 300), [])

  function Getmovies (e) {
    e.preventDefault()
    getMovies({ Search })
  }
  function handleSort () {
    setSort(!sort)
  }
  function SetSearchs (e) {
    const Valor = e.target.value
    if (Valor.startsWith(' ')) return
    SetSearch(Valor)
    debounceMovies(Valor)
  }

  return (
    <div className='main'>
      <header>
        <label>Search movies</label>
        <form className='search' onSubmit={Getmovies}>
          <input onChange={SetSearchs} value={Search} ref={inputRef} placeholder='How to take your Dragon...' />
          <input type='CheckBox' onChange={handleSort} checked={sort} />
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
