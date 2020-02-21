using CommunicationService;

namespace BussinesLogic
{
    public class IncorrectTransportMessage : ISubscriber
    {
        private readonly IUserInterface _userInterface;

        private string _company;

        private string _transport;
        public void Notify()
        {
            _userInterface.SetTextColor(2);
            _userInterface.Display($"{_company} no ofrece el servicio de transporte {_transport}, te recomendamos cotizar en otra empresa.");
        }

        public IncorrectTransportMessage(IUserInterface userInterface)
        {
            _userInterface = userInterface;

        }

        public void SetTransport(string transport)
        {
            _transport = transport;
        }

        public void SetCompany(string company)
        {
            _company = company;
        }
    }
}
