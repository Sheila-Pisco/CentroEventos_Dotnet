using System;
using System.Net.Cache;

namespace CentroEventos.Aplicacion;

public class ListarReservasActivasUseCase(IRepositorioReserva repo)
{
    public List<Reserva> Ejecutar()
    {
        return repo.ListarReservasActivas();
    }
}
