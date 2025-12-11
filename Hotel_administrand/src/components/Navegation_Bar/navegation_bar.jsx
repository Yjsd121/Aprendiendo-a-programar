import "./navegation_bar.css"


export function Bar_barr({Open}) {
    
    return (
        <section className="Bar-container">
            <nav className="Bar-nav">
                <div className="items">
                    <a>
                        Logo
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