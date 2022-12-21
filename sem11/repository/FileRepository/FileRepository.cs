using System.Text;
using sem11.models;
using sem11.validatori;

namespace sem11.repository;

public delegate E ParseLineAndCreateEntity<E>(String line);

public class FileRepository<ID, E>: InMemoryRepository<ID, E> where E : Entitate<ID>
{
    protected String NumeFisier;

    protected ParseLineAndCreateEntity<E> ParseLineAndCreateEntity;

    public FileRepository(IValidator<E> validator, string numeFisier, ParseLineAndCreateEntity<E> parseLineAndCreateEntity) : base(validator)
    {
        NumeFisier = numeFisier;
        ParseLineAndCreateEntity = parseLineAndCreateEntity;
        if (!parseLineAndCreateEntity.Equals(null))
        {
            LoadFromFile();
        }
    }

    void LoadFromFile()
    {
        using (var fileStream = File.OpenRead(this.NumeFisier))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
        { 
            String line;
            while((line = streamReader.ReadLine()) != null)
            {
                E entitate = this.ParseLineAndCreateEntity(line);
                base.Save(entitate);
            }
        }

    }
}