using System;

namespace ExamenPatronesDiseno
{
    class Program
    {
        static void Main()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                UserInterface userInterface= new UserInterface();

                userInterface.SetTextColor(0);

                new Client().Main(userInterface);

                userInterface.SetTextColor(1);
                userInterface.Display("¿Terminar el programa? Y/N");
                
                keyInfo = Console.ReadKey();

            } while (keyInfo.Key != ConsoleKey.Y);
        }
    }
}
