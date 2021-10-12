using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserAppWithCore
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        ///using e.Message in place of throw in mood analyser
        public void GivenMoodNull_ShouldThrowException()
        {
            string expected = "Object reference not set to an instance of an object.";
            UC2_MoodAnalyser obj = new UC2_MoodAnalyser(null);
            string result = obj.analyseMood();
            Assert.AreEqual(expected, result);
        }


        //TestCAse2.1
        [TestMethod]
        public void GivenMood_ShouldReturnHappy()
        {
            UC2_MoodAnalyser obj = new UC2_MoodAnalyser("null");
            string result = obj.analyseMood();
            Assert.AreEqual("Happy", result);
        }
    }
}
