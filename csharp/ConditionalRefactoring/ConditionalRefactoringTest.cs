using FluentAssertions;
using Xunit;

namespace ConditionalRefactoring
{
    public class ConditionalRefactoringTest
    {
        [Theory]
        [InlineData(3, 4)]
        [InlineData(5, 3)]
        [InlineData(1, 3)]
        [InlineData(4, 3)]
        public void Invert(int actual, int expected)
        {
            ConditionalRefactoring.Invert(actual).Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(7, 10)]
        [InlineData(29, 30)]
        [InlineData(30, 0)]
        public void RedundantElse(int actual, int expected)
        {
            ConditionalRefactoring.RedundantElse(actual).Should().Be(expected);
        }

        [Fact]
        public void DeMorgan()
        {
            ConditionalRefactoring.DeMorgan(5).Should().BeTrue();
            ConditionalRefactoring.DeMorgan(7).Should().BeTrue();

            ConditionalRefactoring.DeMorgan(4).Should().BeFalse();
            ConditionalRefactoring.DeMorgan(8).Should().BeFalse();
        }

        [Theory]
        [InlineData(4, 3, 0)]
        [InlineData(7, 3, 0)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 7)]
        [InlineData(3, 11, 0)]
        public void Join_AND(int x, int y, int expected)
        {
            ConditionalRefactoring.Join_AND(x, y).Should().Be(expected);
        }

        [Theory]
        [InlineData(4, 3, 0)]
        [InlineData(7, 3, 0)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 7)]
        [InlineData(3, 11, 0)]
        public void Split_AND(int x, int y, int expected)
        {
            ConditionalRefactoring.Split_AND(x, y).Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 3, true)]
        [InlineData(3, 6, true)]
        [InlineData(-1, 3, true)]
        [InlineData(-1, 5, false)]
        [InlineData(-1, 10, true)]
        public void Split_OR(int x, int y, bool expected)
        {
            ConditionalRefactoring.Split_OR(x, y).Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 3, true)]
        [InlineData(3, 6, true)]
        [InlineData(-1, 3, true)]
        [InlineData(-1, 5, false)]
        [InlineData(-1, 10, true)]
        public void Join_OR(int x, int y, bool expected)
        {
            ConditionalRefactoring.Join_OR(x, y).Should().Be(expected);
        }

        [Theory]
        [InlineData(4, 3, 36)]
        [InlineData(7, 3, 63)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 0)]
        public void Split_Statements(int x, int y, int expected)
        {
            ConditionalRefactoring.Split_Statements(x, y).Should().Be(expected);
        }

        [Theory]
        [InlineData(4, 3, 36)]
        [InlineData(7, 3, 63)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 0)]
        public void Join_Statements(int x, int y, int expected)
        {
            ConditionalRefactoring.Join_Statements(x, y).Should().Be(expected);
        }

        [Theory]
        [InlineData("foo", "world", 0)]
        [InlineData("foo", "bar", 1)]
        [InlineData("bar", "world", 2)]
        [InlineData("hello", "bar", 3)]
        [InlineData("hello", "foo", 4)]
        [InlineData("hello", "world", 5)]
        [InlineData("bar", "foo", 6)]
        public void Normalize(string s1, string s2, int expected)
        {
            ConditionalRefactoring.Normalize(s1, s2).Should().Be(expected);
        }
    }
}