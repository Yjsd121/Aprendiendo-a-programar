import { useState, useId } from 'react'
import './filters.css'

export function Filters ({ setfilters }) {
  const [price, setprice] = useState(0)

  const PriceIDhook = useId()
  const CategoryIdhook = useId()

  const handlePriceFilter = (e) => {
    setprice(e.target.value)
    setfilters(prevState => ({
      ...prevState, price: e.target.value
    }))
  }
  const handlecategoryfilter = (e) => {
    setfilters(prevState => ({
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
          onChange={handlePriceFilter}
        />
        <span> ${price}</span>
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
