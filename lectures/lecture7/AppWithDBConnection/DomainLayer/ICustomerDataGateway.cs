using System.Data;

namespace DomainLayer
{
    public interface ICustomerDataGateway
    {
        DataTable Find();
    }
}
