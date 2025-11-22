using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LogibForm
{
    public static class PasswordEncryptDecrypt
    {
        private static int shift = 3;
        public static string EncryptPassword(string input)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)(((letter + shift - offset) % 26) + offset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        public static string DecryptPassword(string input)
        {
            return EncryptPassword(input, 26 - shift);
        }
        private static string EncryptPassword(string input, int s)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)(((letter + s - offset) % 26) + offset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        public static string getEncryptedPassword(string username)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string getEncryptPassword = "SELECT CustPassword FROM CustomerAccount WHERE EmailAddress = :user";

                using (OracleCommand cmd = new OracleCommand(getEncryptPassword, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("user", username));

                    object result = cmd.ExecuteScalar();

                    return result?.ToString();
                }
            }
        }
    }
}
