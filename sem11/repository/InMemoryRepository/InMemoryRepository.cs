using sem11.models;
using sem11.validatori;

namespace sem11.repository;

public class InMemoryRepository<ID, E>: IRepository<ID, E> where E : Entitate<ID>
{
    protected IDictionary<ID, E> Entitati = new Dictionary<ID, E>();

    protected IValidator<E> Validator;

    public InMemoryRepository(IValidator<E> validator)
    {
        Validator = validator;
    }

    //TODO: implement next time
    public E FindOne(ID id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<E> FindAll()
    {
        return Entitati.Values.ToList<E>();
    }

    public E Save(E entitate)
    {
        Validator.Valideaza(entitate);
        if (Entitati.ContainsKey(entitate.id))
        {
            return entitate;
        }
        Entitati.Add(entitate.id, entitate);
        return entitate;
    }

    //TODO: implement next time
    public E Delete(ID id)
    {
        throw new NotImplementedException();
    }

    //TODO: implement next time
    public E update(E entitate)
    {
        throw new NotImplementedException();
    }
}