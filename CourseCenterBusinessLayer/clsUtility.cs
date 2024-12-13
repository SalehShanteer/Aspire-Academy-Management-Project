using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace CourseCenter_Project
{
    public static class clsUtility
    {

        private static readonly string key = "SalehMousa12345Shanteer99*-+*-+9";//32 byte
        
        private static readonly string iv = "123456Shanteer11";//16 byte


        public static string Encrypt(string Text)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(Text);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }


        public static string Decrypt(string EncryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(EncryptedText)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }

            }
        }
        
        public static string DateTimeString()
        {
            return DateTime.Now.ToString();
        }

        public static bool IsLengthValid(string str, int length)
        {
            return str.Length >= length;
        }

        public static bool IsContainCapitalLetter(string str)
        {
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        public static bool IsContainSmallLetter(string str)
        {
            foreach (char c in str)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        public static bool IsContainDigit(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public static bool IsContainSpecialCharacter(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                    return true;
            }
            return false;
        }

        public static string TimerString(int s)
        {
            string Timer = string.Empty; 

            if (s < 60)
            {
               //Timer = s < 10 ? $"00:00:0{s}" : $"00:00:{s}";

                Timer = s < 10 ? $"00:0{s}" : $"00:{s}";
            }
            else if (s < 3600)
            {
                string Sec = "", Min = "";
                Sec = s % 60 < 10 ? $"0{s % 60}" : $"{s % 60}";
                Min = s / 60 < 10 ? $"0{s / 60}" : $"{s / 60}";
                
                //Timer = $"00:{Min}:{Sec}";
                Timer = $"{Min}:{Sec}";
            }
            else
            {
                string Sec = "", Min = "", Hour = "";
                Sec = s % 60 < 10 ? $"0{s % 60}" : $"{s % 60}";
                Min = (s / 60) % 60 < 10 ? $"0{(s / 60) % 60}" : $"{(s / 60) % 60}";
                Hour = s / 3600 < 10 ? $"0{s / 3600}" : $"{s / 3600}";
                Timer = $"{Hour}:{Min}:{Sec}";
            }
            return Timer;
        }

    }
}
