namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "science":
                    Console.WriteLine("Science is a cool subject!");
                    break;

                case "band":
                    Console.WriteLine("Band is the BEST subject!!");
                    break;

                case "history":
                    Console.WriteLine("History is so important to our future!");
                    break;

                case "lunch":
                    Console.WriteLine("The yummiest subject in school!");
                    break;

                default:
                    Console.WriteLine($"Oh wow! I havn't taken that subject before. {subject} sounds fun!");
                    break;
            }

        }
    }
}