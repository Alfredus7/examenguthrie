public class GuerrerosFabrica
{
    private IArma _arma;
    private IHabilidad _habilidad;

    public GuerrerosFabrica(IFabricaGuerrero fabrica)
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
