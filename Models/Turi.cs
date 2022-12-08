namespace StatybaServer.Models;

public class Turi
{
    public int FkPrekeidPreke { get; set; }

    public int FkSandelisidSandelis { get; set; }

    public virtual Preke FkPrekeidPrekeNavigation { get; set; } = null!;
}
