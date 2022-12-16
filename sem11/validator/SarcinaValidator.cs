using sem11.models;

namespace sem11.validatori;

public class SarcinaValidator: IValidator<Sarcina>
{
    public void Valideaza(Sarcina entitate)
    {
        if (entitate == null || entitate.NrOraEstimate < 0)
        {
            throw new ValidatorException("gresit");
        }
    }
}