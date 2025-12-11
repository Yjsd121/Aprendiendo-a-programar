import { Option } from './Combobox'
import './Reservation_Modal.css'

export function Reservation() {

    return (
        <section className="Modal">+
            <div className="Information-Rev" >
                <h1>Rerservation</h1>
                <div className='Data'>
                    <div className='item'>
                        <input id="input" required="" type="text" />
                        <label for="input" className='label'>Name</label>

                    </div>
                    <div className='item'>
                        <input type="text" />
                        <label for="input" className='label'>Days</label>

                    </div>
                    <div className='item'>
                        <input type="text" />
                        <label for="input" className='label'>Nigths</label>

                    </div>

                    <div className='item'>
                        <label>Check in</label>
                        <input type="date" />
                    </div>
                    <div className='item'>
                        <label>Check out</label>
                        <input type="date" />
                    </div>
                    <div className='item'>
                        <label>Rooms</label>
                        <Option />

                    </div>


                </div>

                <button className='btn-Reserve'>Reserve</button>
            </div>
        </section>
    )
}