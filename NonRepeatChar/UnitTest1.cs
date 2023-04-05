using Utility;

namespace NonRepeatChar
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("giridhar software", false, 'g')]
        [TestCase("reserved", false, 's')]
        [TestCase("papa", true, 'a')]

        public void TestMultipleScenarios(string InputString, bool expectedOutcome, char expectedLetter)
        {


            var found = NonRepChar.FindNonRepetitiveCharachers(InputString);
            //assert
            Assert.AreEqual(expectedOutcome, found.Item1, $"Expected response is {expectedOutcome} but got {found.Item1} for {InputString}");
            Assert.AreEqual(expectedLetter, found.Item2, $"Expected response is {expectedLetter} but got {found.Item2} for {InputString}");

        }



    }
}