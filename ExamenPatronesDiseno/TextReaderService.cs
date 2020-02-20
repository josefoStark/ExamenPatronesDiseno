using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationService;
using Domain;

namespace ExamenPatronesDiseno
{
    public class TextReaderService
    {
        private static string _pathFile;

        public Func<string[]> Lines = () => File.ReadAllLines(_pathFile);

        public TextReaderService(string pathFile)
        {
            _pathFile = pathFile;
        }

        public Request GetRequest()
        {
            Request request = new Request()
            {
               
            };

            return request;
        }
    }
}
