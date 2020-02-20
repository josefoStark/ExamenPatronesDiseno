using System;
using CommunicationService;

namespace ExamenPatronesDiseno
{
    public class UserInterface : IUserInterface
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public string Read()
        {
            return Console.ReadLine();
        }


        public void SetTextColor(int option)
        {
            switch (option)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

        }
    }
}
