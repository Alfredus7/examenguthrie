// Clase concreta para Arco
using System;

public class Arco : IArma
{
    public override void Usar()
    {
        Console.WriteLine("a Usando un arco para atacar a distancia.");
    }
}
