using System.Security.Cryptography;
using System.Text;

namespace StatybaServer.Data;

public class TaskUtils
{
    public string CalculateHash(string username, string password)
    {
        string hashedPassword = String.Empty;
            
        using var sha512 = SHA512.Create();

        byte[] bytes =
            Encoding.UTF8.GetBytes($"{password}--{username}");
        byte[] hashBytes = sha512.ComputeHash(bytes);

        StringBuilder stringBuilder = new StringBuilder();

        foreach (byte hashByte in hashBytes)
        {
            stringBuilder.Append(hashByte.ToString("x2"));
        }

        hashedPassword = stringBuilder.ToString();
        
        return hashedPassword;
    }
}