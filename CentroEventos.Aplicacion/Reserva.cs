using System;

namespace CentroEventos.Aplicacion;

public class Reserva
{
    private int _id;
    private Persona _persona1;
    private ActividadDeportiva _actividad;
    private int _fechaReserva;
    private Asistencias Asistencia; /// deberia ser un enum. 

    Reservas(int id, Persona per, ActividadDeportiva act, int fecha, Asistencias asis){
        _id=id;
        _persona1= per;
        _actividad=act;
        _fechaReserva = fecha;
        Asistencia = asis;
    }
        public string toString(){
        string aux="";
        aux+= $"Reserva = {_id} Reservado por: {_persona1} Actividad a realizar: {_actividad} el dia: {_fechaReserva}";
        return aux;
    }

}
