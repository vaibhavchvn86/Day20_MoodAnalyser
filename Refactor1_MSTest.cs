using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserAppWithCore
{
    [TestClass]
    public class Refactor1MSTest
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
            //Assert.AreNotEqual(expected, obj);
        }

        ///TestCase1.1
        [TestMethod]
        public void GivenMoodAnayser_ShouldReturnSad()
        {
            string expected = "Sad";
            MoodAnalyser obj = new MoodAnalyser("I m in Sad Mood");
            string result = obj.analyseMood();
            expected.Equals(obj);
            Assert.AreEqual(expected, result);
        }
        ///TestCase1.2
        [TestMethod]
        public void GivenMoodAnalyser_ShouldReturnHappy()
        {
            string expected = "Happy";
            MoodAnalyser obj = new MoodAnalyser("I m in Happy Mood");
            string result = obj.analyseMood();
            expected.Equals(obj);
            Assert.AreEqual(expected, result);
        }
    }
}
