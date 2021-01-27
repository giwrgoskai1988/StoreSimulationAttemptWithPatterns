using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitMyStore.PaymentMethod;
using VisitMyStore.Store.Products;

namespace VisitMyStore.Store
{
    public interface ICashier
    {

        void ShowProducts();

        void ShowPayments();

        void CheckPayment(IPayment payment);

        IProduct GiveProduct(int a);

        double CalculatePrice(List<IProduct> cart);
    }
}
