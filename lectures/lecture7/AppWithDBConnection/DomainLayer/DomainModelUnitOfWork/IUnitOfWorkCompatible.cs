using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainModelUnitOfWork
{
    interface IUnitOfWorkCompatible
    {
        void MarkNew();
        void MarkDirty();
        void MarkRemoved();
    }
}
