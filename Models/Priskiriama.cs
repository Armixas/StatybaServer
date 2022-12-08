namespace StatybaServer.Models;

public class Priskiriama
{
    public int FkZymaidZyma { get; set; }

    public int FkPrekeidPreke { get; set; }

    public virtual Zyma FkZymaidZymaNavigation { get; set; } = null!;
}
