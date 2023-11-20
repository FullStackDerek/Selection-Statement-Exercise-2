namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school? Besides P.E.");
            var favSub = Console.ReadLine().ToLower();

            Console.WriteLine(RelayTheirFaveSubject(favSub));
        }

        public static string RelayTheirFaveSubject(string favSub) 
        {
            switch (favSub)
            {
                case "history":
                    return "Yuck! Who cares about the past?!";
                case "english":
                    return "Lame... Why do we have to study it when we already speak it??";
                case "math":
                    return "Ew. God made calculators for a reason...";
                case "science":
                    return "Unless we are making things explode, its a waste of time!";
                case "pe":
                    return "I specifically said BESIDES PE! Maybe you need a reading class LOL";
                default:
                    return "I guess if you're into that.. to each their own";
            }
        }
    }
}