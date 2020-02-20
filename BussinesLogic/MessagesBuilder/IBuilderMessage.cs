using System;

namespace BussinesLogic
{
    public interface IBuilderMessage
    {
        InformationMessage GetMessage();

        void SetOrigin(string origin);

        void SetDestination(string destination, DateTime deliveredDate);

        void SetCost(double cost);

        void SetCompany(string company);

        void SetTransport(string transport);
    }
}
