using System;

namespace CentroEventos.Aplicacion;

public class Docente : Persona
{
    private int _matricula;
    private int _anioIngreso;

    public Docente(int matri, int anio, int id, int carnet, string nom, string ape, string direc, string facu, int tel, string uncorreo) : base(id, carnet,nom,ape,direc,facu,tel,uncorreo)
    {
        this._matricula = matri;
        this._anioIngreso = anio;
    }
    public string toString(){
        string aux="";
        aux+=$" {base.toString()} \n Matricula: {_matricula} \nAño Ingreso: {_anioIngreso}";
        return aux;
    }
}