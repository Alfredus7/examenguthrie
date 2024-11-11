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

// Interfaz de la fábrica de guerreros
public interface IFabricaGuerrero
{
    IArma CrearArma();
    IHabilidad CrearHabilidadPrincipal();
    IHabilidad CrearRetirada();
    IHabilidad CrearCorrer();
    IHabilidad CrearSaltar();
}















