using System;

namespace CentroEventos.Aplicacion;

public class Estudiante : Persona
{
    private int _numAlumno;
    private string _carrera;
    public Estudiante(int numalum, int carre, int id, int carnet, string nom, string ape, string direc, string facu, int tel, string uncorreo) : base(id, carnet,nom,ape,direc,facu,tel,uncorreo)
    {
        this._numAlumno = numalum;
        this._carrera = carre;
    }
    public string toString(){
        string aux="";
        aux+=$" {base.toString()} \nNumero Alumno: {_numAlumno} /nCarrera: {_carrera}";
        return aux;
    }
}
