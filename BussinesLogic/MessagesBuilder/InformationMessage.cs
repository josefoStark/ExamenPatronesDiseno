namespace BussinesLogic
{
    public class InformationMessage
    {
        public InformationMessage()
        {
            Message = string.Empty;
        }

        public void Add(string element)
        {
            Message = string.Concat(Message, element);
        }

        public string Message { get; private set; }

        public int ColorMessage { get;  set; }
    }
}
