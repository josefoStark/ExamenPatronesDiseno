using System;

namespace BussinesLogic
{
    public class FutureMessage : IBuilderMessage
    {
        private readonly InformationMessage _infoMessage;

        public FutureMessage()
        {
            _infoMessage = new InformationMessage();
        }

        public InformationMessage GetMessage()
        {
            return _infoMessage;
        }

        public void SetOrigin(string origin)
        {
            _infoMessage.Add($"Tu paquete ha salido de {origin}");
        }

        public void SetDestination(string destination, DateTime deliveredDate)
        {
            _infoMessage.Add($" y llegará a {destination} el {deliveredDate}");
        }

        public void SetCost(double cost)
        {
            _infoMessage.Add($" y tendrá un costo de ${cost}. ");
        }

        public void SetCompany(string company)
        {
            _infoMessage.Add($" (cualquier reclamación con {company})");
        }

        public void SetColorMessage()
        {
            _infoMessage.ColorMessage = 2;
        }

       


    }
}
