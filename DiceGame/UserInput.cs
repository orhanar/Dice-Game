
namespace UserInteraction
{
    public class VerifyingUserInput
    {
        public static string? UserInput { get; set; }

        public bool CheckUserInputType(string UserInput)
        {
            int value;
            if (int.TryParse(UserInput, out value)) {

                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Input");
                return false;
            }
        }
    }
}
