using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Atsiskaitymas
{
    public int IdAtsiskaitymas { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();
}
