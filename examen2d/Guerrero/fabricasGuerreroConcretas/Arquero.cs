public class FabricaArquero : IFabricaGuerrero
{
    public IArma CrearArma()
    {
        return new Arco();
    }

    public IHabilidad CrearHabilidadPrincipal()
    {
        return new AtaqueADistancia();
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
