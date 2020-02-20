using CommunicationService;

namespace BussinesLogic
{
    public class PackageSentMessage : ISubscriber
    {
        private readonly InformationMessage _infoMessage;

        private readonly IUserInterface _userInterface;

        public PackageSentMessage(IUserInterface userInterface, InformationMessage infoMessage)
        {
            _userInterface = userInterface;
            _infoMessage = infoMessage;
        }

        public void Notify()
        {
            _userInterface.SetTextColor(_infoMessage.ColorMessage);
            _userInterface.Display(_infoMessage.Message);
        }
    }
}
