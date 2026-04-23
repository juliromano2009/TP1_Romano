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
        this.DNI = dni;
        this.Nombre = nombre;
        this.FechaNacimiento = fechaNacimiento;
        this.Foto = foto;
        this.Familiares = familiares;
        this.Intereses = intereses;
    }

    public int getDNI()
    {
        return this.DNI;
    }

    public string getNombre()
    {
        return this.Nombre;
    }

    public DateTime getFechaNacimiento()
    {
        return this.FechaNacimiento;
    }

    public string getFoto()
    {
        return this.Foto;
    }

    public List<string> getFamiliares()
    {
        return this.Familiares;
    }

    public List<string> getIntereses()
    {
        return this.Intereses;
    }

    public int getEdad()
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - this.FechaNacimiento.Year;

        if (fechaActual.Month < this.FechaNacimiento.Month || (fechaActual.Month == this.FechaNacimiento.Month && fechaActual.Day < this.FechaNacimiento.Day))
        {
            edad--;
        }

        return edad;
    }

}

    