string[,] userChoice = new string[,]
{
    {"1", "2", "3" },
    {"4", "5", "6" },
    {"7", "8", "9" }
};



Console.WriteLine("Welcome to Tic-Tac-Toe");   
SetField();
string newValue;
while (!WinCheck(userChoice))
{
    Console.WriteLine("Player 1 choose a position 1-9");
    int position = int.Parse(Console.ReadLine()) -1;
    int rowIndex = position / 3;
    int columnIndex = position % 3;
    Console.WriteLine("Please choose 0 or X");
    newValue = (Console.ReadLine());
    userChoice[rowIndex, columnIndex] = newValue;
    SetField();

    Console.WriteLine("Player 2 choose a position 1-9");
    int positionTwo = int.Parse(Console.ReadLine()) - 1;
    int rowIndexTwo = position / 3;
    int columnIndexTwo = position % 3;
    Console.WriteLine("Please choose 0 or X");
    newValue = (Console.ReadLine());
    userChoice[rowIndex, columnIndex] = newValue;
    SetField();
}



 void SetField()
{
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |   {2} " , userChoice[0,0], userChoice[0,1], userChoice[0,2]);
    Console.WriteLine("_____|_____|____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |   {2} ", userChoice[1,0], userChoice[1,1], userChoice[1,2]);
    Console.WriteLine("_____|_____|____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |   {2} ", userChoice[2,0], userChoice[2,1], userChoice[2,2]);
    Console.WriteLine("_____|_____|____");
    Console.WriteLine("     |     |     ");
}

static bool WinCheck(string[,] userChoice)
{
    for (int row = 0; row < 3; row++)
    {
        if (userChoice[0, 0] == userChoice[1, 1] && userChoice[1, 1] == userChoice[2, 2] ||
            userChoice[0, 2] == userChoice[1, 1] && userChoice[1, 1] == userChoice[2, 0] ||
            userChoice[0, 0] == userChoice[1, 0] && userChoice[1, 0] == userChoice[2, 0]||
            userChoice[0, 1] == userChoice[1, 1] && userChoice[1, 1] == userChoice[2, 1]||
            userChoice[0, 2] == userChoice[1, 2] && userChoice[1, 2] == userChoice[2, 2])
        {
            return true;
        }
    }
    return false;
}
Console.ReadKey();