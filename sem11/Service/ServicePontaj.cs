using sem11.models;
using sem11.repository;

namespace sem11.Service;

public class ServicePontaj
{
    private IRepository<string, Pontaj> Repository;

    public ServicePontaj(IRepository<string, Pontaj> repository)
    {
        Repository = repository;
    }
    
    public List<Pontaj> GetAll()
    {
        return Repository.FindAll().ToList();
    }

    public Pontaj Save(Pontaj pontaj)
    {
        return Repository.Save(pontaj);
    }
}