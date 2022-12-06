using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Klientas
{
    public string? Vardas { get; set; }

    public string? Pavarde { get; set; }

    public string? Nuotrauka { get; set; }

    public string? Aprasymas { get; set; }

    public int IdKlientas { get; set; }

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();
}
