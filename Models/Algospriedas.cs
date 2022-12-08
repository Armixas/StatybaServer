namespace StatybaServer.Models;

public class Algospriedas
{
    public string? Pavadinimas { get; set; }

    public decimal? Dydis { get; set; }

    public DateOnly? Data { get; set; }

    public string? Aprasymas { get; set; }

    public int IdAlgosPriedas { get; set; }

    public int FkDarbuotojasidDarbuotojas { get; set; }

    public virtual Darbuotojas FkDarbuotojasidDarbuotojasNavigation { get; set; } = null!;
}
