using CommunicationService;

namespace BussinesLogic
{
    public class NonExistentCompanyMessage : ISubscriber
    {
        private readonly IUserInterface _userInterface;

        public void Notify()
        {
           _userInterface.Display("");
        }

        public NonExistentCompanyMessage(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }
    }
}
