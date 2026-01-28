import { createRoot } from 'react-dom/client'
import { App } from './App'
import { FilterProvider } from './context/Filters.jsx'

const root = createRoot(document.getElementById('app'))
root.render(
  <FilterProvider>
    <App />
  </FilterProvider>
)
