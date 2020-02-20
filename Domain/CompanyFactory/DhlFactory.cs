using Domain;

namespace BussinesLogic
{
    public class DhlFactory : ICompanyFactory
    {
        public ICompany GetInstance()
        {
            return new Fedex();
        }
    }
}
