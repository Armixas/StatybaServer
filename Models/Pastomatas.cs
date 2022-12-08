namespace StatybaServer.Models;

public class Pastomatas
{
    public string? Imone { get; set; }

    public string? Salis { get; set; }

    public string? Miestas { get; set; }

    public string? Adresas { get; set; }

    public int IdPastomatas { get; set; }

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();
}
