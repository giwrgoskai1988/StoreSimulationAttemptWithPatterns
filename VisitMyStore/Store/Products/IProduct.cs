using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.Store.Enums;

namespace VisitMyStore.Store.Products
{
    public interface IProduct
    {
        double Price { get; }
        Color Color { get; }
        Size Size { get; }
        Fabric Fabric { get; }

        void ShowDetails(IProduct product);
    }
}
