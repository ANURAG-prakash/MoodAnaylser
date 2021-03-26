using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnaylserWithCore;

namespace MoodAnaylserTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "sad";
            string message = "i am in sad mood ";
            MoodAnaylser moodAnaylse = new MoodAnaylser(message);
            string mood = moodAnaylse.anaylseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}
