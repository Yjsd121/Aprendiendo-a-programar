import withmovies from '../mocks/with-result.json'

export function useMovies () {
  const movies = withmovies.Search

  const mappedmovies = movies?.map(movie => ({
    id: movie.imdbID,
    tittle: movie.Title,
    poster: movie.Poster,
    year: movie.Year
  }))

  return { movies: mappedmovies }
}
