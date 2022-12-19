namespace StatybaServer.Models;
using System.ComponentModel.DataAnnotations;
public class Skyrius
{
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Pavadinimas { get; set; }

    public int IdSkyrius { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public int FkSandelisidSandelis { get; set; }

    public virtual ICollection<Darbuotojas> Darbuotojas { get; } = new List<Darbuotojas>();

    public virtual Sandelis FkSandelisidSandelisNavigation { get; set; } = null!;
}
