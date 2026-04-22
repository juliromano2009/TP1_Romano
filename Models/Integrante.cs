using System;
using System.Collections.Generic;

namespace inicio.Models;

public class Integrante
{
    private int DNI ; 
    private string Nombre ;
    private DateTime FechaNacimiento ;
    private string Foto ;
    private List<string> Familiares = new List<string>();
    private List<string> Intereses = new List<string>();

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        DNI = dni;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Foto = foto;
        Familiares = familiares ?? new List<string>();
        Intereses = intereses ?? new List<string>();
    }

    public int getDNI()
    {
        return DNI;
    }

    public string getNombre()
    {
        return Nombre;
    }
}

    