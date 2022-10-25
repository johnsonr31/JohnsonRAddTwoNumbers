// Richard Johnson
// 10-25-22
// This API will take the numbers the user puts in the URL and add them together, before printing the sum to the player
// Peer Review: 

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRAddTwoNumbers.Controllers;

[ApiController]
[Route("[controller]")]
public class AddTwoNumbersController : ControllerBase
{
    [HttpGet]
    [Route("Adding/{input1}/{input2}")]

    public int AddingNumbers(string input1, string input2)
    {
        // This is where the variables are declared
        int num1 = 0;
        int num2 = 0;
        int sum = 0;
        bool isNumber;
        // This will take the first number the user puts in the URL and save it as a string, which will be converted to an int
        isNumber = Int32.TryParse(input1, out num1);
            if(isNumber == true)
            {
                // If the input was a valid number that could be converted to an int, the program will do the same with the second number
                isNumber = Int32.TryParse(input2, out num2);
                    if(isNumber == true)
                    {
                        // If both numbers are confirmed valid, the program will add them both together and save the sum as an int
                        sum = num1 + num2;
                    }
                    else
                    {
                        sum = 000;
                    }
            }
            else
            {
                sum = 000;
            }
        // After the sum is saved as an int, the program will return the sum to the user
        return sum;
    }
}
