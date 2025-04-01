namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            int favNumber = r.Next(1,11);
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Guess my favorite number between 1 and 10");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                    {
                        Console.WriteLine("Too Low");
                    }
                    else if (response > favNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!!!");
                    }
                
               
                }
            }
        }
    }
