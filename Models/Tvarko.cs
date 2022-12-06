using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Tvarko
{
    public int FkDarbuotojasidDarbuotojas { get; set; }

    public int FkDarbuotojasidDarbuotojas1 { get; set; }

    public virtual Darbuotojas FkDarbuotojasidDarbuotojasNavigation { get; set; } = null!;
}
