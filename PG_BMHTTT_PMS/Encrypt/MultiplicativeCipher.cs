using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_BMHTTT_PMS.Encrypt
{
    public class MultiplicativeCipher
    {
        // Mảng các số khóa hợp lệ (các số nguyên tố cùng nhau với 26)
        private readonly int[] validKeys = { 1, 3, 5, 7, 11, 17, 19, 23, 25 };

        // Kiểm tra khóa có hợp lệ không
        public bool IsValidKey(int key)
        {
            return validKeys.Contains(key);
        }

        // Tìm modular multiplicative inverse của a modulo m
        private int ModInverse(int a, int m)
        {
            for (int x = 1; x < m; x++)
            {
                if (((a % m) * (x % m)) % m == 1)
                    return x;
            }
            return 1;
        }

        // Phương thức mã hóa một ký tự
        private char EncryptChar(char c, int k)
        {
            if (Char.IsLetter(c))
            {
                return (char)('A' + ((c - 'A') * k) % 26);
            }
            return c;
        }

        // Phương thức giải mã một ký tự
        private char DecryptChar(char c, int k)
        {
            if (Char.IsLetter(c))
            {
                int inverse = ModInverse(k, 26);
                return (char)('A' + ((c - 'A') * inverse) % 26);
            }
            return c;
        }

        // Phương thức mã hóa chuỗi
        public string EncryptMessage(string message, int key, bool isEncrypt = true)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            if (!IsValidKey(key))
                throw new ArgumentException("Invalid key for multiplicative cipher. Key must be coprime with 26.");

            // Chuyển message thành chữ hoa
            message = message.ToUpper();

            string result = "";
            int len = message.Length;

            for (int i = 0; i < len; i++)
            {
                result += isEncrypt ? 
                    EncryptChar(message[i], key) : 
                    DecryptChar(message[i], key);
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
