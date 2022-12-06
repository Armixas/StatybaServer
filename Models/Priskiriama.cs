using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Priskiriama
{
    public int FkZymaidZyma { get; set; }

    public int FkPrekeidPreke { get; set; }

    public virtual Zyma FkZymaidZymaNavigation { get; set; } = null!;
}
