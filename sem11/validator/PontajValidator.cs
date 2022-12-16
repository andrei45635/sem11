using System.Net.Security;
using sem11.models;

namespace sem11.validatori;

public class PontajValidator: IValidator<Pontaj>
{
    public void Valideaza(Pontaj entitate)
    {
        if (entitate == null || entitate.Data > DateTime.Now)
        {
            throw new ValidatorException("gresit");
        }
    }
}