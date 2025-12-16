import "./navegation_bar.css"

import menu from "../../assets/menu.svg"

export function Bar_barr({Open}) {
    
    return (
        <section className="Bar-container">
            <nav className="Bar-nav">
                <div className="items">
                    <a>
                        <img src={menu} alt="" />
                    </a>
                </div>
                <div className="items" >
                    <a onClick={Open}>Reserva</a>
                    <a>Dashboard</a>
                    <a>Cuenta</a>
                </div>
            </nav>

        </section>
    )
}