namespace StatybaServer.Models;

public class Preke
{
    public string? Pavadinimas { get; set; }

    public string? Kategorija { get; set; }

    public decimal? VienetoKaina { get; set; }

    public int? Kiekis { get; set; }

    public string? Aprasymas { get; set; }

    public string? TrumpasAprasymas { get; set; }

    public string? Nuotrauka { get; set; } = "https://media.discordapp.net/attachments/1016597762000818261/1054101131481071666/depositphotos_318221368-stock-illustration-missing-picture-page-for-website.png";

    public int IdPreke { get; set; }

    public virtual ICollection<Turi> Turis { get; } = new List<Turi>();

    public virtual ICollection<Uzsakymopreke> Uzsakymoprekes { get; } = new List<Uzsakymopreke>();
}
