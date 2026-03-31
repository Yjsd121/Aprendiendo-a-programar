import './cart.css'
import { useId } from 'react'
import { ClearCartIcon, CartIcon } from './Componnets-incons/icon'
import { useCart } from '../hooks/usecart'
export function Cart () {
  const cartCheckboxId = useId()
  const { addcart, cart, clearcart } = useCart()
  function Cartmap ({ title, thumbnail, price, quantity, addcart }) {
    return (
      <li>
        <img src={thumbnail} />
        <div className='Info'>
          <strong>{title}</strong> - ${price}
        </div>
        <strong>{quantity}</strong>
        <button onClick={addcart}>
          +
        </button>
      </li>
    )
  }

  return (
    <>
      <label className='cart-button' htmlFor={cartCheckboxId}>
        <CartIcon />
      </label>
      <input id={cartCheckboxId} type='checkbox' hidden />
      <aside className='cart'>
        <ul>
          {
            cart.map(product =>
              <Cartmap
                key={product.id}
                addcart={() => addcart(product)}
                {...product}
              />
            )
          }
        </ul>
        <button onClick={() => clearcart()}>
          <ClearCartIcon />
        </button>
      </aside>
    </>
  )
}
