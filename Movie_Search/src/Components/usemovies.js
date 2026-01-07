import { useState } from 'react'
// import withmovies from '../mocks/with-result.json'
import withoutMovies from '../mocks/without-result.json'

export function useMovies ({ Search }) {
  const [resMovies, setresMovies] = useState([])
  const movies = resMovies.Search

  const mappedmovies = movies?.map(movie => ({
    id: movie.imdbID,
    title: movie.Title,
    poster: movie.Poster,
    year: movie.Year
  }))

  const getMovies = () => {
    if (Search) {
      fetch(`http://www.omdbapi.com/?apikey=b86e673a&s=${Search}`)
        .then(res => res.json())
        .then(data => setresMovies(data))
    } else {
      setresMovies(withoutMovies)
    }
  }
  return { movies: mappedmovies, getMovies }
}
