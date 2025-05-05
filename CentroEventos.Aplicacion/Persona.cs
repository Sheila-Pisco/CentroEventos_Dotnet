
using System;

namespace CentroEventos.Aplicacion;

public class Persona
{
    private int _id;
    private int _numCarnet;
    private string _nombre;
    private string _apellido;
    private string _direccion;
    private string _facultad;
    private int _telefono;
    private string _correo;
    public Persona(int id)
    {
        _id = id;
    }


    public Persona(int id, int carnet, string nom, string ape, string direc, string facu, int tel, string uncorreo)
    {
        _id = id;
        _numCarnet = carnet;
        _nombre = nom;
        _apellido = ape;
        _direccion = direc;
        _facultad = facu;
        _telefono = tel;
        _correo = uncorreo;
    }

    public string toString(){
        string aux="";
        aux+=$"ID: {_id} \n Nombre: {_nombre} \nApellido: {_apellido} \nDireccion: {_direccion} \nFacultad: {_facultad} \nTelefono: {_telefono} \nCorreo: {_correo}";
        return aux;
    }
}