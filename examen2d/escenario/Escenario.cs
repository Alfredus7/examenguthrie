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
        string descripcion = "el Escenario";

        if (Nieve)
            descripcion += "Tiene nieve, ";
        if (Frio)
            descripcion += "Hace frío, ";
        if (Lluvia)
            descripcion += "Llueve, ";
        if (Rocosidad)
            descripcion += "Es rocoso, ";
        if (Mar)
            descripcion += "Tiene mar, ";
        if (Selva)
            descripcion += "Es selvático, ";
        if (Montaña)
            descripcion += "Tiene montañas, ";
        if (Granizo)
            descripcion += "Graniza, ";
        if (CalorExtremo)
            descripcion += "Tiene calor extremo, ";
        if (Arena)
            descripcion += "Es arenoso, ";

        return descripcion;
    }

}





