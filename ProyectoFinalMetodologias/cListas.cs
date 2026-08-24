using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProyectoFinalMetodologias
{
    internal class cListas
    {
        public List<cLogicaRegistros> listaReservaciones;
        public List<cModeloHabitaciones> listaHabitaciones;

        //Constructor
        public cListas()
        {
            listaReservaciones = new List<cLogicaRegistros>();
            listaHabitaciones = new List<cModeloHabitaciones>
            {
                new cModeloHabitaciones { NumeroHabitacion = 101, TipoHabitacion = "Estandar", Estado = "Libre", TarifaPorNoche = 800 },
                new cModeloHabitaciones { NumeroHabitacion = 102, TipoHabitacion = "Suite", Estado = "Libre", TarifaPorNoche = 1500 },
                new cModeloHabitaciones { NumeroHabitacion = 103, TipoHabitacion = "Doble", Estado = "Libre", TarifaPorNoche = 1200 }
            };
        }

        public void RegistrarReservacion(cLogicaRegistros reservacion)
        {
            var habitacion = listaHabitaciones.FirstOrDefault(h => h.NumeroHabitacion == reservacion.NumHabitacion);

            if (habitacion != null)
            {
                //Cambiar estado a "Ocupada"
                habitacion.Estado = "Ocupada";
                //Guardar
                listaReservaciones.Add(reservacion);
            }
        }

    }
}
