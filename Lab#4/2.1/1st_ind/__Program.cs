using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_ind
{
    class Program
    {
        static int GetIndex(char n)
        {
            n = Char.ToUpper(n);
            return n;
        }
        static char EncryptCeaser(int index, int shift)
        {
            int new_char = index + shift;
            if (new_char > 1071)
            {
                return (char)(new_char - 32);
            }
            else if (new_char > 90 && new_char < 500)
            {
                return (char)(new_char - 26);
            }
            else return (char)new_char;
            
        }
        static char DecryptCeaser(int index, int shift)
        {
            int new_char = index - shift;
            if (new_char < 1040 && new_char > 500)
            {
                return (char)(new_char + 32);
            }
            else if (new_char < 65)
            {
                return (char)(new_char + 26);
            }
            else return (char)new_char;
        }
        static void Main(string[] args)
        {
            //Caesar's code______________________________________________________________________________________________________
            Console.Write("Enter the number of positions to shift:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the text to encrypt:");
            string plain_text = Console.ReadLine();

            if (plain_text.Contains("Ё")|| plain_text.Contains("ё"))
            {
                plain_text = plain_text.Replace("Ё", "Е");
                plain_text = plain_text.Replace("ё", "е");
            }

            StringBuilder sb_cipher_text = new StringBuilder();
            for (int i = 0; i < plain_text.Length; i++)
            {
                sb_cipher_text.Append(EncryptCeaser(GetIndex(plain_text[i]), k));
            }
            string cipher_text = sb_cipher_text.ToString();


            sb_cipher_text = sb_cipher_text.Clear();
            for (int i = 0; i < plain_text.Length; i++)
            {
                sb_cipher_text.Append(DecryptCeaser(GetIndex(cipher_text[i]), k));
            }
            string decrypted_text = sb_cipher_text.ToString();


            Console.WriteLine(cipher_text);
            Console.WriteLine(decrypted_text);
            Console.ReadKey();
        }
    }
}
