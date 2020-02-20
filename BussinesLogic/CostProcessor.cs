using Domain;

namespace BussinesLogic
{
    public class CostProcessor
    {
        private readonly ICompany _company;
        private ITransport _transport;

        public CostProcessor(ICompany company)
        {
            _company = company;
        }

        public void SetTransport(ITransport transport)
        {
            _transport = transport;
        }

        public double GetCost(double distance)
        {
            double resultado = _transport.Cost() * distance * (1 + _company.ProfitMargin());
            return resultado;

        }
    }
}
