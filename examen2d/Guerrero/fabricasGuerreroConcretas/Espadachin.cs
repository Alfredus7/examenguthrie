public class FabricaEspadachin : IFabricaGuerrero
{
    public override IArma AprenderUsoArma()
    {
        return new Espada();
    }

    public override IHabilidad AprenderHabilidadEspecial()
    {
        return new AtaqueCuerpoACuerpo();
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