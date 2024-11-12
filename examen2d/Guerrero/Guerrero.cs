// Clase Guerrero que usa una fábrica para obtener su arma y habilidades
public class Guerrero
{
    private IArma _arma;
    private IHabilidad _habilidadPrincipal;
    private IHabilidad _retirada;
    private IHabilidad _correr;
    private IHabilidad _saltar;

    public Guerrero(IFabricaGuerrero fabrica)
    {
        _arma = fabrica.CrearArma();
        _habilidadPrincipal = fabrica.CrearHabilidadPrincipal();
        _retirada = fabrica.CrearRetirada();
        _correr = fabrica.CrearCorrer();
        _saltar = fabrica.CrearSaltar();
    }

    public void Atacar()
    {
        _arma.Usar();
        _habilidadPrincipal.Ejecutar();
    }







    public void Retirarse()
    {
        _retirada.Ejecutar();
    }

    public void Correr()
    {
        _correr.Ejecutar();
    }

    public void Saltar()
    {
        _saltar.Ejecutar();
    }
}
