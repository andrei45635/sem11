using sem11.models;
using sem11.validatori;

namespace sem11.repository;

public class FileRepoAngajat: FileRepository<string, Angajat>
{
    public FileRepoAngajat(IValidator<Angajat> validator, string numeFisier) : base(validator, numeFisier, DelegateEntitateFromFile.DelegateAngajat)
    {
    }
}