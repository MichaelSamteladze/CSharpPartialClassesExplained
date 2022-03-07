namespace CSharpPartialClassesExplained
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var PartialInstance = new PartialClassSample();
            PartialInstance.Foo();
            PartialInstance.Bar();
        }
    }
}
