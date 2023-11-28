
namespace SampleTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word = "this the (test)";

            var result = TextValidator.isValid(word);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}