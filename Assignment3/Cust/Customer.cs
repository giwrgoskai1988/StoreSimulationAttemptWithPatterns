using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.PaymentMethod;
using VisitMyStore.Store;
using VisitMyStore.Store.Products;

namespace Assignment3.Cust
{
    public class Customer : ICustomer
    {
        private IPayment _payment;
        public List<IProduct> cart;
        //public List<IProduct> customOrders;
        //public ICashier cashier;
        public Customer()
        {
            cart = new List<IProduct>();
            //customOrders = new List<IProduct>();
            _payment = new Cash();
            //cashier = new Cashier();

        }

        public void BrowseProducts(ICashier cashier)
        {
            cashier.ShowProducts();
        }

        public void ChangePayment(IPayment payment)
        {
            _payment = payment;
        }

        public void AskAvailablePayments(ICashier cashier)
        {
            cashier.ShowPayments();
        }

        public void DeclarePayment(ICashier cashier)
        {
            Console.WriteLine("I WILL :");
            _payment.PaymentMethod();
            cashier.CheckPayment(_payment);

        }


        public void AddProductToCart(ICashier cashier, int a)
        {
            IProduct product = cashier.GiveProduct(a);

            cart.Add(product);

        }

        public double Checkout(ICashier cashier)
        {
            return cashier.CalculatePrice(cart);
        }
    }
}
