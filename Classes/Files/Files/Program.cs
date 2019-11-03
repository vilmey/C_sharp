using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\TestFile");
            //File.Create(Directory.GetCurrentDirectory() + "\\TestFile" + "text.txt");
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\TestFile" + "text.txt", "This is the text inside the file.\nAnd maybe I should write a verry long word like anthropology.");
            var words = File.ReadAllText(Directory.GetCurrentDirectory() + "\\TestFile" + "text.txt").Split(" ");

            int indexOfLongestWord = 0;
            int sizeOfLongestWord = 0;
            Console.WriteLine("File content:");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > sizeOfLongestWord)
                {
                    sizeOfLongestWord = words[i].Length;
                    indexOfLongestWord = i;
                }
                
                Console.WriteLine(words[i] + " ");
            }
            
            Console.WriteLine("Number of words: [{0}].", words.Length);
            Console.WriteLine("Longest word with {0} characters is {1}.", sizeOfLongestWord, words[indexOfLongestWord]);
        }
    }
}
