namespace StatybaServer.Models;

public class Klientas
{
    public string? Vardas { get; set; }

    public string? Pavarde { get; set; }

    public string? Nuotrauka { get; set; }

    public string? Aprasymas { get; set; }

    public int IdKlientas { get; set; }

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();
}
