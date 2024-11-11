// Fábrica concreta para crear un Guerrero de tipo Arquero
public class Arquero : IFabricaGuerrero
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
