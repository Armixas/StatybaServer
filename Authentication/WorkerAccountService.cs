using Microsoft.EntityFrameworkCore;
using StatybaServer.Models;

namespace StatybaServer.Authentication;

public class WorkerAccountService
{
    private readonly IDbContextFactory<PostgresContext> _contextFac;

    public WorkerAccountService(IDbContextFactory<PostgresContext> contextFac)
    {
        _contextFac = contextFac;
    }

    public Darbuotojas? GetUserByName(string username)
    {
        using var pgContext = _contextFac.CreateDbContext();

        return pgContext.Darbuotojas
            .FirstOrDefault(d => d.PrisijungimoVardas == username);
    }
}