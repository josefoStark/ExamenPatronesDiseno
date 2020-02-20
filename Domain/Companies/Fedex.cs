using BussinesLogic;

namespace Domain
{
    public class Fedex : ICompany
    {
        public ITransport GetTransport(ITransportFactory transportFactory)
        {
            return transportFactory.GetInstance();
        }


        public double ProfitMargin()
        {
            return 0.5;
        }

        public string GetName()
        {
            return "Fedex";
        }
    }
}
