using Domain;

namespace BussinesLogic
{
    public class Director
    {
        private readonly IBuilderMessage _builder;

        public Director(IBuilderMessage builder)
        {
            _builder = builder;
        }

        public void BuildMessage(Response response)
        {
            _builder.SetColorMessage();
            _builder.SetOrigin(response.Origin);
            _builder.SetDestination(response.Destination,response.DeliveredDate);
            _builder.SetCost(response.Cost);
            _builder.SetCompany(response.Company);
           
        }
    }
}
