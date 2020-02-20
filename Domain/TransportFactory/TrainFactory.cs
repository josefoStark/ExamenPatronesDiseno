using Domain;

namespace BussinesLogic
{
    public class TrainFactory : ITransportFactory
    {
        public ITransport GetInstance()
        {
            return new Train();
        }
    }
}
