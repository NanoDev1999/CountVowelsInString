

using System;

class Program
{
    static void Main()
    {
        public static int CountVowels(string input)
        {
            // first we need to make a list of the vowels.
            string listOfVowelsAsString = "aeiouAEIOU";
            int countedVowels = 0;
            
            for(int i = 0; i < input.Length; i++){  // goes through string each char at a time.
                char characterToCheck = input[i];
                if(listOfVowelsAsString.Contains(characterToCheck)){
                    // we need a container to capture the number of counted vowels here.
                    countedVowels++;
                }
            }
            
            return countedVowels;

        }
    }
}







