// Clase concreta para ataque a distancia
using System;

public class AtaqueADistancia : IHabilidad
{
    public override void Ejecutar()
    {
        Console.WriteLine("a Ejecutando un ataque a distancia.");
    }
}
