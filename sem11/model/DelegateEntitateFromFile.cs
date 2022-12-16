namespace sem11.models;

public class DelegateEntitateFromFile
{
    private static char Separator = ';';
    
    public static Angajat DelegateAngajat(string line)
    {
        string[] SplitAngajati = line.Split(Separator);
        Angajat angajat = new Angajat(SplitAngajati[0], SplitAngajati[1], float.Parse(SplitAngajati[3]), (Nivel)Enum.Parse(typeof(Nivel), SplitAngajati[3]));
        /*{
            id = SplitAngajati[0],
            Nume = SplitAngajati[1],
            VenitPeOra = float.Parse(SplitAngajati[2]),
            Nivel = (Nivel) Enum.Parse(typeof(Nivel), SplitAngajati[3])
        };*/
        return angajat;
    }
    //TODO: delegates for Sarcina and Pontaj
}