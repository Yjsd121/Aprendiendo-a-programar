import { products } from './Mocks/products.json'
import './App.css'
import { ShowProducts } from './components/Products'
import { useState } from 'react'
import { Header } from './components/Header'
import { useFilters } from './hooks/usefilters'
import { Footer } from './components/Footer'

export function App() {
  const [Products] = useState(products)
  const { filters, Filter, setFilters } = useFilters()
  const filtersproducts = Filter(Products)

  return (
    <main className='Main-container'>
      {/* <section>
        {<div className='Search-container'>
          <input type='text' />
          <button> Search </button>
        </div>}
      </section> */}
      <Header setFilters={setFilters} />
      <ShowProducts products={Filter(filtersproducts)} />
      <Footer filters={filters} />
    </main>
  )
}
