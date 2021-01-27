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
    public interface ICustomer
    {
        void BrowseProducts(ICashier cashier);

        void ChangePayment(IPayment payment);

        void AskAvailablePayments(ICashier cashier);

        void DeclarePayment(ICashier cashier);

        void AddProductToCart(ICashier cashier,int a);   //fix me

        double Checkout(ICashier cashier);

    }
}
