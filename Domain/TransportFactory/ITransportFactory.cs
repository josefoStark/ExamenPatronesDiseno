using Domain;

namespace BussinesLogic
{
    public interface ITransportFactory
    {
        ITransport GetInstance();
    }
}
