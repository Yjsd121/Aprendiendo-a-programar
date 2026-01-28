import { AddToCartIcon } from './Componnets-incons/icon'

export function ShowProducts ({ products }) {
  return (
    <section className='Products-container'>
      {
        products.slice(0,11).map(product => (
          <li key={product.id}>
            <img src={product.thumbnail} />
            <div>
              <strong>{product.title}</strong> - ${product.price}
            </div>
            <div>
              <AddToCartIcon />
            </div>
          </li>
        ))
      }
    </section>
  )
}
