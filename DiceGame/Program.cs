using UserInteraction;
using DiceGame;

internal class Program
{

   public static void Main(string[] args)
    {
        
        // Generate Dice Number
        GenerateDiceNumber GeneratedDiceNumber = new GenerateDiceNumber();

        var userInput = "";
        var validityOfUserInput = false;
        var guessCount = 0;

        do
        {

            DisplayNumber.ShowPrompt();

            // Get user's input
            userInput = Console.ReadLine();
            VerifyingUserInput UserInput = new VerifyingUserInput();
            validityOfUserInput = UserInput.CheckUserInputType(userInput);

            if (validityOfUserInput == true){

                if (Int32.Parse(userInput) != GeneratedDiceNumber.DiceNumber)
                {
                    guessCount++;
                    Console.WriteLine($"Wrong Number: {3 - guessCount} chances left");
                 }
            }

            if(guessCount >= 3)
            {
                Console.WriteLine("You lost the game");
                Console.ReadKey();
                break;
            }

        } while (validityOfUserInput == false || Int32.Parse(userInput) != GeneratedDiceNumber.DiceNumber);

        if(Int32.Parse(userInput) == GeneratedDiceNumber.DiceNumber)
        {
            Console.WriteLine("You won the game");
            Console.ReadKey();
        }
    }




}