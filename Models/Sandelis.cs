namespace StatybaServer.Models;
using System.ComponentModel.DataAnnotations;
public class Sandelis
{
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Salis { get; set; }

    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Miestas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Adresas { get; set; }

    public int IdSandelis { get; set; }

    public virtual ICollection<Skyrius> Skyrius { get; } = new List<Skyrius>();
}
