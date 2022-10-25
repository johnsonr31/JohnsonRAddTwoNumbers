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
        int num1 = 0;
        int num2 = 0;
        int sum = 0;
        bool isNumber;
        isNumber = Int32.TryParse(input1, out num1);
            if(isNumber == true)
            {
                isNumber = Int32.TryParse(input2, out num2);
                    if(isNumber == true)
                    {
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
        return sum;
    }
}
