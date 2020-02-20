using System;
using BussinesLogic;
using CommunicationService;
using Domain;

namespace ExamenPatronesDiseno
{
    public class Client
    {
        public void Main(IUserInterface userInterface)
        {
            Request request = new Request
            {
                Company = "Fedex",
                Destination = "Mérida",
                Distance = 23,
                OrderDate = DateTime.Today,
                Origin = "Motul",
                Transport = "Avión"
            };

            Publisher publisher = new Publisher();
            Response response = RequestHandler(request);

       
            IBuilderMessage builderMessage = SelectMessage(response);
            Director director = new Director(builderMessage);
            director.BuildMessage(response);

            publisher.NotifyUser();

        }

        private bool IsPreviousDate(Response response)
        {
            DateTime today = DateTime.Now;

            int result = today.CompareTo(response.DeliveredDate);

            return result.Equals(1);
        }

        private IBuilderMessage SelectMessage(Response response)
        {
            if (IsPreviousDate(response))
            {
                return new PastMessage();
            }
            else
            {
                return new FutureMessage();
            }
        }


        private Response RequestHandler(Request request)
        {
            ICompanyFactory companyFactory = SelectCompanyFactory(1);
            ITransportFactory transportFactory = SelectTransportFactory(1);

            ICompany company = companyFactory.GetInstance();
            ITransport transport = company.GetTransport(transportFactory);

            TimeProcessor timeProcessor = new TimeProcessor();
            CostProcessor costProcessor = new CostProcessor(company);

            timeProcessor.SetTransport(transport);
            timeProcessor.SetTime(request.Distance);
            costProcessor.SetTransport(transport);

            Response response = new Response
            {
                Origin = request.Origin,
                Company = company.GetName(),
                Cost = costProcessor.GetCost(request.Distance),
                DeliveredDate = timeProcessor.GetDeliveryDate(request.OrderDate),
                Destination = request.Destination,
                Transport = request.Transport
            };

            return response;
        }

        private ICompanyFactory SelectCompanyFactory(int option)
        {

            return new FedexFactory();

        }

        private ITransportFactory SelectTransportFactory(int option)
        {

            return new ShipFactory();

        }
    }
}
