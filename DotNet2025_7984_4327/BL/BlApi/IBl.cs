using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IBl
    {
        ICustomer ICustomer { get; }
        IOrder IOrder { get; }
        IProduct IProduct { get; }
        ISale ISale { get; }
    }
}
