using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.Store.Enums;

namespace VisitMyStore.Store.Products
{
    abstract class Description    //DECORATION ??
    {

        public virtual void ShowDetails(IProduct product)
        {
            Console.Write($"{this.GetType().Name} -- {product.Color} -- {product.Fabric} -- {product.Size}");
        }
    }
}
