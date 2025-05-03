using System;

namespace CentroEventos.Aplicacion;

public class ReservarActividadUseCase(IRepositorioReserva repo)
{
    public void Ejecutar(Reserva reserva){
        repo.ReservarActividad(reserva);
    }
}
