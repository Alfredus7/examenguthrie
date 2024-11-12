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
        Escenario escenario1 = constructor.GetEscenario();
        Console.WriteLine("Escenario 1: " + escenario1);



        // Crear un guerrero Espadachín
        IFabricaGuerrero fabricaEspadachin = new FabricaEspadachin();
        Guerrero espadachin = new Guerrero(fabricaEspadachin);
        espadachin.Atacar();
        espadachin.Habilidades();
        espadachin.Retirarse();
        espadachin.Correr();
        espadachin.Saltar();



        Console.ReadLine();
    }
}
