namespace Domain
{
    public class Airplane : ITransport
    {
        public double Speed()
        {
            return 600;
        }

        public double Cost()
        {
            return 10;
        }
    }
}
