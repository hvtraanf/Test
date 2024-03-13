public class TestClass
{
    // Class members go here
    string Name;
    int Age;
    public TestClass(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public override string ToString()
    {
        return "Name: " + Name + ", Age: " + Age;
    }
}