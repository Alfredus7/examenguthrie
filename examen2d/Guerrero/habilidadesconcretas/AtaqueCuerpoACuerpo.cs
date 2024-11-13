// Clase concreta para ataque cuerpo a cuerpo
using System;

public class AtaqueCuerpoACuerpo : IHabilidad
{
    public override void Ejecutar()
    {
        Console.WriteLine("a Ejecutando un ataque cuerpo a cuerpo.");
    }
}