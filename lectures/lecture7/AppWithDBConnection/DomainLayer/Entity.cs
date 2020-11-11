using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    // Identity Field Patter
    public interface Entity
    {
        int Id { get; set; }
    }
}
