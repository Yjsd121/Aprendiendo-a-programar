import { useEffect, useState } from 'react'
import './App.css'

function App() {
  const [active, setactive] = useState(false)
  const [position, setposition] = useState({ X: 0, Y: 0 })


  useEffect(() => {
    function mausemove(event) {
      const { clientX, clientY } = event

      setposition({ X: clientX, Y: clientY })
      // console.log(clientY, clientY)
    }

    if (active) {
      window.addEventListener('pointermove', mausemove)
    } else {
      window.removeEventListener('pointermove', mausemove)
    }


    //esta fucion solo se ejecuta cuado el componenete se desmonta
    //tambien solo se ejecura cuando el componente se vuelve a rederizar
    // y cuadno se inicializa el componente 
    return () => {
      window.removeEventListener('pointermove', mausemove)
    }
  }, [active])

  function activated() {
    setactive(!active)
  }


  return (
    <main>
      <h1>Mouse-Follower</h1>

      <div style={
        {
          position: 'absolute',
          backgroundColor: 'rgba(0, 0, 0, 0.5)',
          border: '1px solid #fff',
          borderRadius: '50%',
          opacity: 0.8,
          pointerEvents: 'none',
          left: -25,
          top: -25,
          width: 50,
          height: 50,
          transform: `translate(${position.X}px, ${position.Y}px)`
        }
      }>

      </div>
      <button onClick={activated}>
        Aim pointer {active == false ? "Active" : "Inactive"}
      </button>
    </main>
  )
}

export default App
