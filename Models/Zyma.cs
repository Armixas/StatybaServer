using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Zyma
{
    public string? Pavadinimas { get; set; }

    public int IdZyma { get; set; }

    public virtual ICollection<Priskiriama> Priskiriamas { get; } = new List<Priskiriama>();
}
