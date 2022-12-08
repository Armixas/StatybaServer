namespace StatybaServer.Models;

public class Pareigos
{
    public string? Pavadinimas { get; set; }

    public int IdPareigos { get; set; }

    public virtual ICollection<Darbuotojas> Darbuotojas { get; } = new List<Darbuotojas>();
}
