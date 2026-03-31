import { createContext, useState } from 'react'

export const Cartcontext = createContext()

export function CartProvider ({ children }) {
  const [cart, setcart] = useState([])

  const addcart = product => {
    const productincart = cart.findIndex(item => item.id === product.id)

    if (productincart >= 0) {
      const newcart = structuredClone(cart)
      newcart[productincart].quantity += 1
      return setcart(newcart)
    }

    setcart(prevState => ([
      ...prevState,
      {
        ...product,
        quuantity: 1
      }
    ]))
  }
  const removecart = product => {
    setcart(prevStatus => prevStatus.filter(item => item.id !== product.id))
  }
  const clearcart = () => { setcart([]) }

  return (
    <Cartcontext.Provider value={{
      cart,
      clearcart,
      addcart,
      removecart
    }}
    >

      {
        children
      }
    </Cartcontext.Provider>
  )
}
