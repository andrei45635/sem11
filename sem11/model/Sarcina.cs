namespace sem11.models;

public enum Dificultate
{
    USOARA,
    MEDIE,
    GREA
}

public class Sarcina: Entitate<string>
{
    public Dificultate Dificultate { get; set; }
    public int NrOraEstimate { get; set; }

    public Sarcina(string id) : base(id)
    {
    }

    public Sarcina(string id, Dificultate dificultate, int nrOraEstimate) : base(id)
    {
        Dificultate = dificultate;
        NrOraEstimate = nrOraEstimate;
    }

    public override string ToString()
    {
        return id + " " + Dificultate + " " + NrOraEstimate + "\n";
    }
}