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
// Fábrica concreta para crear un Guerrero de tipo Espadachín
public class FabricaEspadachin : IFabricaGuerrero
{
    public IArma CrearArma()
    {
        return new Espada();
    }

    public IHabilidad CrearHabilidad()
    {
        return new AtaqueCuerpoACuerpo();
    }
}

// Fábrica concreta para crear un Guerrero de tipo Arquero
public class FabricaArquero : IFabricaGuerrero
{
    public IArma CrearArma()
    {
        return new Arco();
    }

    public IHabilidad CrearHabilidad()
    {
        return new AtaqueADistancia();
    }
}
public class Guerrero
{
    private IArma _arma;
    private IHabilidad _habilidad;

    public Guerrero(IFabricaGuerrero fabrica)
    {
        _arma = fabrica.CrearArma();
        _habilidad = fabrica.CrearHabilidad();
    }

    public void Atacar()
    {
        _arma.Usar();
        _habilidad.Ejecutar();
    }
}

