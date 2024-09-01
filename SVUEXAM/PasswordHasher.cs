using System;
using System.Security.Cryptography;
using System.Text;

public class PasswordHasher
{
    // Method to hash a password
    public static string HashPassword(string password)
    {
        // Create a SHA256 object
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // Convert the password string to a byte array
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convert the byte array to a hex string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
