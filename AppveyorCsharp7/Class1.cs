using Csharp6Lib;
using Xunit;

namespace AppveyorCsharp7
{
    public class TestClass
    {
        [Fact]
        public void Test()
        {
            var parent = new Parent();
            if (parent is Child child)
            {

            }
        }
    }
}
