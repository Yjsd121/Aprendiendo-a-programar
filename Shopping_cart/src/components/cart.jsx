import './cart.css'
import { useId } from 'react'
import { ClearCartIcon, CartIcon } from './Componnets-incons/icon'
export function Cart () {
  const cartCheckboxId = useId()
  return (
    <>
      <label className='cart-button' htmlFor={cartCheckboxId}>
        <CartIcon />
      </label>
      <input id={cartCheckboxId} type='checkbox' hidden />
      <aside className='cart'>
        <ul>
          <li>
            <img
              src='https://cdn.dummyjson.com/product-images/furniture/knoll-saarinen-executive-conference-chair/thumbnail.webp'
              alt='iphone'
            />
            <div>
              <strong>iphone</strong>-$1400
            </div>

            <footer>
              <small>
                Qty:1
              </small>
            </footer>
          </li>
        </ul>
        <button>
          <ClearCartIcon />
        </button>
      </aside>
    </>
  )
}
