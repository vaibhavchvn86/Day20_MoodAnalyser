using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;
using MoodAnalyzerMSTest;

namespace Day20_MoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("Happy");
            string result = obj.analyseMood();
            Assert.AreEqual("Happy", result);
        }
        [TestMethod]
        public void GivenMood_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("Sad");
            string result = obj.analyseMood();
            Assert.AreEqual("Sad", result);
        }

        [TestMethod]
        ///TestCase1.1
        public void GivenMood_ShouldReturnSAD()
        {
            string Expected = "Sad";
            MoodAnalyser obj = new MoodAnalyser("I m in Sad Mood");
            string result = obj.analyseMood();
            Expected.Equals(obj);
            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        ///TestCase1.2
        public void GivenMood_ShouldReturnHAPPY()
        {
            string Expected = "Happy";
            MoodAnalyser obj = new MoodAnalyser("I m in Happy Mood");
            string result = obj.analyseMood();
            Expected.Equals(obj);
            Assert.AreEqual(Expected, result);
        }
    }
}
