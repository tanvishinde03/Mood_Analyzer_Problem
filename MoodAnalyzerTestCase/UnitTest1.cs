using Mood_Analyzer_Problem;

namespace MoodAnalyzerTestCase
{
    public class Tests
    {
        MoodAnalyzer analyzemood = new MoodAnalyzer();

        [Test]
        public void SadMood_WhenAnalyse_ShouldReturnSad()
        {
            string result = analyzemood.AnalyseMood("I am in sad mood");
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void HappyMood_WhenAnalyse_ShouldReturnSad()
        {
            string result = analyzemood.AnalyseMood("I am in happy mood");
            Assert.AreEqual(result, "happy");
        }
    }
}
