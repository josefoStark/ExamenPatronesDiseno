using System;
using System.Collections.Generic;
using System.IO;
using Domain;

namespace ExamenPatronesDiseno
{
    public class TextReaderService
    {
        private static string _pathFile;

        public readonly Func<string[]> Lines = () => File.ReadAllLines(_pathFile);

        public TextReaderService(string pathFile)
        {
            _pathFile = pathFile;
        }

        public List<Request> ListRequests()
        {
            List<Request> result = new List<Request>();
            string[] lstLines = Lines();
            foreach (var item in lstLines)
            {
                result.Add(GetRequest(item));
            }

            return result;
        }

        public Request GetRequest(string line)
        {
            string[] datos = line.Split(Convert.ToChar(","));

            Request request = new Request
            {
                Origin = datos[0],
                
                Destination = datos[1],
                Distance = Convert.ToDouble(datos[2]),
                Company = datos[3],
                Transport = datos[4],
                OrderDate = DateTime.Parse(datos[5]),
            };

            return request;
        }
    }
}
