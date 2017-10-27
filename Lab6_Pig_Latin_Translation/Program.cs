using System;

namespace Lab6_Pig_Latin_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for a word
            Console.WriteLine("||Welcome to the Pig Latin Translator!||\n\nPlease enter a word to translate into Pig Latin: ");

            string word = Console.ReadLine().Trim();

            int vowelPosition = -1;
            for (int i = 0; i < word.Length && vowelPosition < 0; i++)
            {
                char vowel = word.ToLower()[i];
                if (vowel == 'a' || vowel == 'e' || vowel == 'o' || vowel == 'u' || vowel == 'i')
                {
                    vowelPosition = i;
                }
            }
            Console.WriteLine(vowelPosition);

            //assignment of way in case of a leading vowel
            if (vowelPosition == 0)
            {
                word += "way";
                Console.WriteLine(word);
            }
            else
            {
                //swapping leading consonants onto the back
                string wordSwap = word.Substring(vowelPosition) + word.ToLower().Substring(0, vowelPosition) + "ay"; 

                Console.WriteLine(wordSwap);
            }
            //Display Pig Latin into the console
            //Find the first vowel
            //if vowel is in first position add "way" to ending
            //move all consonants that appear before the first vowel to the end of the word
        }
    }
}
