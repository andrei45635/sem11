using sem11.models;

namespace sem11.repository;

public interface IRepository<ID, E> where E:Entitate<ID>
{
    E FindOne(ID id);

    IEnumerable<E> FindAll();

    E Save(E entitate);

    E Delete(ID id);

    E update(E entitate);
}