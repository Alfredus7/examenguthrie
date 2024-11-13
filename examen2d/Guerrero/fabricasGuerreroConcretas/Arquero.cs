public class FabricaArquero : IFabricaGuerrero
{
    public override IArma CrearArma()
    {
        return new Arco();
    }

    public override IHabilidad CrearHabilidadPrincipal()
    {
        return new AtaqueADistancia();
    }

    public override IHabilidad CrearRetirada()
    {
        return new Retirada();
    }

    public override IHabilidad CrearCorrer()
    {
        return new Correr();
    }

    public override IHabilidad CrearSaltar()
    {
        return new Saltar();
    }
}
