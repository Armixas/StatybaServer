namespace StatybaServer.Models;
using System.ComponentModel.DataAnnotations;
public class Preke
{
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Pavadinimas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Kategorija { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public decimal? VienetoKaina { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public int? Kiekis { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Aprasymas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? TrumpasAprasymas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Nuotrauka { get; set; } = "https://media.discordapp.net/attachments/1016597762000818261/1054101131481071666/depositphotos_318221368-stock-illustration-missing-picture-page-for-website.png";

    public int IdPreke { get; set; }

    public virtual ICollection<Turi> Turis { get; } = new List<Turi>();

    public virtual ICollection<Uzsakymopreke> Uzsakymoprekes { get; } = new List<Uzsakymopreke>();
}
