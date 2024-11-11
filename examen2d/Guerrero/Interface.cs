// Interfaz para las armas
using System;

public interface IArma
{
    void Usar();
}

// Interfaz para las habilidades
public interface IHabilidad
{
    void Ejecutar();
}

public interface IFabricaGuerrero
{
    IArma CrearArma();
    IHabilidad CrearHabilidad();
}















