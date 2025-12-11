import './Reservation_Modal.css'


export function Reservation() {
    return (
        <section className="Modal">
            <div className="Information-Rev" >
                <h1>Rerservations</h1>
                <div className='Data'>
                    <div className='item'>
                        <label>Name</label>
                        <input type="text" />
                    </div>
                    <div className='item'>
                        <label>Rooms</label>
                        <select>
                            <option>Selec</option>
                        </select>
                        
                    </div>
                    <div className='item'>
                        <label>Name</label>
                        <input type="text" />
                    </div>

                </div>

            </div>

        </section>
    )
}