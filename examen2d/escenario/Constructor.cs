public class Constructor : IConstructorEscenarios
{
    private bool _nieve;
    private bool _frio;
    private bool _lluvia;
    private bool _rocosidad;
    private bool _mar;
    private bool _selva;
    private bool _montaña;
    private bool _granizo;
    private bool _calorExtremo;
    private bool _arena;

    public Escenario GetEscenario()
    {
        return new Escenario
        {
            Nieve = _nieve,
            Frio = _frio,
            Lluvia = _lluvia,
            Rocosidad = _rocosidad,
            Mar = _mar,
            Selva = _selva,
            Montaña = _montaña,
            Granizo = _granizo,
            CalorExtremo = _calorExtremo,
            Arena = _arena
        };
    }

    public void SetNieve(bool nieve)
    {
        _nieve = nieve;
    }

    public void SetFrio(bool frio)
    {
        _frio = frio;
    }

    public void SetLluvia(bool lluvia)
    {
        _lluvia = lluvia;
    }

    public void SetRocosidad(bool rocosidad)
    {
        _rocosidad = rocosidad;
    }

    public void SetMar(bool mar)
    {
        _mar = mar;
    }

    public void SetSelva(bool selva)
    {
        _selva = selva;
    }

    public void SetMontaña(bool montaña)
    {
        _montaña = montaña;
    }

    public void SetGranizo(bool granizo)
    {
        _granizo = granizo;
    }

    public void SetCalorExtremo(bool calorExtremo)
    {
        _calorExtremo = calorExtremo;
    }

    public void SetArena(bool arena)
    {
        _arena = arena;
    }
}

