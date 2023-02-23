using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    public class PigLatin
    {
        private String raw;      //Before conversion
        private String pigLatin; //After conversion
        public PigLatin(string raw)
        {
            this.raw = raw;
            convertPigLatin();
        }

        private void convertPigLatin()
        {
            //Splits the words to be indivudally tackled
            String[] word = this.raw.Split(' ');

            //converted words will be collected in this array, to manipulate later
            String[] converted = new String[word.Length];

            //count to keep track what point the array is at, since it will be easier to keep track of the for each words
            int count = 0;

            foreach(String w in word)
            {
                if(containsExceptions(w)) //Contains the exceptions of email address, numbers etc of that word
                {
                    converted[count++] = w;
                    continue;
                }
                if (isVowel(w[0])) //if contains a vowel to add way to the end
                {
                    converted[count++] = w + "way";
                    continue;
                }
                else
                {
                    List<char> consenant = new List<char>(); //creates list of consenant since the size cannot be known for certain
                    byte consenantCounter = 0; //keeps track of how many characters to reach first vowel to be used on substring

                    //goes through each character to determin when it hits a vowel, collecting consenants leading up to that vowel
                    foreach (Char c in w)
                    {
                        if(!isVowel(c) && c != 'y' && c != 'Y')
                        {
                            consenant.Add(c);
                            consenantCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //creates a temp string since you can't manipulate for each loop strings to remove all consenants leading up to vowel
                    string tmp = w.Substring(consenantCounter);

                    //for loop that adds the consenants to the end
                    foreach(char c in consenant)
                    {
                        tmp += c;
                    }

                    tmp += "ay";

                    converted[count++] = tmp;
                }
            }

            converted = cleanup(converted); //cleans up punctuation,  adding it to the end of the word if needed
            setPigLatin(converted); //Sets the global variable to the converted words
        }

        private void setPigLatin(string[] words)
        {
            //adds spaces at the end of each word
            foreach(string word in words)
            {
                pigLatin += word + " ";
            }

            //removes the last space added
            pigLatin = pigLatin.Substring(0, pigLatin.Length - 1);
        }

        private string[] cleanup(string[] words)
        {

            //for use in 2d array to keep track of where we are w stands for word position and c for character position
            for(int w = 0; w < words.Length; w++)
            {
                string cleanup = "";
                for(byte c = 0; c < words[w].Length; c++)
                {
                    if (isPunctuation(words[w][c])) // if character is punction then it adds that to the very end
                    {
                        cleanup = words[w].Substring(0, c) + words[w].Substring(c + 1) + words[w][c];
                        break;
                    }
                }
                if(cleanup == "") { continue; } //failsafe to not overwrite words with no punctuation 
                words[w] = cleanup;
            }
            return words;
        }
        private bool isPunctuation(char c)
        {
            //Checks for set varaibles for cleaner code writing
            return c == ',' || c == '.' || c == '"' || c == '!' || c == '?';
        }
        private bool isVowel(char c)
        {
            //checks variation of vowels for cleaner code
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool containsExceptions(string word)
        {
            //checks for exception characters, for use to make cleaner code
            foreach(char c in word)
            {
                if(c == '@' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || 
                    c == '6' || c == '7' || c == '8' || c == '9' || c == '£' || c == '$' || c == '%')
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return pigLatin;
        }


    }
}