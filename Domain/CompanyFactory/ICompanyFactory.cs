using Domain;

namespace BussinesLogic
{
    public interface ICompanyFactory
    {
        ICompany GetInstance();
    }
}
