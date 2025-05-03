using System;

namespace CentroEventos.Aplicacion;

public class ActividadDeportiva
{
    private int _id;
    private string _nombre;
    private int _diasDisponibles;
    private int _cupoMax;

    ActividadDeportiva(int id , string nomb , int dias, int cupo){
            _id = id;
            _nombre = nomb;
            _diasDisponibles= dias; 
            _cupoMax = cupo;  //para las incripciones <= cupo max. 
    }
        public bool HayLugar(int cantRegistrada) => cantRegistrada < this._cupoMax;
    
    public string toString(){
        string aux="";
        aux+=$"Actividad Deporiva= {_id} \nNombre: {_nombre} \n Dias disponibles {_diasDisponibles} \n Cupo maximo de actividad {_cupoMax}";
        return aux;
    }
    
}
