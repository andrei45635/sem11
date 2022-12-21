using sem11.models;
using sem11.validatori;

namespace sem11.repository;

public class FileRepoSarcina: FileRepository<string, Sarcina>
{
    public FileRepoSarcina(IValidator<Sarcina> validator, string numeFisier) : base(validator, numeFisier, DelegateEntitateFromFile.DelegateSarcina)
    {
    }
}