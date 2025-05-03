using System;

namespace CentroEventos.Aplicacion;

public class Usuario
{   
    private string _email;
    private string _contrasenia;
    private string _nombreUsuario;
    private Permisos _permisos; //crear una clase con Permisos o validaciones. 

    Usuario(string mail, string contr, string nomb, string per){
        _email = mail;
        _contrasenia = contr;
        _nombreUsuario = nomb;
        _permisos = per;
    }
    
    public string toString(){
        string aux="";
        aux+=$"Usuario = {_nombreUsuario} email: {_email}";
        return aux;
    }

}
