using Mood_Analyzer_Problem;

namespace MoodAnalyzerTestCase
{
    public class Tests
    {

        [Test]
        public void SadMood_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyzer checkMood = new MoodAnalyzer("I am in sad mood");
            string result = checkMood.AnalyseMood();
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void HappyMood_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyzer checkMood = new MoodAnalyzer("I am in happy mood");
            string result = checkMood.AnalyseMood();
            Assert.AreEqual(result, "happy");
        }
    }
}

