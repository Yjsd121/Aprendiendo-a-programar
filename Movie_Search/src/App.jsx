import './App.css'
import withmovies from './mocks/with-result.json'
import { Movies } from './Components/Movies'
// import wihtoutmovies from './mocks/without-result.json'

export function App () {
  // const API_KEY = process.env.APIKEY
  // const url = `https://www.omdbapi.com/?apikey=${API_KEY}&S=avengers`

  const movies = withmovies.Search
  const ExistMovies = Movies?.length > 0
  return (
    <div className='main'>
      <header>
        <label>Search movies</label>
        <form className='search'>
          <input placeholder='How to take your Dragon...' />
          <button type='submit'>
            Search
          </button>
        </form>
      </header>

      <main className='Ress'>
        <Movies movies={movies} hasmovies={ExistMovies} />
      </main>
    </div>

  )
}
