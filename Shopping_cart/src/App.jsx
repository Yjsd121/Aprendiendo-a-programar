import { products } from './Mocks/products.json'
import './App.css'
import { ShowProducts } from './components/Products'

export function App () {
  return (
    <main className='Main-container'>
      <section>
        <div className='Search-container'>
          <input type='text' />
          <button> Search </button>
        </div>
      </section>
      <ShowProducts products={products} />
    </main>
  )
}
