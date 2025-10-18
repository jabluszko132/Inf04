namespace zad1
{
    internal class Program
    {
        public static string CaesarCypher(string txt, int key)
        {
            string res = "";
            int optimisedKey = key % 26;
            foreach (char c in txt)
            {
                if (c == ' ')
                {
                    res += ' ';
                }
                else if (c + optimisedKey < 'a')
                {
                    res += (char)('z' + 1 + optimisedKey + c - 'a');
                }else if (c + optimisedKey > 'z')
                {
                    res += (char)('a' - 1 + optimisedKey + c - 'z');
                }
                else
                {
                    res += (char)(c + optimisedKey);
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Text: ");
            string txt = Console.ReadLine()!;
            Console.WriteLine("Key: ");
            int key = int.Parse(Console.ReadLine()!);
            string res = CaesarCypher(txt, key);
            Console.WriteLine($"Cyphered with key {key}: \n{res}");
            Console.WriteLine($"Decyphered again: \n{CaesarCypher(res,-key)}");
        }
    }
}
