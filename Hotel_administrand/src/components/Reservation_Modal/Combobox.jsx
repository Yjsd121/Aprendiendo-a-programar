import { useEffect, useState } from "react";

export function Option() {
    const [options, setoption] = useState([])


    useEffect(() => {

        //Extraer desde una base de datos con las habitaciones 
        const datos = [
            { id: 1, nombre: "Habitación individual" },
            { id: 2, nombre: "Opción 2" },
            { id: 3, nombre: "Opción 3" }
        ];

        setoption(datos);
    }, [])


    return (
        <select>
            <option value="">Seleccione una opción</option>
            {options.map(op => (
                <option key={op.id} value={op.id}>
                    {op.nombre}
                </option>
            ))}
        </select>
    )

}

