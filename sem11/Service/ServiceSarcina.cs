using sem11.models;
using sem11.repository;

namespace sem11.Service;

public class ServiceSarcina
{
    private IRepository<string, Sarcina> Repository;

    public ServiceSarcina(IRepository<string, Sarcina> repository)
    {
        Repository = repository;
    }
    
    public List<Sarcina> GetAll()
    {
        return Repository.FindAll().ToList();
    }

    public Sarcina Save(Sarcina sarcina)
    {
        return Repository.Save(sarcina);
    }
}