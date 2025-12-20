function ListMovies ({ movies }) {
  return (
    <ul>
      {
        movies.map(movie => (
          <li key={movie.imdbID} className='item'>
            <h3>{movie.Title}</h3>
            <p>{movie.Year}</p>
            <img src={movie.Poster} alt={movie.Title} />

          </li>
        ))
      }
    </ul>
  )
}

function Nomovies () {
  return (
    <h2> No hay resultados </h2>
  )
}

export function Movies ({ movies, hasmovies }) {
  return (
    hasmovies
      ? <ListMovies movies={movies} />
      : <Nomovies />
  )
}
