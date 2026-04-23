using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using inicio.Models;

namespace inicio.Models;

public class Grupo 
{

    private Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();

    public Grupo ()
    {
        CargaDeGrupos();
    }

    private void CargaDeGrupos () 
    {
        Integrante integrante = new Integrante(5028909,"Jazmin Han" , new DateTime(2010 , 3 , 26) , "https://img.freepik.com/vector-gratis/mujer-joven-pelo-largo-lindo-icono-aislado_24911-100824.jpg?semt=ais_hybrid&w=740&q=80" , new List<string> {"Mamá: Esperanza", "Papá: Kwang Ho"}, new List<string> {"Padel", "Cantar"});
        Integrante integrante2 =  new Integrante(49703405 , "Julieta Romano" , new DateTime(2009 , 9 , 5), "https://i.pinimg.com/474x/11/ba/8e/11ba8e7221b00e7ac6d58be03b06b2c3.jpg" , new List<string> {"Mamá: Valeria", "Papá: Pablo"}, new List<string> {"Voley", "Instagram"});
        AgregarIntegrante(integrante);
        AgregarIntegrante(integrante2);
    }

    private void AgregarIntegrante (Integrante integrante) 
    {
        integrantes.Add(integrante.getDNI(), integrante);
    }   

    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return integrantes;
    }

    public Integrante GetIntegrante(int dni)
    {
        Integrante integrante;
        if (integrantes.ContainsKey(dni))
        {
            integrante = integrantes[dni];
        }
        else
        {
            integrante = null;
        }
        return integrante;
    }

}