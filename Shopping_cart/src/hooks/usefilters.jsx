import { useContext } from 'react'
import { Filterscontext } from '../context/Filters'

export function useFilters () {
  const { filters, setFilters } = useContext(Filterscontext)

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
  return { filters, Filter, setFilters }
}
