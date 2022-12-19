namespace StatybaServer.Models;

public class Uzsakymas
{
    public DateOnly? Data { get; set; }

    public string? Salis { get; set; }

    public string? Miestas { get; set; }

    public string? PastoKodas { get; set; }

    public string? Adresas { get; set; }

    public decimal? Kaina { get; set; }

    public DateOnly? PristatymoData { get; set; }

    public int? Telefonas { get; set; }

    public string? Pastas { get; set; }

    public string? PapildomaInformacija { get; set; }

    public int? ImonesKodas { get; set; }

    public string? ImonesPavadinimas { get; set; }

    public string? ImonesPvmKodas { get; set; }

    public int Statusas { get; set; }

    public int Asmuo { get; set; }

    public int Atsiemimas { get; set; }

    public int Atsiskaitymas { get; set; }

    public int IdUzsakymas { get; set; }

    public int FkKlientasidKlientas { get; set; }

    public int FkPastomatasidPastomatas { get; set; }

    public virtual Asmuo AsmuoNavigation { get; set; }

    public virtual Atsiemimas AtsiemimasNavigation { get; set; }

    public virtual Atsiskaitymas AtsiskaitymasNavigation { get; set; }

    public virtual Klientas FkKlientasidKlientasNavigation { get; set; } = null!;

    public virtual Pastomatas FkPastomatasidPastomatasNavigation { get; set; } = null!;

    public virtual Statusas StatusasNavigation { get; set; }

    public virtual ICollection<Uzsakymopreke> Uzsakymoprekes { get; } = new List<Uzsakymopreke>();
}
