using sem11.models;
using sem11.repository;
using sem11.Service;
using sem11.validatori;

public class Program
{
    public static void Main(string[] args)
    {
        IRepository<string, Angajat> RepoAngajat = new FileRepoAngajat(new AngajatValidator(), "C:\\Users\\Andrei\\RiderProjects\\sem11\\sem11\\data\\angajati.txt");
        IRepository<string, Sarcina> RepoSarcina = new FileRepoSarcina(new SarcinaValidator(), "C:\\Users\\Andrei\\RiderProjects\\sem11\\sem11\\data\\sarcini.txt");
        IRepository<string, Pontaj> RepoPontaj = new FileRepoPontaj(new PontajValidator(), "C:\\Users\\Andrei\\RiderProjects\\sem11\\sem11\\data\\pontaj.txt");

        ServiceAngajat ServiceAngajat = new ServiceAngajat(RepoAngajat);
        ServiceSarcina ServiceSarcina = new ServiceSarcina(RepoSarcina);
        ServicePontaj ServicePontaj = new ServicePontaj(RepoPontaj);

        List<Angajat> AllAngajati = ServiceAngajat.GetAll();
        foreach (var angajat in AllAngajati)
        {
            Console.WriteLine(angajat);
        }
        
        List<Sarcina> AllSarcini = ServiceSarcina.GetAll();
        foreach (var sarcina in AllSarcini)
        {
            Console.WriteLine(sarcina);
        }
        
        List<Pontaj> AllPontaje = ServicePontaj.GetAll();
        foreach (var pontaj in AllPontaje)
        {
            Console.WriteLine(pontaj);
        }
    }
}