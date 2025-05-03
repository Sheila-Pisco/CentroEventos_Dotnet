using System;

namespace CentroEventos.Aplicacion;

public class ListarActividadesConCupoDisponibleUseCase(IRepositorioActividadDeportiva repo)
{
    public List<ActividadDeportiva> Ejecutar()
    {
        return repo.ListarActividadesConCupoDisponible();
    }
}
