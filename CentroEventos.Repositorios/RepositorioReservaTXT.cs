using System;

namespace CentroEventos.Repositorios;
using CentroEventos.Aplicacion;

public class RepositorioReservaTXT: IRepositorioReserva
{
    readonly string _nombreArchivo = "reservas.txt";
    public void ReservarActividad(Reserva reserva)
    {
        //agregar validaciones para poder reservar

        /*
        using var sw = new StreamWriter(_nombreArchivo, true);
        sw.WriteLine(reserva.IdPersona);
        sw.WriteLine(reserva.IdActividadDeportiva);
        sw.WriteLine(reserva.FechaDeReserva);
        sw.WriteLine(reserva.EstadoDeAsistencia); 
        */
    }
    public List<Reserva> ListarReservasActivas()
    {
        var lista = new List<Reserva>();

        //definir el cuerpo del método

        return lista; 
    }
}
