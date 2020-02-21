using BussinesLogic;

namespace Domain
{
    public class Fedex : ICompany
    {
        public ITransport GetTransport(ITransportFactory transportFactory)
        {
            if (transportFactory == null) return null;
            if (transportFactory.GetType() == typeof(ShipFactory))
                transportFactory.GetInstance();

            return null;
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
