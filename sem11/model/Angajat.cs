namespace sem11.models;
public enum Nivel
{
    JUNIOR,
    MEDIUM, 
    SENIOR
}

public class Angajat: Entitate<string>
{
    public String Nume { get; set; }
    public float VenitPeOra { get; set; }
    public Nivel Nivel { get; set; }
    
    public Angajat(string id, string nume, float venitPeOra, Nivel nivel) : base(id)
    {
        Nume = nume;
        VenitPeOra = venitPeOra;
        Nivel = nivel;
    }

    public override string ToString()
    {
        return "ID: " + id + " Nume: " + Nume + " VenitPeOra: " + VenitPeOra + " Nivel: " + Nivel + "\n";
    }
}