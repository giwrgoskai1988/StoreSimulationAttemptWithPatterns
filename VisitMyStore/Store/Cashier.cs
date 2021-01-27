using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.PaymentMethod;
using VisitMyStore.Store.Products;

namespace VisitMyStore.Store
{
    public class Cashier:ICashier
    {
        private MyStore mystore;

        public Cashier()
        {
            mystore = new MyStore();
        }

        public void ShowProducts()
        {
            mystore.ShowProducts();
        }

        public void ShowPayments()
        {
            Console.WriteLine("YOU CAN  :");
            mystore.ShowPayments();
        }

        public void CheckPayment(IPayment payment)
        {
            if(mystore.PaymentExists(payment))
            {
                Console.WriteLine("You decided to :");
                payment.PaymentMethod();
            }
            else
            {
                Console.WriteLine("Sorry you cant :");
                payment.PaymentMethod();             
            }
        }

        public IProduct GiveProduct(int a)
        {                
            return mystore.GiveProduct(a);
        }

        public double CalculatePrice(List<IProduct> cart)
        {
            double bill = 0;
            foreach (var product in cart)
            {
                bill += product.Price;
            }

            return bill;
        }
    }
}
