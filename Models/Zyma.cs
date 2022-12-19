namespace StatybaServer.Models;
using System.ComponentModel.DataAnnotations;
public class Zyma
{
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Pavadinimas { get; set; }

    public int IdZyma { get; set; }

    public virtual ICollection<Priskiriama> Priskiriamas { get; } = new List<Priskiriama>();
}
