using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            InitDictionary();
            ReplaceTextInFile(@"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI1.txt", @"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI2.txt", "u05d0", "א");
            
        }

        private static Dictionary<string, string> _myDictionary = new Dictionary<string, string>();

        private static void InitDictionary()
        {
            _myDictionary.Add("u05d0", "א");
            _myDictionary.Add("u05d1", "ב");
            _myDictionary.Add("u05d2", "ג");
            _myDictionary.Add("u05d3", "ד");
            _myDictionary.Add("u05d4", "ה");
            _myDictionary.Add("u05d5", "ו");
            _myDictionary.Add("u05d6", "ז");
            _myDictionary.Add("u05d7", "ח");
            _myDictionary.Add("u05d8", "ט");
            _myDictionary.Add("u05d9", "י");
            _myDictionary.Add("u05da", "ך");
            _myDictionary.Add("u05db", "כ");
            _myDictionary.Add("u05dc", "ל");
            _myDictionary.Add("u05dd", "ם");
            _myDictionary.Add("u05de", "מ");
            _myDictionary.Add("u05df", "ן");
            _myDictionary.Add("u05e0", "נ");
            _myDictionary.Add("u05e1", "ס");
            _myDictionary.Add("u05e2", "ע");
            _myDictionary.Add("u05e3", "ף");
            _myDictionary.Add("u05e4", "פ");
            _myDictionary.Add("u05e5", "ץ");
            _myDictionary.Add("u05e6", "צ");
            _myDictionary.Add("u05e7", "ק");
            _myDictionary.Add("u05e8", "ר");
            _myDictionary.Add("u05e9", "ש");
            _myDictionary.Add("u05ea", "ת");

        }

        private static void ReplaceTextInFile(string originalFile, string outputFile, string searchTerm, string replaceTerm)
        {
            string tempLineValue;
            using (FileStream inputStream = File.OpenRead(originalFile))
            {
                using (StreamReader inputReader = new StreamReader(inputStream))
                {
                    using (StreamWriter outputWriter = File.AppendText(outputFile))
                    {
                        while (null != (tempLineValue = inputReader.ReadLine()))
                        {
                            outputWriter.WriteLine(tempLineValue.Replace(searchTerm, replaceTerm));
                        }
                    }
                }
            }
        }
    }    
}

        
