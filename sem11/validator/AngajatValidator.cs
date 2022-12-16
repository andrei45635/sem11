using sem11.models;

namespace sem11.validatori;

public class AngajatValidator: IValidator<Angajat>
{
    public void Valideaza(Angajat entitate)
    {
        string err = "";
        if (string.IsNullOrEmpty(entitate.Nume))
        {
            throw new ValidatorException("gresit");
        }
    }
}