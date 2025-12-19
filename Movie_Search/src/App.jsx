import './app.css'

export function App () {
  return (
    <div className='main'>
      <header>
        <label>Search movies</label>
        <form className='search' method='get'>
          <input placeholder='How to take your Dragon...' />
          <button type='submit'>
            Search
          </button>
        </form>
      </header>

      <main>
        Aqui se vera el resultado de la busqueda
      </main>
    </div>

  )
}
