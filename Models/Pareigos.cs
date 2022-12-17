﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatybaServer.Models;

public class Pareigos
{
    public int IdPareigos { get; set; }
    public string? Pavadinimas { get; set; }

    public virtual ICollection<Darbuotojas> Darbuotojas { get; } = new List<Darbuotojas>();
}
