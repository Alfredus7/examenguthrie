using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        Director director = new Director();
        Constructor constructor = new Constructor();

        // Crear Escenario 1: nieve, frío, lluvia
        director.CrearEscenario1(constructor);
        Escenario escenario = constructor.GetEscenario();
        Console.WriteLine(escenario);



        // Crear un guerrero Espadachín
        Console.WriteLine("el guerrero");
        IFabricaGuerrero fabricaEspadachin = new FabricaEspadachin();
        Guerrero guerrero = new Guerrero(fabricaEspadachin);
        guerrero.Atacar();
        guerrero.Habilidades();
        guerrero.Retirarse();
        guerrero.Correr();
        guerrero.Saltar();



        Console.ReadLine();
    }
}
