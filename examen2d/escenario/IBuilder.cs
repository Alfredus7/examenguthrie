public interface IConstructorEscenarios
{
    void SetNieve(bool nieve);
    void SetFrio(bool frio);
    void SetLluvia(bool lluvia);
    void SetRocosidad(bool rocosidad);
    void SetMar(bool mar);
    void SetSelva(bool selva);
    void SetMontaña(bool montaña);
    void SetGranizo(bool granizo);
    void SetCalorExtremo(bool calorExtremo);
    void SetArena(bool arena);
    Escenario GetEscenario();
}

