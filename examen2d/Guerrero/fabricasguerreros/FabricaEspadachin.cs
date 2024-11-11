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