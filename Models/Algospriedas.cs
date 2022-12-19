namespace StatybaServer.Models;
using System.ComponentModel.DataAnnotations;
public class Algospriedas
{
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Pavadinimas { get; set; }

    
    public decimal? Dydis { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public DateOnly? Data { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public string? Aprasymas { get; set; }

    public int IdAlgosPriedas { get; set; }
    [Required(ErrorMessage = "Privalomas laukas")]
    public int FkDarbuotojasidDarbuotojas { get; set; }

    public virtual Darbuotojas FkDarbuotojasidDarbuotojasNavigation { get; set; } = null!;
}
