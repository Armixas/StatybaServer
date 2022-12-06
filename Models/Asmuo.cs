using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Asmuo
{
    public int IdAsmuo { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Uzsakymas> Uzsakymas { get; } = new List<Uzsakymas>();
}
