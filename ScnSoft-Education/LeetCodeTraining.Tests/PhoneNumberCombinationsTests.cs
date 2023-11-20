using LeetCodeTraining.PhoneNumberCombinations;

namespace LeetCodeTraining.Tests
{
    public class PhoneNumberCombinationsTests
    {
        [Theory]
        [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" } )]
        [InlineData("2", new string[] { "a", "b", "c" })]
        [InlineData("", new string[] { })]
        [InlineData("576", new string[] 
        {
            "jpm", "jpn", "jpo",
            "jqm", "jqn", "jqo",
            "jrm", "jrn", "jro",
            "jsm", "jsn", "jso",
            "kpm", "kpn", "kpo",
            "kqm", "kqn", "kqo",
            "krm", "krn", "kro",
            "ksm", "ksn", "kso",
            "lpm", "lpn", "lpo",
            "lqm", "lqn", "lqo",
            "lrm", "lrn", "lro",
            "lsm", "lsn", "lso"
        })]
        public void LetterCombinationsTests(string digits, string[] expectedResult)
        {
            //Arrange
            Array.Sort(expectedResult);

            //Act
            string[] result = PhoneNumberCombinationsSolution.LetterCombinations(digits).ToArray();
            Array.Sort(result);       

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
