using LeetCodeTraining.GenerateParentheses;

namespace LeetCodeTraining.Tests
{
    public class GenerateParenthesesTests
    {
        [Theory]
        [InlineData(1, new string[] { "()" })]
        [InlineData(2, new string[] { "()()", "(())" })]
        [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        [InlineData(4, new string[] { "()()()()", "(())()()", "()(())()", "()()(())",
                                      "(()())()", "((()))()", "()(()())", "()((()))",
                                      "(())(())", "(()()())", "((())())", "(()(()))",
                                      "((()()))", "(((())))" })]
        public void GenerateParenthesisTests(int n, string[] expectedResult)
        {
            //Arrange
            Array.Sort(expectedResult);

            //Act
            string[] result = GenerateParenthesesSolution.GenerateParenthesis(n).ToArray();
            Array.Sort(result);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
