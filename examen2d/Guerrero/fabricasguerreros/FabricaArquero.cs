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
