using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Program");
            //UC1 
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in Happy Mood");
            Console.WriteLine("Mood is: " + moodAnalysis.AnalyseMood());

            Console.ReadLine();
        }
    }
}
