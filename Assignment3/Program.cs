using Assignment3.Cust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.PaymentMethod;
using VisitMyStore.Store;
using VisitMyStore.Store.Products;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICustomer cust = new Customer();

            ICashier cashier = new Cashier();

            cust.BrowseProducts(cashier);

            cust.AddProductToCart(cashier,3);

            double bill = cust.Checkout(cashier);

            Console.WriteLine($"Total cost is {bill}");

            cust.DeclarePayment(cashier);

            cust.AskAvailablePayments(cashier);

            cust.ChangePayment(new Card());

            cust.DeclarePayment(cashier);
        
        }
    }
}
