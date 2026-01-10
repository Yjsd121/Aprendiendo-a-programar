import { useState, useRef, useMemo } from 'react'

export function useMovies ({ Search, sort }) {
  const [resMovies, setresMovies] = useState([])
  const movies = resMovies.Search
  const firstinput = useRef(true)
  const previousSearch = useRef(Search)

  const mappedmovies = movies?.map(movie => ({
    id: movie.imdbID,
    title: movie.Title,
    poster: movie.Poster,
    year: movie.Year
  }))

  const getMovies = useMemo(() => {
    return ({ Search }) => {
      if (Search === previousSearch.current) return

      if (firstinput.current) {
        firstinput.current = Search === ''
      }
      if (Search) {
        previousSearch.current = Search
        fetch(`http://www.omdbapi.com/?apikey=b86e673a&s=${Search}`)
          .then(res => res.json())
          .then(data => setresMovies(data))
      }
    }
  }, [])

  const sortedMovies = useMemo(() => {
    return sort
      ? [...mappedmovies].sort((a, b) => a.title.localeCompare(b.title))
      : mappedmovies
  }, [sort, mappedmovies])

  return { movies: sortedMovies, getMovies }
}
