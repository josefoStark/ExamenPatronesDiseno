using System;

namespace Domain
{
    public class Response
    {
        public double Cost { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public string Company { get; set; }

        public DateTime DeliveredDate { get; set; }

        public string Transport { get; set; }
    }
}
