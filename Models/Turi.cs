using System;
using System.Collections.Generic;

namespace StatybaServer.Models;

public partial class Turi
{
    public int FkPrekeidPreke { get; set; }

    public int FkSandelisidSandelis { get; set; }

    public virtual Preke FkPrekeidPrekeNavigation { get; set; } = null!;
}
