// Fábrica concreta para crear un Guerrero de tipo Espadachín
public class Espadachin : IFabricaGuerrero
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