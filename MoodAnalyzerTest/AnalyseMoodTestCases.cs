using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class AnalyseMoodTest
    {
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void TestSadMoood()   //AAA
        {
            //Arrange
            string message = "I am in Sad Mood";
            string expected = "SAD";
            MoodAnalysis moodAnalysis = new MoodAnalysis(message);
            //Act
            string actual = moodAnalysis.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy Mood")]
        public void TestHappyMoody()   //AAA
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "HAPPY";
            MoodAnalysis moodAnalysis = new MoodAnalysis(message);
            //Act
            string actual = moodAnalysis.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
