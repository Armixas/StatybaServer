using Microsoft.AspNetCore.Identity;

namespace StatybaServer.Authentication;

public class UserAccountService
{
    // laikinai issaugomi duomenys, paskui istrint, kai db bus prijungta
    private List<UserAccount> _users;
    // vietoj sito is duomenu bazes bus gaunami duomenys
    public UserAccountService()
    {
        _users = new List<UserAccount>()
        {
            new UserAccount{Username = "dedeAdminas123", Password = "dedeAdminas123", Role = "Administratorius"},
            new UserAccount{Username = "worker", Password = "worker", Role = "Darbuotojas"},
            new UserAccount{Username = "user", Password = "user", Role = "Vartotojas"}
        };
    }
    // metodas duomenu gavimui is DB (dummy)
    public UserAccount? GetUserByName(string username)
    {
        return _users.FirstOrDefault(x => x.Username == username);
    }
}