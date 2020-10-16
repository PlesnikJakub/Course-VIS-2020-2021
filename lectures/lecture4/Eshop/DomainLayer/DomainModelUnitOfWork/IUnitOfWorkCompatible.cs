using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.DomainModelUnitOfWork
{
    interface IUnitOfWorkCompatible
    {
        void MarkNew();
        void MarkDirty();
        void MarkRemoved();
    }
}
