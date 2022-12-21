using sem11.models;
using sem11.repository;

namespace sem11.Service;

public class ServiceAngajat
{
    private IRepository<string, Angajat> Repository;

    public ServiceAngajat(IRepository<string, Angajat> repository)
    {
        Repository = repository;
    }

    public List<Angajat> GetAll()
    {
        return Repository.FindAll().ToList();
    }

    public Angajat Save(Angajat angajat)
    {
        return Repository.Save(angajat);
    }
}