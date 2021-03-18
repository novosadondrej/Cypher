using System;

namespace Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte klíč: ");
            string key = Console.ReadLine();
            Console.Write("Zadejte co chcete zašifrovat: ");
            string txt = Console.ReadLine();

            int dataLen = txt.Length;
            char[] output = new char[dataLen];
            for (int i = 0; i < dataLen; i++)
            {
                output[i] = (char)(txt[i] ^ key[i % key.Length]);
            }
            Console.WriteLine(output);

            Console.Write("Pro odšifrování zadejte znova klíč: ");
            string keyV2 = Console.ReadLine();
            char[] outputV2 = new char[dataLen];
            for (int i = 0; i < dataLen; i++)
            {
                outputV2[i] = (char)(output[i] ^ keyV2[i % key.Length]);
            }
            Console.WriteLine(outputV2);
        }
    }
}
