function ListMovies ({ movies }) {
  return (
    <div className='Movies-container'>
      {
        movies.map(movie => (

          <li key={movie.id} className='item'>
            <h3>{movie.title}</h3>
            <p>{movie.year}</p>
            <img src={movie.poster} alt={movie.title} />

          </li>
        ))
      }
    </div>
  )
}

function Nomovies () {
  return (
    <h2> No hay resultados </h2>
  )
}

export function Movies ({ movies }) {
  const hasmovies = movies?.length > 0

  return (
    hasmovies
      ? <ListMovies movies={movies} />
      : <Nomovies />
  )
}
