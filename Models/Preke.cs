using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Preke
{
    public string? Pavadinimas { get; set; }

    public string? Kategorija { get; set; }

    public decimal? VienetoKaina { get; set; }

    public int? Kiekis { get; set; }

    public string? Aprasymas { get; set; }

    public string? TrumpasAprasymas { get; set; }

    public string? Nuotrauka { get; set; }

    public int IdPreke { get; set; }

    public virtual ICollection<Turi> Turis { get; } = new List<Turi>();

    public virtual ICollection<Uzsakymopreke> Uzsakymoprekes { get; } = new List<Uzsakymopreke>();
}
