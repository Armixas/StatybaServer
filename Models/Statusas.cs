namespace StatybaServer.Models;

public class Statusas
{
    public int IdStatusas { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();
}
