using Domain;

namespace BussinesLogic
{
    public class FedexFactory : ICompanyFactory
    {
        public ICompany GetInstance()
        {
            return new Fedex();
        }
    }
}
