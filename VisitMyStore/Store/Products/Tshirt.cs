using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.Store.Enums;

namespace VisitMyStore.Store.Products
{
    class Tshirt : Description, IProduct
    {
        public double Price { get; private set; }
        public Color Color { get; private set; }
        public Size Size { get; private set; }
        public Fabric Fabric { get; private set; }

        public Tshirt(Color color, Size size, Fabric fabric)
        {
            Price = 10;
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public override void ShowDetails(IProduct product)
        {
            base.ShowDetails(this);
            Console.Write($"-- {Price} \n");
        }

    }
}
