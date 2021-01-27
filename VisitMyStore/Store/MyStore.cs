using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.PaymentMethod;
using VisitMyStore.Store.Enums;
using VisitMyStore.Store.Products;

namespace VisitMyStore.Store
{
    class MyStore
    {
         static readonly List<IProduct> availableProducts;
         static readonly List<IPayment> availablePayments;

        static MyStore()
        {
            availablePayments = new List<IPayment> {

                new Card(),
                new BankTransfer()
            };

            availableProducts = new List<IProduct> {

                    new Tshirt(Color.GREEN, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.BLUE, Size.M, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.LINEN),
                    new Tshirt(Color.ORANGE, Size.M, Fabric.SILK),
                    new Tshirt(Color.GREEN, Size.XS, Fabric.WOOL),
                    new Tshirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.GREEN, Size.L, Fabric.COTTON),
                    new Tshirt(Color.BLUE, Size.S, Fabric.LINEN),
                    new Tshirt(Color.BLUE, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.RED, Size.L, Fabric.WOOL),
                    new Tshirt(Color.RED, Size.M, Fabric.RAYON),
                    new Tshirt(Color.BLUE, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.INDIGO, Size.L, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.LINEN),
                    new Tshirt(Color.ORANGE, Size.S, Fabric.SILK),
                    new Tshirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.RED, Size.XS, Fabric.LINEN),
                    new Tshirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
                    new Tshirt(Color.RED, Size.L, Fabric.POLYESTER),
                    new Tshirt(Color.BLUE, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.GREEN, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.INDIGO, Size.M, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.RAYON),
                    new Tshirt(Color.VIOLET, Size.M, Fabric.POLYESTER),
                    new Tshirt(Color.GREEN, Size.XS, Fabric.COTTON),
                    new Tshirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.GREEN, Size.L, Fabric.COTTON),
                    new Tshirt(Color.BLUE, Size.S, Fabric.LINEN),
                    new Tshirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.ORANGE, Size.L, Fabric.SILK),
                    new Tshirt(Color.RED, Size.M, Fabric.RAYON),
                    new Tshirt(Color.BLUE, Size.L, Fabric.RAYON),
                    new Tshirt(Color.INDIGO, Size.L, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.LINEN),
                    new Tshirt(Color.VIOLET, Size.S, Fabric.COTTON),
                    new Tshirt(Color.BLUE, Size.M, Fabric.SILK),
                    new Tshirt(Color.YELLOW, Size.XS, Fabric.LINEN),
                    new Tshirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
                    new Tshirt(Color.RED, Size.L, Fabric.POLYESTER),
                    new Tshirt(Color.BLUE, Size.L, Fabric.WOOL),
                    new Tshirt(Color.GREEN, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.BLUE, Size.M, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.LINEN),
                    new Tshirt(Color.ORANGE, Size.M, Fabric.SILK),
                    new Tshirt(Color.GREEN, Size.XS, Fabric.WOOL),
                    new Tshirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.GREEN, Size.L, Fabric.COTTON),
                    new Tshirt(Color.BLUE, Size.S, Fabric.LINEN),
                    new Tshirt(Color.BLUE, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.RED, Size.L, Fabric.WOOL),
                    new Tshirt(Color.RED, Size.M, Fabric.RAYON),
                    new Tshirt(Color.BLUE, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.INDIGO, Size.L, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.LINEN),
                    new Tshirt(Color.ORANGE, Size.S, Fabric.SILK),
                    new Tshirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.RED, Size.XS, Fabric.LINEN),
                    new Tshirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
                    new Tshirt(Color.RED, Size.L, Fabric.POLYESTER),
                    new Tshirt(Color.BLUE, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.GREEN, Size.L, Fabric.CASHMERE),
                    new Tshirt(Color.INDIGO, Size.M, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.RAYON),
                    new Tshirt(Color.VIOLET, Size.M, Fabric.POLYESTER),
                    new Tshirt(Color.GREEN, Size.XS, Fabric.COTTON),
                    new Tshirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.GREEN, Size.L, Fabric.COTTON),
                    new Tshirt(Color.BLUE, Size.S, Fabric.LINEN),
                    new Tshirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
                    new Tshirt(Color.ORANGE, Size.L, Fabric.SILK),
                    new Tshirt(Color.RED, Size.M, Fabric.RAYON),
                    new Tshirt(Color.BLUE, Size.L, Fabric.RAYON),
                    new Tshirt(Color.INDIGO, Size.L, Fabric.COTTON),
                    new Tshirt(Color.RED, Size.S, Fabric.LINEN),
                    new Tshirt(Color.VIOLET, Size.S, Fabric.COTTON),
                    new Tshirt(Color.BLUE, Size.M, Fabric.SILK),
                    new Tshirt(Color.YELLOW, Size.XS, Fabric.LINEN),
                    new Tshirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
                    new Tshirt(Color.RED, Size.L, Fabric.POLYESTER),
                    new Tshirt(Color.BLUE, Size.L, Fabric.WOOL),

            };
        }

        public void ShowProducts()
        {
            foreach (var product in availableProducts)
            {
                product.ShowDetails(product);
            }
        }

        public void ShowPayments()
        {
            foreach (var payment in availablePayments)
            {
                payment.PaymentMethod();
            }
        }

        public bool PaymentExists(IPayment payment)
        {

            switch (payment.GetType().Name)
            {

                case "Cash":
                    return availablePayments.OfType<Cash>().Any();
                case "Card":
                    return availablePayments.OfType<Card>().Any();
                default:
                    return availablePayments.OfType<BankTransfer>().Any();
            }           
        }

        public IProduct GiveProduct(int a)
        {
            if(a>0 && a < availableProducts.Count -1)
            return availableProducts[a];
            
            else return null;           
        }

    }
}
