using Domain;

namespace BussinesLogic
{
    public class AirplaneFactory : ITransportFactory
    {
        public ITransport GetInstance()
        {
            return new Airplane();
        }
    }
}
