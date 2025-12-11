import { useState } from "react"
import { Bar_barr } from './components/Navegation_Bar/navegation_bar'
import { Reservation } from "./components/Reservation_Modal/Reservation_modal"

import './App.css'


function App() {
  const [Modal, setmodal] = useState(false)
  async function OpenModal() {
    setmodal(!Modal)
  }

  
  return (
    <>
      <Bar_barr Open={OpenModal} />
      {Modal && <Reservation />}

      <section className="Dashboard-containers">
        <h1>Dashboard</h1>

        <div className="Numbers">
            <label>
              Rooms-Free
            </label>
            <label>
              Rooms-no-free
            </label>
            <label>
              guests
            </label>
        </div>
      </section>
    </>
  )
}

export default App
