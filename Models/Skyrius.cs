using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Skyrius
{
    public string? Pavadinimas { get; set; }

    public int IdSkyrius { get; set; }

    public int FkSandelisidSandelis { get; set; }

    public virtual ICollection<Darbuotojas> Darbuotojas { get; } = new List<Darbuotojas>();

    public virtual Sandelis FkSandelisidSandelisNavigation { get; set; } = null!;
}
