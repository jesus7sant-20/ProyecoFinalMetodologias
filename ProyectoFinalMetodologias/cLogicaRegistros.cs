using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalMetodologias
{
    internal class cLogicaRegistros
    {
        //variables para el registro del reservaciones
        //Datos del cliente
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }

        //Datos de la Habitacion
        public string TipoHabitacion { get; set; }
        public int NumHabitacion { get; set; }
        public string EstadoHabitacion { get; set; }

        //Fechas
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int NumeroNoches { get; set; }

        //Opciones Adicionales
        public string MetodoPago { get; set; }
        public decimal MontoTotal { get; set; }
        public string EstadoPago { get; set; }
        public string Solicitudesespeciales { get; set; }
        public string NOtasHuesped { get; set; }
    }
}
