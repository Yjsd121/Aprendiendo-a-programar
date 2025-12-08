
import { useState } from 'react'
import confetti from "canvas-confetti"
import './App.css'
import { Square } from './Components/Square.jsx'
import { Revisar } from './Functions/Revisart.js'

const turn = {
  X: "X",
  O: "O"
}


function App() {

  const [board, setboard] = useState(() => {
    const boardls = window.localStorage.getItem('board')
    return boardls ? JSON.parse(boardls) : Array(9).fill(null)
  })

  const [turns, actualizar] = useState(() => {
    const turnls = window.localStorage.getItem("turn")
    return turnls ? turnls : turn.X
  })

  const [winner, setwinner] = useState(null)



  const updateboard = (index) => {


    if (board[index]) { return }

    const newboard = [...board]
    newboard[index] = turns
    setboard(newboard)

    const newturn = turns === turn.X ? turn.O : turn.X
    actualizar(newturn)

    window.localStorage.setItem('board', JSON.stringify(newboard))
    window.localStorage.setItem('turn', newturn)
    const check = Revisar(newboard)
    if (check === true) {
      confetti()
    }
    setwinner(check)

  }

  const clear = () => {

    setboard(Array(9).fill(null))
    window.localStorage.removeItem("board")

    actualizar(turn.X)
    window.localStorage.removeItem("turn")  
    setwinner(null)

  }
  return (
    <>
      <main className='board'>
        <h1> TIC TAC TOE </h1>
        <section className='game'>
          {
            board.map((_, index) => {

              return (
                <Square
                  key={index}
                  index={index}
                  updateboard={updateboard}
                >
                  {board[index]}
                </Square>
              )
            })
          }
        </section>

        <section className='turn'>
          <Square isselected={turns === turn.X}>
            {turn.X}
          </Square>
          <Square isselected={turns === turn.O}>
            {turn.O}
          </Square>

        </section>
        <button onClick={clear}>
          Restart
        </button>

        {
          winner != null && (
            <section className='winner'>
              <div className='text'>
                <h2 >
                  {
                    winner == false ? 'Empate' : `El ganador es:`
                  }
                </h2>

                <header className='win'>
                  {winner && <Square>
                    {turns == turn.O ? turn.X : turn.O}
                  </Square>}


                </header>
                <button onClick={clear}>
                  Restart
                </button>
              </div>
            </section>
          )
        }
      </main>
    </>
  )
}

export default App
