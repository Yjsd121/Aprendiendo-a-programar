import { useContext } from 'react'
import { Cartcontext } from '../context/cartontext'

export const useCart = () => {
  const Cart = useContext(Cartcontext)

  if (Cart === undefined) {
    throw new Error('Cartcontext is used within provider')
  }

  return Cart
}
