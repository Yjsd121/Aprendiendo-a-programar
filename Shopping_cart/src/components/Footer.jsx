import './Footer.css'
// import { useFilters } from '../hooks/usefilters'
import { useCart } from '../hooks/usecart'
export function Footer () {
  // const { filters } = useFilters()
  const { cart } = useCart()
  return (
    <footer className='footer'>
      {
        JSON.stringify(cart, null, 2)
      }
    </footer>
  )
}
