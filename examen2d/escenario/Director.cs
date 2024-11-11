public class Director
{
    public void CrearEscenario1(IConstructorEscenarios constructor)
    {
        constructor.SetNieve(true);
        constructor.SetFrio(true);
        constructor.SetLluvia(true);
    }

    public void CrearEscenario2(IConstructorEscenarios constructor)
    {
        constructor.SetMar(true);
        constructor.SetSelva(true);
        constructor.SetMontaña(true);
        constructor.SetCalorExtremo(true);
    }

    public void CrearEscenario3(IConstructorEscenarios constructor)
    {
        constructor.SetArena(true);
        constructor.SetRocosidad(true);
        constructor.SetGranizo(true);
    }

    public void CrearEscenario4(IConstructorEscenarios constructor)
    {
        constructor.SetSelva(true);
        constructor.SetLluvia(true);
        constructor.SetFrio(true);
        constructor.SetMontaña(true);
        constructor.SetCalorExtremo(true);
    }
}


