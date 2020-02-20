using Domain;

namespace BussinesLogic
{
    public class ShipFactory : ITransportFactory
    {
        public ITransport GetInstance()
        {
            return new Ship();
        }
    }
}
