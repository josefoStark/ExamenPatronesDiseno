using BussinesLogic;

namespace Domain
{
    public class Dhl : ICompany
    {
        public ITransport GetTransport(ITransportFactory transportFactory)
        {
            if (transportFactory == null) return null;
            if (transportFactory.GetType() == typeof(TrainFactory))
                return null;

            return transportFactory.GetInstance();
        }


        public double ProfitMargin()
        {
            return 0.4;
        }

        public string GetName()
        {
            return "Dhl";
        }
    }
}
