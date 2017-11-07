using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01Problema01
{
    public class ChangeString
    {
        public string build(string prmBase)
        {
            string Result = "";
            string AlphabetMinus = "abcdefghijklmnñopqrstuvwxyz";
            char[] alphabetMinus = AlphabetMinus.ToCharArray();
            char[] alphabetMayus = AlphabetMinus.ToUpper().ToCharArray();
            const int FirstPosition = 0;
            const int LastPosition = 26;
            int CurrentPositionOfLetter = 0;
            char[] word = prmBase.ToCharArray();

            foreach (char letter in word)
            {
                char CurrentChar = letter;

                if (char.IsLetter(CurrentChar))
                {

                    CurrentPositionOfLetter = 0;

                    if (char.IsUpper(CurrentChar))
                    {
                        CurrentPositionOfLetter = alphabetMayus.ToList().FindIndex(x => x == letter);
                    }
                    else
                    {
                        CurrentPositionOfLetter = alphabetMinus.ToList().FindIndex(x => x == letter);
                    }                    

                    if (CurrentPositionOfLetter == LastPosition)
                    {
                        CurrentPositionOfLetter = FirstPosition;
                    }
                    else
                    {
                        CurrentPositionOfLetter++;
                    }

                    if (char.IsUpper(CurrentChar))
                    {
                        CurrentChar = alphabetMayus.ToList()[CurrentPositionOfLetter];
                    }
                    else
                    {
                        CurrentChar = alphabetMinus.ToList()[CurrentPositionOfLetter];
                    }
                        
                }
               
                Result += CurrentChar;

            }

            return Result;
        }
    }
}
