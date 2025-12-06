
export const Square = ({ children, updateboard, index, isselected }) => {
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