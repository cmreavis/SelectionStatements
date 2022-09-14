int favNumber = 505;
int userInput = 0;

Console.WriteLine("I am thinking of a number between 0 and 1000. Can you guess it?");

while (userInput != favNumber)
{
    //User Input
    userInput = int.Parse(Console.ReadLine());

        if (userInput < favNumber)
        {
            Console.WriteLine($"{userInput} is too low!\n" +
                $" What is your next guess?");
    }
        if (userInput > favNumber)
        {
            Console.WriteLine($"{userInput} is too high!\n" +
                $" What is your next guess?");
        }
}
Console.WriteLine("Perfect! The correct number was " + favNumber + ".");





