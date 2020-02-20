using System;

namespace Domain
{
    public class Request
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
        public string Transport { get; set; }
        public string Company { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
