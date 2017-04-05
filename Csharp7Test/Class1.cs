using Xunit;
using Moq;
using Csharp6Lib;

namespace Csharp7Test
{
    public class TestClass
    {
        [Fact]
        public void Test()
        {
            var mock = new Mock<Child>();
            var parent = new Parent();
            if (parent is Child child)
            {
                var tuple = (1, 2);
            }
        }
    }
}