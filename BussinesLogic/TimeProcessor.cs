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
            int hour = Convert.ToInt32(distance / _transport.Speed());
            _estimatedTime = new TimeSpan(hour, 0, 0);

        }

        public DateTime GetDeliveryDate(DateTime init)
        {
            var result = init.Add(_estimatedTime);
            return result;
        }
    }
}
