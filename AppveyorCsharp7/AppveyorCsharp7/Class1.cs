namespace AppveyorCsharp7
{
    public class Class1
    {
        public void Test()
        {
            var parent = new Parent();
            if (parent is Child child)
            {

            }
        }
    }

    class Parent { }

    class Child : Parent { }
}
