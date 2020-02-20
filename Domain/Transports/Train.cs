namespace Domain
{
    public class Train : ITransport
    {
        public double Speed()
        {
            return 80;
        }

        public double Cost()
        {
            return 5;
        }
    }
}
