namespace sem11.models;

public class Entitate<TID>
{
    public TID id { get; set; }

    public Entitate(TID id)
    {
        this.id = id;
    }
}