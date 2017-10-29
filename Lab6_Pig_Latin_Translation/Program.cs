using System;

namespace Lab6_Pig_Latin_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for a word
            Console.WriteLine("||Welcome to the Pig Latin Translator!||");
            do
            {
                Console.WriteLine("\nPlease enter a word or phrase to translate into Pig Latin:\n");

                // trim the extra spaces and split the word into substrings from the ' ' char

                string word = Console.ReadLine().ToLower().Trim();

                string finalTranslation = null; //final translation declared to be filled with words

                if (!string.IsNullOrEmpty(word))  // test for empty input
                {
                    string[] wordsSplit = word.Split(' ');

                    Console.WriteLine("\nTranslating...\n");

                    for (int i = 0; i < wordsSplit.Length; i++)
                    {
                        string translation = wordsSplit[i];

                        //find if it contains numbers or punctuation
                        char[] punctuation = "123456789!@#$%^&*()_+".ToCharArray();

                        bool containsPunctuation = translation.LastIndexOfAny(punctuation) >= 0;

                        int firstVowel = FindFirstVowel(translation);

                        if (!containsPunctuation)
                        {
                            if (firstVowel == 0 || firstVowel == -1)
                            {
                                translation += "way ";
                                finalTranslation += translation;

                            }
                            else
                            {
                                //swapping leading consonants onto the back
                                translation = translation.Substring(firstVowel) + translation.ToLower().Substring(0, firstVowel) + "ay ";

                                finalTranslation += translation;
                            }
                        }
                        else
                            finalTranslation += translation;
                        //writes words with nums & symbols that don't need translating
                    }
                    Console.WriteLine(finalTranslation);
                }
                else
                {
                    Console.WriteLine("You didn't enter a word to translate...");
                }
                Console.WriteLine("\nWould you like to try to translate another word or phrase (Y/N)?");

                // ask if they want to run again
            } while (Console.ReadLine().ToLower()[0] == 'y');
        }

        private static int FindFirstVowel(string word)
        {
            int vowelPosition = -1;
            for (int i = 0; i < word.Length && vowelPosition < 0; i++)
            {
                char vowel = word[i];

                if (vowel == 'a' || vowel == 'e' || vowel == 'o' || vowel == 'u' || vowel == 'i')
                {
                    vowelPosition = i;
                }
            }

            return vowelPosition;
        }
    }
}
