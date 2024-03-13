
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int age = 20;

        TestClass c = new TestClass("John", age);

        Console.WriteLine(c);
    }
}