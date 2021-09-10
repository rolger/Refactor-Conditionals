using FluentAssertions;
using Xunit;

namespace ConditionalRefactoring
{
    public class ConditionalRefactoringTest
    {
        [Fact]
        public void FailingTest()
        {
            "This test".Should().Be("failing");
        }
    }
}