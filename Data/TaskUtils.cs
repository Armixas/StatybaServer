﻿using System.Security.Cryptography;
using System.Text;

namespace StatybaServer.Data;

public class TaskUtils
{
    public string CalculateHash(string username, string password)
    {
        var hashedPassword = string.Empty;

        using var sha512 = SHA512.Create();

        var bytes =
            Encoding.UTF8.GetBytes($"{password}--{username}");
        var hashBytes = sha512.ComputeHash(bytes);

        var stringBuilder = new StringBuilder();

        foreach (var hashByte in hashBytes) stringBuilder.Append(hashByte.ToString("x2"));

        hashedPassword = stringBuilder.ToString();

        return hashedPassword;
    }
}