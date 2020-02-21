using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_ind
{
    class Program
    {
        static string GetText()
        {
            Console.Write("Enter the text to encrypt:");
            string plain_text = Console.ReadLine();
            if (plain_text.Contains("Ё") || plain_text.Contains("ё"))
            {
                plain_text = plain_text.Replace("Ё", "Е");
                plain_text = plain_text.Replace("ё", "е");
            }
            return plain_text;
        }
        static int GetIndex(char n)
        {
            n = Char.ToUpper(n);
            return n;
        }
        static char EncryptCeaser(int index, int shift)
        {
            if (shift > 32)
            {
                shift %= 32;
            }
            int new_char = index + shift;
            if (new_char > 1071)
            {
                return (char)(1039 + new_char % 1071); //ru
            }
            else if (new_char > 90 && new_char < 500)
            {
                return (char)(64 + new_char % 90);     //en
            }
            else return (char)new_char;
        }
        static char DecryptCeaser(int index, int shift)
        {
            if (shift > 26)
            {
                shift %= 26;
            }
            int new_char = index - shift;
            if (new_char < 1040 && new_char > 500)
            {
                return (char)(1072 - 1040 % new_char); //ru
            }
            else if (new_char < 65)
            {
                return (char)(91 - 65 % new_char);     //en
            }
            else return (char)new_char;
        }
        static char EncryptVernam(int index_plain_text, int index_key)
        {
            int new_char = index_plain_text + index_key;
            //if (new_char > 1104)
            //{
            //    return (char)(1040 + ((new_char-1105)%32));
            //}
            if (new_char > 129)
            {
                return (char)(65 + (new_char - 130) % 26);
            }
            else return (char)new_char;
        }
        static char DecryptVernam(int index_cipher_text, int index_key)
        {
            int new_char = index_cipher_text - index_key; //only en
            if (new_char < 0)
            {
                new_char = 91 + new_char;
                return (char)(new_char);
            }
            return (char)(65 + new_char);
        }
        static void TrithemiusCipher()
        {
            string plain_text = GetText();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < plain_text.Length; i++)
            {
                double k_pos = Math.Pow(GetIndex(plain_text[i]) - 1040, 2);
                sb.Append(EncryptCeaser(GetIndex(plain_text[i]), (int)(k_pos)));
            }
            string cipher_text = sb.ToString();
            sb = sb.Clear();

            for (int i = 0; i < plain_text.Length; i++)
            {
                double k_pos = Math.Pow(GetIndex(plain_text[i]) - 65, 2);
                sb.Append(DecryptCeaser(GetIndex(cipher_text[i]), (int)(k_pos)));
            }
            string decrypted_text = sb.ToString();
            sb = sb.Clear();

            Console.WriteLine(cipher_text);
            Console.WriteLine(decrypted_text);
            Console.ReadKey();
        }
        static void VernamCipher()
        {
            string plain_text = GetText();
            Console.WriteLine("How to create a key: (1 - randomly) (2 - manually)");
            int k = Convert.ToInt32(Console.ReadLine());
            string key = string.Empty;
            while (k != 1 && k != 2)
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            StringBuilder sb = new StringBuilder();
            if (k == 1)
            {
                Random rnd = new Random();
                for (int i = 0; i < plain_text.Length; i++)
                {
                    sb.Append(Convert.ToChar(rnd.Next(65, 91)));
                }
                key = sb.ToString();
                sb = sb.Clear();
                Console.WriteLine(key);
            }
            else if (k == 2)
            {
                Console.Write("Enter your key:");
                key = Console.ReadLine();
                if (key.Length < plain_text.Length)
                {
                    Random rnd = new Random();
                    for (int i = 0; i < (plain_text.Length - key.Length); i++)
                    {
                        sb.Append(Convert.ToChar(rnd.Next(65, 91)));
                    }
                    key += sb.ToString();
                    sb = sb.Clear();
                    Console.WriteLine(key);
                }
            }

            for (int i = 0; i < plain_text.Length; i++)
            {
                sb.Append(EncryptVernam(GetIndex(plain_text[i]), GetIndex(key[i])));
            }
            string cipher_text = sb.ToString();
            sb = sb.Clear();

            for (int i = 0; i < plain_text.Length; i++)
            {
                sb.Append(DecryptVernam(GetIndex(cipher_text[i]), GetIndex(key[i])));
            }
            string decrypted_text = sb.ToString();
            sb = sb.Clear();

            Console.WriteLine(cipher_text);
            Console.WriteLine(decrypted_text);
            Console.ReadKey();
        }
        static void CeasarCipher()
        {
            Console.Write("Enter the number of positions to shift:");
            int k = Convert.ToInt32(Console.ReadLine());
            string plain_text = GetText();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < plain_text.Length; i++)
            {
                sb.Append(EncryptCeaser(GetIndex(plain_text[i]), k));
            }
            string cipher_text = sb.ToString();


            sb = sb.Clear();
            for (int i = 0; i < plain_text.Length; i++)
            {
                sb.Append(DecryptCeaser(GetIndex(cipher_text[i]), k));
            }
            string decrypted_text = sb.ToString();

            Console.WriteLine(cipher_text);
            Console.WriteLine(decrypted_text);
            Console.ReadKey();
            sb = sb.Clear();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Select an encryption method:\nC - Ceaser cipher\nV - Vernam cipher\nT - TrithemiusCipher");
            string method = Console.ReadLine();
            while (method != "C" && method != "T" && method != "V")
            {
                method = Console.ReadLine();
            }
            if(method == "C")
            {
                Console.Clear();
                CeasarCipher();
            }
            else if (method == "V")
            {
                Console.Clear();
                VernamCipher();
            }
            else if (method == "T")
            {
                Console.Clear();
                TrithemiusCipher();
            }
        }
    }
}
