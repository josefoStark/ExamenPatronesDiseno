namespace Domain
{
    public class Airplane : ITransport
    {
        public double Speed()
        {
            return 10;
        }

        public double Cost()
        {
            return 600;
        }
    }
}
