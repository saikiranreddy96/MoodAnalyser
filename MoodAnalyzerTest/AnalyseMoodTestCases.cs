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

        //[TestMethod]
        //[TestCategory("Null Exception")]
        //public void GivenNullMessageShouldReturnHappy()
        //{
        //    //Arrange
        //    string message = null;
        //    string expected = "HAPPY";
        //    MoodAnalysis moodAnalysis = new MoodAnalysis(message);
        //    //Assert
        //    string actual = moodAnalysis.AnalyseMood();
        //    //Act
        //    Assert.AreEqual(expected, actual);
        //}

        [TestCategory("Custom Exception")]
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            string message = null;
            string expected = "Mood should not be null";
            try
            {
                MoodAnalysis moodAnalysis = new MoodAnalysis(message);
                string actual = moodAnalysis.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException msg)
            {
                Assert.AreEqual(expected, msg.Message);
            }
        }


        [TestCategory("Custom Exception")]
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            string message = "";
            string expected = "Mood should not be empty";
            try
            {
                MoodAnalysis moodAnalysis = new MoodAnalysis(message);
                string actual = moodAnalysis.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException msg)
            {
                Assert.AreEqual(expected, msg.Message);
            }
        }
    }
}
