namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + "is less than nine";
            //}
            //else
            //{
            //    response = answer + "is greater than or equal to nine";

            //}

            string response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine"; 
            Console.WriteLine (response);

        }
    }
}
