

namespace DiceGame
{
    public class GenerateDiceNumber
    {
        public int DiceNumber { get; init; }

       
        public GenerateDiceNumber()
        { 
            Random rnd = new Random();
            int diceNumber = rnd.Next(1, 6);
            DiceNumber = diceNumber;
        }
    }
}
