using sem11.models;
using sem11.validatori;

namespace sem11.repository;

public class FileRepoPontaj: FileRepository<string, Pontaj>
{
    public FileRepoPontaj(IValidator<Pontaj> validator, string numeFisier) : base(validator, numeFisier, DelegateEntitateFromFile.DelegatePontaj)
    {
    }
}