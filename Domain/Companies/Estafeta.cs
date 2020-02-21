using BussinesLogic;

namespace Domain
{
    public class Estafeta : ICompany
    {
        public ITransport GetTransport(ITransportFactory transportFactory)
        {
            if (transportFactory == null) return null;
            if (transportFactory.GetType() == typeof(AirplaneFactory))
                return null;

            return transportFactory.GetInstance();
        }


        public double ProfitMargin()
        {
            return 0.2;
        }

        public string GetName()
        {
            return "Estafeta";
        }
    }
}
