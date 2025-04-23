using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blimplementation
{
    internal class OrderImplementation:IOrder
    {
        private IDal _dal = DalApi.Factory.Get;

    }
}
