using System;
using BussinesLogic;
using CommunicationService;
using Domain;

namespace ExamenPatronesDiseno
{
    public class Client
    {
        private readonly Publisher _publisher;

        public Client()
        {
            _publisher = new Publisher();
        }

        public void Main(IUserInterface userInterface, Request request)
        {
            ICompanyFactory companyFactory = SelectCompanyFactory(request.Company);

            if (companyFactory == null)
            {
                NonExistentCompanyMessage errorCompany = new NonExistentCompanyMessage(userInterface);
                errorCompany.SetMessage(request.Company);
                _publisher.Subscribe(errorCompany);
            }

            else
            {
                ICompany company = companyFactory.GetInstance();
                ITransportFactory transportFactory = SelectTransportFactory(request.Transport);
                ITransport transport = company.GetTransport(transportFactory);

                if (transport == null )
                {
                    IncorrectTransportMessage errorTransport = new IncorrectTransportMessage(userInterface);
                    errorTransport.SetCompany(request.Company);
                    errorTransport.SetTransport(request.Transport);
                    _publisher.Subscribe(errorTransport);
                }
                else
                {
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


                    IBuilderMessage builderMessage = SelectMessage(response);
                    Director director = new Director(builderMessage);
                    director.BuildMessage(response);
                    InformationMessage infoMessage = builderMessage.GetMessage();
                    PackageSentMessage packageSentMessage = new PackageSentMessage(userInterface, infoMessage);
                    _publisher.Subscribe(packageSentMessage);
                }


            }


            _publisher.NotifyUser();
            _publisher.Reset();
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

            return new FutureMessage();
        }




        private ICompanyFactory SelectCompanyFactory(string option)
        {
            switch (option.ToUpperInvariant())
            {
                case "FEDEX":
                    return new FedexFactory();
                case "DHL":
                    return new DhlFactory();
                case "ESTAFETA":
                    return new EstafetaFactory();
                default:
                    return null;
            }

        }

        private ITransportFactory SelectTransportFactory(string option)
        {
            switch (option.ToUpperInvariant())
            {
                case "AVION":
                    return new AirplaneFactory();
                case "TREN":
                    return new TrainFactory();
                case "BARCO":
                    return new ShipFactory();
                default:
                    return null;
            }
        }
    }
}
