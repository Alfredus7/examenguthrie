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

        // Crear Escenario 2: mar, selva, montaña, calor extremo
        constructor = new Constructor(); // Reset del constructor
        director.CrearEscenario2(constructor);
        Escenario escenario2 = constructor.GetEscenario();
        Console.WriteLine("Escenario 2: " + escenario2);

        // Crear Escenario 3: arena, rocosidad, granizo
        constructor = new Constructor(); // Reset del constructor
        director.CrearEscenario3(constructor);
        Escenario escenario3 = constructor.GetEscenario();
        Console.WriteLine("Escenario 3: " + escenario3);

        // Crear Escenario 4: selva, lluvia, frío, montaña, calor extremo
        constructor = new Constructor(); // Reset del constructor
        director.CrearEscenario4(constructor);
        Escenario escenario4 = constructor.GetEscenario();
        Console.WriteLine("Escenario 4: " + escenario4);



        // Crear un guerrero Espadachín
        IFabricaGuerrero fabricaEspadachin = new Espadachin();
        GuerrerosFabrica espadachin = new GuerrerosFabrica(fabricaEspadachin);
        Console.WriteLine("Guerrero Espadachín:");
        espadachin.Atacar();

        // Crear un guerrero Arquero
        IFabricaGuerrero fabricaArquero = new Arquero();
        GuerrerosFabrica arquero = new GuerrerosFabrica(fabricaArquero);
        Console.WriteLine("\nGuerrero Arquero:");
        arquero.Atacar();



        Console.ReadLine();
    }
}
