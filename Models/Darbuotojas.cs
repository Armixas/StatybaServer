using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Darbuotojas
{
    public string? PrisijungimoVardas { get; set; }

    public int? Kodas { get; set; }

    public string? Vardas { get; set; }

    public string? Pavarde { get; set; }

    public DateOnly? IdarbinimoData { get; set; }

    public int? Stazas { get; set; }

    public string? Slaptazodis { get; set; }

    public decimal? ValandinisUzdarbis { get; set; }

    public string? PakeitimaiSesijoje { get; set; }

    public string? Nuotrauka { get; set; }

    public int IdDarbuotojas { get; set; }

    public int FkSkyriusidSkyrius { get; set; }

    public int FkPareigosidPareigos { get; set; }

    public virtual ICollection<Algospriedas> Algosprieda { get; } = new List<Algospriedas>();

    public virtual Pareigos FkPareigosidPareigosNavigation { get; set; } = null!;

    public virtual Skyrius FkSkyriusidSkyriusNavigation { get; set; } = null!;

    public virtual ICollection<Tvarko> Tvarkos { get; } = new List<Tvarko>();
}
