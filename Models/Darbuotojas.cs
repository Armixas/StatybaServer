using System.ComponentModel.DataAnnotations;

namespace StatybaServer.Models;

public class Darbuotojas
{
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? PrisijungimoVardas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public int? Kodas { get; set; }

    [Required(ErrorMessage = "Privalomas laukas")]
    [MinLength(3)]
    public string? Vardas { get; set; }
    public string? Role { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Pavarde { get; set; }

    public DateOnly? IdarbinimoData { get; set; }

    public int Stazas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Slaptazodis { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public decimal ValandinisUzdarbis { get; set; }

    public string? PakeitimaiSesijoje { get; set; }

    public string? Nuotrauka { get; set; }

    public int IdDarbuotojas { get; set; }
    
    [Required(ErrorMessage = "Privalomas laukas")]
    public int FkSkyriusidSkyrius { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public int FkPareigosidPareigos { get; set; }

    public virtual ICollection<Algospriedas> Algospriedas { get; } = new List<Algospriedas>();

    public virtual Pareigos FkPareigosidPareigosNavigation { get; set; } = null!;

    public virtual Skyrius FkSkyriusidSkyriusNavigation { get; set; } = null!;
}
