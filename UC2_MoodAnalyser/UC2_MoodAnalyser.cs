using System;

namespace MoodAnalyserAppWithCore
{
    public class UC2_MoodAnalyser
    {
        private string message;
        public UC2_MoodAnalyser(string message)
        {
            this.message = message;
        }
        public UC2_MoodAnalyser()
        {
        }
        public string analyseMood()
        {
            //"null"==""
            // string s = null;
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException e)
            {
                return e.Message;
            }
        }
    }
}
