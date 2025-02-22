using System;
using System.Security.Cryptography;
using System.Text;

public static class SaltedHash
{
    public static string GenerateSalt()
    {
        byte[] saltBytes = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(saltBytes);
        }
        return Convert.ToBase64String(saltBytes);
    }

    public static string HashPassword(string password, string salt)
    {
        byte[] saltBytes = Convert.FromBase64String(salt);
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

        using (var sha256 = SHA256.Create())
        {
            byte[] hashBytes = new byte[saltBytes.Length + passwordBytes.Length];
            Buffer.BlockCopy(saltBytes, 0, hashBytes, 0, saltBytes.Length);
            Buffer.BlockCopy(passwordBytes, 0, hashBytes, saltBytes.Length, passwordBytes.Length);
            byte[] hashedPasswordBytes = sha256.ComputeHash(hashBytes);
            return Convert.ToBase64String(hashedPasswordBytes);
        }
    }

    public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
    {
        string enteredHash = HashPassword(enteredPassword, storedSalt);
        return enteredHash == storedHash;
    }
}