namespace StatybaServer.Models;

public class Sandelis
{
    public string? Salis { get; set; }

    public string? Miestas { get; set; }

    public string? Adresas { get; set; }

    public int IdSandelis { get; set; }

    public virtual ICollection<Skyrius> Skyrius { get; } = new List<Skyrius>();
}
