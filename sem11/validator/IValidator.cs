namespace sem11.validatori;

public interface IValidator<E>
{
    void Valideaza(E entitate);
}