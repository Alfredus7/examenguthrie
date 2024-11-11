public class FabricaEspadachin : IFabricaGuerrero
{
    public IArma CrearArma()
    {
        return new Espada();
    }

    public IHabilidad CrearHabilidadPrincipal()
    {
        return new AtaqueCuerpoACuerpo();
    }

    public IHabilidad CrearRetirada()
    {
        return new Retirada();
    }

    public IHabilidad CrearCorrer()
    {
        return new Correr();
    }

    public IHabilidad CrearSaltar()
    {
        return new Saltar();
    }
}