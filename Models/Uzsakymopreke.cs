using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Uzsakymopreke
{
    public decimal? Suma { get; set; }

    public int? Kiekis { get; set; }

    public int? Atsiemimas { get; set; }

    public int IdUzsakymoPreke { get; set; }

    public int FkUzsakymasidUzsakymas { get; set; }

    public int FkPrekeidPreke { get; set; }

    public virtual Atsiemimas? AtsiemimasNavigation { get; set; }

    public virtual Preke FkPrekeidPrekeNavigation { get; set; } = null!;

    public virtual Uzsakymas FkUzsakymasidUzsakymasNavigation { get; set; } = null!;
}
