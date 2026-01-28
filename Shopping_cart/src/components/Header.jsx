import { Filters } from './filters'

export function Header ({ setFilters }) {
  return (
    <>
      <h1> Shopping Car </h1>
      <Filters setfilters={setFilters} />
    </>
  )
}
