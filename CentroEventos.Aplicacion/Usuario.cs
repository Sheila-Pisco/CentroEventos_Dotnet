using System;

namespace CentroEventos.Aplicacion;

public class Usuario
{   
    private string _email;
    private string _contrasenia;
    private string _nombreUsuario;
    private string Permisos; //crear una clase con Permisos o validaciones. 

    Usuario(string mail, string contr, string nomb, string per){
        _email = mail;
        _contrasenia = contr;
        _nombreUsuario = nomb;
        Permisos = per;
    }
    

}
