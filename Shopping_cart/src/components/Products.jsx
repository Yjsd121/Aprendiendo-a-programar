import { useCart } from '../hooks/usecart'
import { AddToCartIcon, RemoveFromCartIcon } from './Componnets-incons/icon'

export function ShowProducts ({ products }) {
  const { addcart, removecart, cart } = useCart()
  const checkproduct = product => {
    return cart.some(item => item.id === product.id)
  }

  return (
    <section className='Products-container'>
      {
        products.map(product => {
          const IsinCart = checkproduct(product)

          return (
            <li key={product.id}>
              <img src={product.thumbnail} />
              <div>
                <strong>{product.title}</strong> - ${product.price}
              </div>
              <div>
                <button onClick={() => {
                  IsinCart
                    ? removecart(product)
                    : addcart(product)
                }}
                >
                  {
                    IsinCart
                      ? <RemoveFromCartIcon />
                      : <AddToCartIcon />
                  }
                </button>
              </div>
            </li>
          )
        })
      }
    </section>
  )
}
