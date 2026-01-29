import { useId } from 'react'
import './filters.css'
import { useFilters } from '../hooks/usefilters'

export function Filters () {
  const { filters, setFilters } = useFilters()
  const PriceIDhook = useId()
  const CategoryIdhook = useId()

  const handlePriceFilter = (e) => {
    setFilters(prevState => ({
      ...prevState, price: e.target.value
    }))
  }
  const handlecategoryfilter = (e) => {
    setFilters(prevState => ({
      ...prevState, Category: e.target.value
    }))
  }
  return (
    <section className='Header'>
      <div>
        <label htmlFor={PriceIDhook}>A partir de : </label>
        <input
          type='range'
          id={PriceIDhook}
          min={0}
          max={2000}
          value={filters.price}
          onChange={handlePriceFilter}
        />
        <span> ${filters.price}</span>
      </div>
      <div>
        <label htmlFor={CategoryIdhook}>Categoria: </label>
        <select id={CategoryIdhook} onChange={handlecategoryfilter}>
          <option value='all'>all</option>
          <option value='fragrances'>fragrances</option>
          <option value='furniture'>furniture</option>
          <option value='groceries'>groceries</option>
          <option value='beauty'>beauty</option>

        </select>
      </div>
    </section>
  )
}
