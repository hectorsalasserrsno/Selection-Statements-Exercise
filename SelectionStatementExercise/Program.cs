namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Try to guess my favorite number");
            var favnum = int.Parse(Console.ReadLine());

            var r = new Random();
            var favNumber = r.Next(1, 10);


            if (favnum < favNumber)

                Console.WriteLine("too low");

            else if (favnum > favNumber)

                Console.WriteLine(" too high");

            else
            {
                Console.WriteLine("You guess it");
                    
            }





        }
    }
}
