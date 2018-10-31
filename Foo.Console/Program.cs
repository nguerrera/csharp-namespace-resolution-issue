namespace Foo.Console
{
    // The attribute will fail to resolve in compile-time

    [Foo.Bar.BazAttribute]
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"{typeof(Foo.Bar.BazAttribute).AssemblyQualifiedName}");
        }
    }
}
