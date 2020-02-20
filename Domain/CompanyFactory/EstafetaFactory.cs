using Domain;

namespace BussinesLogic
{
    public class EstafetaFactory : ICompanyFactory
    {
        public ICompany GetInstance()
        {
            return new Estafeta();
        }
    }
}
