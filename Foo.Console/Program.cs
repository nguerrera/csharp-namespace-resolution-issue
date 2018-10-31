namespace Foo.Console
{
    extern alias FooBar;
    using BazAttribute = FooBar::Foo.Bar.BazAttribute;

    [BazAttribute]
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"{typeof(BazAttribute).AssemblyQualifiedName}");
        }
    }
}
