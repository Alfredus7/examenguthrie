public class Escenario
{
    public bool Nieve { get; set; }
    public bool Frio { get; set; }
    public bool Lluvia { get; set; }
    public bool Rocosidad { get; set; }
    public bool Mar { get; set; }
    public bool Selva { get; set; }
    public bool Montaña { get; set; }
    public bool Granizo { get; set; }
    public bool CalorExtremo { get; set; }
    public bool Arena { get; set; }


    public override string ToString()
    {
        return $"Escenario [Nieve={Nieve}, Frio={Frio}, Lluvia={Lluvia}, Rocosidad={Rocosidad}, Mar={Mar}, " +
               $"Selva={Selva}, Montaña={Montaña}, Granizo={Granizo}, CalorExtremo={CalorExtremo}, Arena={Arena}]";
    }
}





