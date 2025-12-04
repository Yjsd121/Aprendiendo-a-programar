
import { useState } from 'react'
import confetti from "canvas-confetti"
import './App.css'
const turn = {
  X: "X",
  O: "O"
}


const Square = ({ children, updateboard, index, isselected }) => {
  console.log(isselected)

  const ClasssName = `square ${isselected ? 'is-selected' : ''}`

  const handleClick = () => {
    updateboard(index)

  }

  return (
    <div onClick={handleClick} className={ClasssName}>
      {children}
    </div>
  )
}
function App() {

  const [board, setboard] = useState(Array(9).fill(null))

  const [turns, actualizar] = useState(turn.X)

  const [winner, setwinner] = useState(null)


  function Revisar(newboard) {
    const i = 0
    if (((newboard[0] === newboard[1] && newboard[0] === newboard[2]) || (newboard[0] === newboard[3] && newboard[0] === newboard[6]) || (newboard[0] === newboard[4] && newboard[0] === newboard[8])) && newboard[0] !== null) {
      return true
    }
    else if (newboard[3] === newboard[4] && newboard[3] === newboard[5] && newboard[3] !== null) {
      return true
    }
    else if (newboard[6] === newboard[7] && newboard[6] === newboard[8] && newboard[6] !== null) {
      return true
    }
    else if (newboard[1] === newboard[4] && newboard[1] === newboard[7] && newboard[1] !== null) {
      return true
    }
    else if (((newboard[2] === newboard[5] && newboard[2] === newboard[8] || newboard[2] === newboard[4] && newboard[2] === newboard[6])) && newboard[2] !== null) {
      return true
    }

    for (let i = 0; i < newboard.length; i++) {
      if (newboard[i]) {
        i++
      }
    }
    if (i === 9) {
      return false
    }
    return null
  }

  const updateboard = (index) => {


    if (board[index]) { return }

    const newboard = [...board]
    newboard[index] = turns
    setboard(newboard)

    const newturn = turns === turn.X ? turn.O : turn.X
    actualizar(newturn)

    const check = Revisar(newboard)
    if (check === true) {
      confetti()
    }
    setwinner(check)

  }

  const clear = () => {
    setboard(Array(9).fill(null))
    actualizar(turn.X)
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
                  {winner && <Square>{turns == turn.O ? turn.X : turn.O}</Square>}
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
