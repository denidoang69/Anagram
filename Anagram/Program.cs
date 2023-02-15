using System;
namespace ConsoleApp
{
    class Anagram
    {
        static void Main(string[] args)
        {
            
            string s, t;
            Console.Write("Enter first string: ");
            s = Console.ReadLine();
            Console.Write("Enter second string: ");
            t = Console.ReadLine();
            
            char[] s1 = s.ToLower().ToCharArray();
            char[] t1 = t.ToLower().ToCharArray();
            
            Array.Sort(s1);
            Array.Sort(t1);
            
            string anagram1 = new string(s1);
            string anagram2 = new string(t1);
            
            if (anagram1 == anagram2) Console.WriteLine("Anagram");
            else Console.WriteLine("Bukan Anagram");
            Console.ReadLine();
        }
    }
}