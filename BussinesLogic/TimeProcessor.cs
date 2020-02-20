using System;
using Domain;

namespace BussinesLogic
{
    public class TimeProcessor
    {
        private ITransport _transport;

        private TimeSpan _estimatedTime;

        public void SetTransport(ITransport transport)
        {
            _transport = transport;
        }

        public void SetTime(double distance)
        {
            double result = distance / _transport.Speed();
            _estimatedTime = new TimeSpan(1, 1, 1);
           
        }

        public DateTime GetDeliveryDate(DateTime init)
        {
            var result = init.Add(_estimatedTime);
            return result;
        }
    }
}
