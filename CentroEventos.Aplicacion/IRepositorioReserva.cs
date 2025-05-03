using System;

namespace CentroEventos.Aplicacion;

public interface IRepositorioReserva
{
    void ReservarActividad(Reserva reserva);
    List<Reserva> ListarReservasActivas();
}
