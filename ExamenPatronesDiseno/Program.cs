using System;
using System.IO;

namespace ExamenPatronesDiseno
{
    class Program
    {
        static void Main()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string pathFile = Path.Combine(currentDirectory, "Data", "Aplicacion.txt");

            TextReaderService reader = new TextReaderService(pathFile);
            var request = reader.ListRequests();
            ConsoleKeyInfo keyInfo;
            do
            {
                UserInterface userInterface = new UserInterface();

                userInterface.SetTextColor(0);

                foreach (var item in request)
                {
                    new Client().Main(userInterface, item);
                }


                userInterface.SetTextColor(0);
                userInterface.Display("¿Terminar el programa? Y/N");

                keyInfo = Console.ReadKey();

            } while (keyInfo.Key != ConsoleKey.Y);
        }
    }
}
