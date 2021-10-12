using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_MoodAnalyzer
{
    [TestClass]
    public class UC3_InformInvalidMood
    {
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser();
            string result = obj.analyseMood();
            Assert.AreNotEqual("Empty", result);
        }

        ///TestCase3.1
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnNull()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string result = obj.analyseMood();
            Assert.AreEqual("Mood should not be null", result);
        }


        ///TestCase3.2
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnEmptyMood()
        {
            MoodAnalyser obj = new MoodAnalyser(string.Empty);
            string result = obj.analyseMood();
            Assert.AreEqual("Mood should not be empty", result);
        }
    }
}
