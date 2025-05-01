using System;

namespace CentroEventos.Aplicacion;

public class ActividadDeportiva
{
    private int _id;
    private string _nombre;
    private int _diasDispomibles;
    private int _cupoMax;

    ActividadDeportiva(int id , string nomb , int dias, int cupo){
            _id = id;
            _nombre = nomb;
            _diasDispomibles= dias; 
            _cupoMax = cupo;  //para las incripciones <= cupo max. 
    }
    
}
