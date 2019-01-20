using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_SimonSays
{
    public class Simon
    {
        // Laver alle bogstaver, i det givende ord, til små bogstaver
        public string Echo(string v)
        {
            return v.ToLower();
        }

        // Laver alle bogstaver, i det givende ord, til store bogstaver
        public string Shout(string v)
        {
            return v.ToUpper();
        }

        // Tager det givende ord og gentager det en gang
        public string Repeat(string v)
        {
            return v + " " + v;
        }

        // Tager det givende ord og gentager det et givende antal gange
        public string Repeat(string v1, int v2)
        {
            string repeatedText = "";
            for(int i = 0; i < v2; i++)
            {
                repeatedText += v1 + " ";
            }

            return repeatedText.TrimEnd();
        }

        // Tager det givende ord og tager et hvis antal bogstav(er) i ordet udfra det givende antal
        public string StartOfWord(string v1, int v2)
        {
            string newWord = v1.Substring(0, v2);
            return newWord;
        }

        // Tager de(t) givende ord og tager det første ord
        public string FirstWord(string v)
        {
            string[] temp = v.Split(' ');
            return temp[0];
        }
        

        public string Titleize(string v)
        {
            string[] libary = new string[] { "and", "over", "the" };
            string[] tempWord = v.Split(' ');
            string newsentence = "";

            for(int i = 0; i < tempWord.Length; i++)
            {
                if(i == 0)
                {
                    for (int k = 0; k < tempWord[0].Length; k++)
                    {
                        if (k == 0)
                        {
                            newsentence += tempWord[0].ToUpper()[0];
                        }
                        else
                        {
                            newsentence += tempWord[0][k];
                        }
                    }
                }
                else if(tempWord[i] == libary[0] || tempWord[i] == libary[1] || tempWord[i] == libary[2])
                {
                    newsentence += tempWord[i];
                }
                else
                {
                    for (int k = 0; k < tempWord[i].Length; k++)
                    {
                        if (k == 0)
                        {
                            newsentence += tempWord[i].ToUpper()[0];
                        }
                        else
                        {
                            newsentence += tempWord[i][k];
                        }
                    }
                }
                
                if (i + 1 != tempWord.Length)
                {
                    newsentence += " ";
                }
            }
            

            return newsentence;
        }
    }
}
