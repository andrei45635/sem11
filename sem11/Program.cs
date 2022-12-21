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

        Console.WriteLine("----------------------------");
        Console.WriteLine("Task 1");
        var Rez = AllAngajati.OrderBy(a => a.Nivel)
                                              .ThenByDescending(a => a.VenitPeOra)
                                              .GroupBy(a => a.Nivel)
                                              .SelectMany(x => x);
        foreach (var angajat in Rez)
        {
            Console.WriteLine(angajat);
        }
        
        Console.WriteLine("----------------------------");
        Console.WriteLine("Task 2");
        var RezSarcina = AllSarcini
            .GroupBy(s => s.Dificultate)
            .Select(s => new
            {
                Average = s.Average(s => s.NrOraEstimate),
                type = s.Key
            });
        foreach (var sarcina in RezSarcina)
        {
            Console.WriteLine(sarcina);
        }
        
        Console.WriteLine("----------------------------");
        Console.WriteLine("Task 2 - SQLike");
        var SqlT2 = from s in AllSarcini
            group s by s.Dificultate
            into g
            select new
            {
                oreInMedie = g.Average(S => S.NrOraEstimate),
                dificultate = g.Key
            };
        foreach (var sarc in SqlT2)
        {
            Console.WriteLine(sarc);
        }
        
        //TODO: Task 3
        Console.WriteLine("\n");
        Console.WriteLine("TODO");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Task 3"); 
    }           
}