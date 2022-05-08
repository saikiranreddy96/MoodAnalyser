using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class CustomException : Exception
    {
        public ExceptionType exceptionType;

        //Enum to differentiate mood analysis errors
        public enum ExceptionType
        {
            NULL_MOOD_EXCEPTION,
            EMPTY_MOOD_EXCEPTION
        }
        //Constructor to initialize ExceptionTypes
        public CustomException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
