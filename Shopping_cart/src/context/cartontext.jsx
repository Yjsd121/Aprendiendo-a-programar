import { createContext, useEffect, useState } from 'react'

export const Cartcontext = createContext()

export function CartProvider ({ children }) {
  const [cart, setcart] = useState(() => {
    const storedcard = localStorage.getItem('cart')
    return storedcard ? JSON.parse(storedcard) : []
  })

  useEffect(() => {
    localStorage.setItem('cart', JSON.stringify(cart))
  }, [cart])

  const addcart = product => {
    const productincart = cart.findIndex(item => item.id === product.id)
    console.log(productincart)

    if (productincart >= 0) {
      const newcart = structuredClone(cart)
      newcart[productincart].quantity += 1
      return setcart(newcart)
    }

    setcart(prevState => ([
      ...prevState,
      {
        ...product,
        quantity: 1
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
