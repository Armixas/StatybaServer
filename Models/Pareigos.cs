using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Pareigos
{
    public string? Pavadinimas { get; set; }

    public int IdPareigos { get; set; }

    public virtual ICollection<Darbuotojas> Darbuotojas { get; } = new List<Darbuotojas>();
}
