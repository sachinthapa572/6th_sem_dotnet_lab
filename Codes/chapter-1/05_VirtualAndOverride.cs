using System;
namespace _05VirtualAndOverride
{

    class BaseClass
    {
        // use of the virtual keyword
        public virtual void OverrideExample()
        {
            Console.WriteLine("BaseClass OverrideExample");
        }

        public void HideExample()
        {
            Console.WriteLine("BaseClass HideExample");
        }
    }

    class DerivedClass : BaseClass
    {
        // use of the override keyword
        public override void OverrideExample()
        {
            Console.WriteLine("DerivedClass OverrideExample");
        }

        // use of the new Keyword
        public new void HideExample()
        {
            Console.WriteLine("DerivedClass HideExample");
        }
    }

    public class PolymorphismDemo
    {
        public static void RunProgram()
        {
            DerivedClass obj = new DerivedClass();

            obj.OverrideExample();
            obj.HideExample();
        }
    }
}