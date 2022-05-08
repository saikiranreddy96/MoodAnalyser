using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalysis
    {
        public string message;
        //constructor
        public MoodAnalysis(string message)
        {
            this.message = message;
        }
        //method to analyse mood
        public string AnalyseMood() 
        {
            try
            {
                if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }

        }
    }
}
