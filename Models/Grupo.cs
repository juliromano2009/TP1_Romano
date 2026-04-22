using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using inicio.Models;

namespace inicio.Models;

public class Grupo 
{

    private Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();

    public Grupo (Dictionary<int, Integrante> integrantes)
    {
        this.integrantes = integrantes;
    }

    private void CargaDeGrupos () 
    {
        Integrante integrante = (5028909,"Jazmin Han" , new DateTime(2010 , 5 , 12) , "https://st.depositphotos.com/1020341/4414/i/450/depositphotos_44145175-stock-photo-portrait-of-beautiful-young-woman.jpg" , new List<string> {"Mamá: María", "Papá: Juan"}, new List<string> {"Padel", "Tik Tok"});
        Integrante integrante2 =  (49703405 , "Julieta Romano" , new DateTime(2009 , 9 , 5), "https://www.shutterstock.com/image-photo/portrait-young-beautiful-girl-16-600nw-2511551413.jpg" , new List<string> {"Mamá: Valeria", "Papá: Pablo"}, new List<string> {"Voley", "Instagram"});
        AgregarIntegrante(integrante);
        AgregarIntegrante(integrante2);
    }

    private void AgregarIntegrante (Integrante integrante) 
    {
        integrantes.Add(integrante.DNI, integrante);
    }   

    public Dic<int, Integrante> DevolverIntegrantes()
    {
        return integrantes;
    }

    public Integrante GetIntegrante(int dni)
    {
        if (integrantes.ContainsKey(dni))
        {
            Integrante integrante = integrantes[dni];
        }
        else
        {
            integrante = null;
        }
        return integrante;
    }

}