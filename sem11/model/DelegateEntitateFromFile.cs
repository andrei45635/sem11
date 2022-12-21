namespace sem11.models;

public class DelegateEntitateFromFile
{
    private static char Separator = ';';
    
    public static Angajat DelegateAngajat(string line)
    {
        string[] SplitAngajati = line.Split(Separator);
        Angajat angajat = new Angajat(SplitAngajati[0], SplitAngajati[1], float.Parse(SplitAngajati[2]), (Nivel)Enum.Parse(typeof(Nivel), SplitAngajati[3]));
        /*{
            id = SplitAngajati[0],
            Nume = SplitAngajati[1],
            VenitPeOra = float.Parse(SplitAngajati[2]),
            Nivel = (Nivel) Enum.Parse(typeof(Nivel), SplitAngajati[3])
        };*/
        return angajat;
    }

    public static Sarcina DelegateSarcina(string line)
    {
        string[] SplitSarcina = line.Split(Separator);
        Sarcina sarcina = new Sarcina(SplitSarcina[0], (Dificultate)Enum.Parse(typeof(Dificultate), SplitSarcina[1]),
            int.Parse(SplitSarcina[2]));
        return sarcina;
    }
    
    public static Pontaj DelegatePontaj(string line)
    {
        string[] SplitPontaj = line.Split(Separator);
        Angajat PontajAngajat = new Angajat(SplitPontaj[1]);
        Sarcina PontajSarcina = new Sarcina(SplitPontaj[2]);
        Pontaj pontaj = new Pontaj(SplitPontaj[0], PontajAngajat, PontajSarcina, DateTime.Parse(SplitPontaj[3]));
        return pontaj;
    }
}