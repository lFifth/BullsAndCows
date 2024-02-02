using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class Game1
    {
        Random random = new Random();
        Words words = new Words();
        public string[] wordList;
        public string rightWord;
        public string Field1;
        public string Field2;
        public Game1()
        {
            wordList = new string[8];
            int r;
            for (int i = 0; i < 8; i++)
            {
            A:
                r = random.Next(words.words.Length);
                if (Array.IndexOf(wordList, words.words[r]) == -1)
                    wordList[i] = words.words[r];
                else { goto A; }
            }
            rightWord = wordList[random.Next(0,8)];
            Field1 = Field(0);
            Field2 = Field(4);
        }
        private string Field(int value)
        {
            int r = random.Next(0, 3);
            string Field = "";
            for (int i = 0, j = value; i < 12; i++)
            {
                if ((i + r) % 3 == 0)
                {
                    Field += $"{Rand(wordList[j])}\n";
                    j++;
                    continue;
                }
                Field += $"{Rand()}\n";
            }
            return Field;
        }
        public string Rand()
        {
            string s = "";
            for (int i = 0; i < 12; i++)
            {
                s += words.symbol[random.Next(words.symbol.Length)];
            }
            return $"{words.a[random.Next(words.a.Length)]} {s}";
        }
        public string Rand(string word)
        {
            string s = "";
            int j = random.Next(0, 6);
            for (int i = 0; i < j; i++)
            {
                s += words.symbol[random.Next(words.symbol.Length)];
            }
            s += word;
            for (int i = j+5; i < 12; i++)
            {
                s += words.symbol[random.Next(words.symbol.Length)];
            }
            return $"{words.a[random.Next(words.a.Length)]} {s}";
        }
        public string BullsAndCows(string word)
        {
            int A = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rightWord[i] == word[i])
                    A++;
            }
            int B = 0;
            char[] rightWordCharArr = rightWord.ToCharArray();
            char[] wordCharArr = word.ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (rightWordCharArr[i] == wordCharArr[j] && (rightWordCharArr[i] != ' ' && wordCharArr[j] != ' '))
                    {
                        B++;
                        rightWordCharArr[i] = ' ';
                        wordCharArr[j] = ' ';
                        goto Continue;
                    }
                }
            Continue:;
            }
            rightWordCharArr = null;
            wordCharArr = null;
            return $"A{A}B{B-A}";
        }
    }
}
