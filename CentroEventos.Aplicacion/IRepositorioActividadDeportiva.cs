using System;

namespace CentroEventos.Aplicacion;

public interface IRepositorioActividadDeportiva
{
    List<ActividadDeportiva> ListarActividadesConCupoDisponible();
}
