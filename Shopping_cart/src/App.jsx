import { products } from './Mocks/products.json'
import './App.css'
import { ShowProducts } from './components/Products'
import { useState } from 'react'

export function App () {
  const [Products, setProducts] = useState(products)
  const [filters, setFilters] = useState({
    Category: 'all',
    price: 0
  })
  function Filter (Products) {
    return (
      Products.filter(products => {
        return (
          products.price >= filters.price && (
            filters.Category === 'all' || products.category === filters.Category
          )
        )
      })
    )
  }
  return (
    <main className='Main-container'>
      <section>
        <div className='Search-container'>
          <input type='text' />
          <button> Search </button>
        </div>
      </section>
      <ShowProducts products={Filter(Products)} />
    </main>
  )
}
