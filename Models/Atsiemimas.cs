namespace StatybaServer.Models;

public class Atsiemimas
{
    public int IdAtsiemimas { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();

    public virtual ICollection<Uzsakymopreke> Uzsakymoprekes { get; } = new List<Uzsakymopreke>();
}
