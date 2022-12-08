namespace StatybaServer.Models;

public class Zyma
{
    public string? Pavadinimas { get; set; }

    public int IdZyma { get; set; }

    public virtual ICollection<Priskiriama> Priskiriamas { get; } = new List<Priskiriama>();
}
