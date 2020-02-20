using System;

namespace BussinesLogic
{
    public class IncorrectTransportMessage : ISubscriber
    {
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
