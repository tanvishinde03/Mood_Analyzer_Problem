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
        public void HappyMood_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyzer checkMood = new MoodAnalyzer("I am in Happy mood");
            string result = checkMood.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzer checkmood = new MoodAnalyzer(null);
            string result = checkmood.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}

