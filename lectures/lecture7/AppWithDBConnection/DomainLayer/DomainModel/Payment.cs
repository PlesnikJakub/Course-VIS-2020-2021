using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainModel
{
    public class Payment
    {
        public int Id;

        public double Amount;

        public DateTime Date;

        public string Curency = "USD";

    }
}
