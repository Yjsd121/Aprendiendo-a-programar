import { createContext, useState } from 'react'

// 1. Create Contexto

export const Filterscontext = createContext()

// 2. Provider context

export function FilterProvider ({ children }) {
  const [filters, setFilters] = useState({
    Category: 'all',
    price: 0
  })

  return (
    <Filterscontext.Provider value={{
      filters, setFilters
    }}
    >
      {children}
    </Filterscontext.Provider>
  )
}
