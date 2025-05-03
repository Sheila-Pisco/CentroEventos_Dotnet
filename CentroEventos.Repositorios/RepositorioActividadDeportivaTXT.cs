using System;
using CentroEventos.Aplicacion;

namespace CentroEventos.Repositorios;

public class RepositorioActividadDeportivaTXT: IRepositorioActividadDeportiva
{
    readonly string _nombreArchivo = "reservas.txt";
    public List<ActividadDeportiva> ListarActividadesConCupoDisponible(){
        
        var lista = new List<ActividadDeportiva>();

        //definir el cuerpo del método

        return lista;
    }
}
