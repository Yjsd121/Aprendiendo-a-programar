import { Bar_barr } from './components/Navegation_Bar/navegation_bar'
import { useState } from "react"
import './App.css'

function App() {
  const [Modal, setmodal] = useState(false)
  async function OpenModal() {
    setmodal(!Modal)
  }

  return (
    <>
      <Bar_barr Open={OpenModal} />
      {Modal && <div className="Modal">
        Hola mundo</div>}
    </>
  )
}

export default App
