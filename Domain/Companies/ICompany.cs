using BussinesLogic;

namespace Domain
{
    public interface ICompany
    {

        ITransport GetTransport(ITransportFactory transportFactory);

        double ProfitMargin();

        string GetName();
    }
}
