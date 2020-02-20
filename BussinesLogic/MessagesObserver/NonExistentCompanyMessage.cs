using CommunicationService;

namespace BussinesLogic
{
    public class NonExistentCompanyMessage : ISubscriber
    {
        private readonly IUserInterface _userInterface;

        private string _message;

        public void Notify()
        {
            _userInterface.Display($"La Paquetería: {_message} no se encuentra registrada en nuestra red de distribución");
        }

        public NonExistentCompanyMessage(IUserInterface userInterface)
        {
            _userInterface = userInterface;
           
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
    }
}
