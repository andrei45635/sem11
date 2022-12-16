namespace sem11.models;

public class Pontaj: Entitate<string>
{
    public Angajat Angajat { get; set; }
    public Sarcina Sarcina { get; set; }
    public DateTime Data { get; set; }

    public Pontaj(string id, Angajat angajat, Sarcina sarcina, DateTime data) : base(id)
    {
        Angajat = angajat;
        Sarcina = sarcina;
        Data = data;
    }
}