using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] input = tbEnglish.Text.Split(' ');

            for(int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case ".": case ",": case "?": case ":": case ";": case "-": case "_": case "0":
                    case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8":
                    case "9": case "@": case "#": case "$": case "%": case "^": case "&": case "*":
                        break;

                    default:
                        input[i] = GetPigLatinWord(input[i]);
                        break;
                }
            }

            if (input.Length > 0)
                tbPigLatin.Text = String.Join(" ", input);
            else
                if (tbEnglish.Text.Length > 0)
                MessageBox.Show("Unable to generate Pig Latin from your text.");
        }


        public string GetPunctuation(string input)
        {
            string puntuationMarks = ".,?!";
            string mark = "";

            foreach (char c in puntuationMarks.ToCharArray())
                if (input.Contains(c))
                    mark = c.ToString();

            return mark;
        }


        public string GetPigLatinWord(string input)
        {
            char[] inputChars = input.ToCharArray();
            string capitalLetter = "";
            string firstPart = "";
            string punctuationMark = GetPunctuation(input);
            string pigLatingString = "";

            if (inputChars[0] >= 0x65 || inputChars[0] <= 0x90)
                capitalLetter = new string(inputChars, 0, 1);

            if (punctuationMark.Length > 0)
                input = input.Replace(punctuationMark, "");

            for (int i = 0; i < input.Length; i++)
            {
                switch (input.Substring(i, 1))
                {
                    case "A": case "E": case "I": case "O": case "U":
                        if (i == 0)
                            pigLatingString = input + "yay";
                        else
                            pigLatingString = input.Substring(i) + firstPart + "ay";

                        i = input.Length;

                        break;

                    case "a": case "e": case "i": case "o": case "u":
                        if (i == 0)
                            pigLatingString = input + "yay";
                        else
                        {
                            if (capitalLetter.Length > 0) 
                            {
                                capitalLetter = input.Substring(i, 1).ToUpper();

                                if (i == input.Length - 1)
                                    pigLatingString = capitalLetter + firstPart + "ay";
                                else
                                    pigLatingString = capitalLetter + input.Substring(i + 1) + firstPart + "ay";
                            }
                            else
                            {
                                if (i == input.Length - 1)
                                    pigLatingString = input.Substring(i) + firstPart + "ay";
                                else
                                    pigLatingString = input.Substring(i + 1) + firstPart + "ay";
                            }
                        }

                        i = input.Length;

                        break;

                    default:
                        if (input.Substring(i, 1) == "y")
                        {
                            if (i == input.Length - 1)
                            {
                                if (capitalLetter.Length > 0)
                                    pigLatingString = "I" + firstPart + "ay";
                                else
                                    pigLatingString = "i" + firstPart + "ay";
                            
                                i = input.Length;
                            }
                        }
                        else
                            firstPart += input.Substring(i, 1).ToLower();

                        break;
                }
            }

            return pigLatingString + punctuationMark;
        }
    }
}
