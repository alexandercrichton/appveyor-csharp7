using Csharp6Lib;
using Xunit;
using Moq;

namespace AppveyorCsharp7
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
