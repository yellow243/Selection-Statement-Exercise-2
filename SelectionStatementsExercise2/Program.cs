namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your favorite subject in school?");
            var favSubject = Console.ReadLine();
            switch (favSubject) 
            {
                case "Math":
                    Console.WriteLine("Math is too hard for me, who needs numbers AND letters in the SAME problem??");
                    break;
                case "Science":
                    Console.WriteLine("Science is a lot of fun! I prefered Physics personally over Biology or Chemistry");
                    break;
                case "English":
                    Console.WriteLine("I hope you had a good teacher because I didn't lol.");
                    break;
                case "History":
                    Console.WriteLine("History was fun except I had a British teacher who taught AMERICAN history and he didnt like going over when America threw the tea in the harbor XD");
                    break;
                case "Art":
                    Console.WriteLine("I was HORRIBLE at art, couldnt even draw a stick figure 'properly' according to my teacher smh");
                    break;
                    
                    default: Console.WriteLine("Hmmm interesting choice. Not many people say that one!");
                    break;
                    

            }
        }
    }
}