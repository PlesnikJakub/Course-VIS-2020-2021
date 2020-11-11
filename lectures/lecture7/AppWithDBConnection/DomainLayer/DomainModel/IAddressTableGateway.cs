using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainModel
{
    public interface IAddressTableGateway
    {
        void GetById(int id);

        void GetAll();

        void GetByName();
         
    }
}
