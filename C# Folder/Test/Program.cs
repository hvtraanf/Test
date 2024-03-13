
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int age = 20;

        TestClass c = new TestClass("John", age);
        TestClass tc = new TestClass("Test", age + 5);

        Console.WriteLine(c);
        Console.WriteLine(tc);
    }
}
