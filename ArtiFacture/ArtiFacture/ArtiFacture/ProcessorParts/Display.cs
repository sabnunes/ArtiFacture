using System;
namespace ARTIFACTURE
{
    class Display
    {
        // Parameter-less Constructor
        public Display()
        {

        }
        //  Welcome message
        public void WelcomeMessage()
        {
            Console.WriteLine(@"

 █████  ██████  ████████ ██ ███████  █████   ██████ ████████ ██    ██ ██████  ███████ 
██   ██ ██   ██    ██    ██ ██      ██   ██ ██         ██    ██    ██ ██   ██ ██      
███████ ██████     ██    ██ █████   ███████ ██         ██    ██    ██ ██████  █████   
██   ██ ██   ██    ██    ██ ██      ██   ██ ██         ██    ██    ██ ██   ██ ██      
██   ██ ██   ██    ██    ██ ██      ██   ██  ██████    ██     ██████  ██   ██ ███████ 

Welcome to ARTIFACTURE, where you can purchase CG art with almost ZERO effort!");
        }
        // Menu display
        public void DisplayMethod()
        {
            Console.Write(@"
.-----.-------------------.
|  #  |      Action       |
|-----|-------------------|
|  1  |  Insert $ Bills   |
|  2  |  Select CG Art    |
|  3  |  Request Change   |
|  4  |  Quit             |
'-----'-------------------'
"
);

        }
        // Overload for product display
        public void DisplayMethod(Item[,] products)
        {
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {   if (products[i, j] != null)
                    {
                        Console.Write("{0}{1}.  {2} (${3}) \t", (i + 1), (j + 1), products[i, j].ItemName, products[i, j].Price);
                    }
                    else Console.Write("------Empty-----\t");
                }
                Console.WriteLine(); 
            }
        }

        // Overloaded display passed message method
        public void DisplayMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayMethod(string message, int intInput1)
        {
            Console.WriteLine(message, intInput1);
        }
        public void DisplayMethod(string message, string strInput1)
        {
            Console.WriteLine(message, strInput1);
        }
    }
}