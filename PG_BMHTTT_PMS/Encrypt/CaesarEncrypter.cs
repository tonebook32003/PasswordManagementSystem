using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_BMHTTT_PMS.Encrypt
{
    public class CaesarEncrypter
    {
        // Phương thức mã hóa một ký tự
        private char EncryptChar(char c, int k)
        {
            if (Char.IsLetter(c))
            {
                return (char)('A' + (c - 'A' + k) % 26);
            }
            return c;
        }

        // Phương thức mã hóa chuỗi
        public string EncryptMessage(string message, int key, bool isEncrypt = true)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            // Chuyển message thành chữ hoa
            message = message.ToUpper();
            
            // Nếu là giải mã thì đảo key
            if (!isEncrypt)
                key = 26 - key;

            string result = "";
            int len = message.Length;

            for (int i = 0; i < len; i++)
            {
                result += EncryptChar(message[i], key);
            }

            return result;
        }

        // Phương thức mã hóa
        public string Encrypt(string message, int key)
        {
            return EncryptMessage(message, key, true);
        }

        // Phương thức giải mã
        public string Decrypt(string message, int key)
        {
            return EncryptMessage(message, key, false);
        }
    }
}
