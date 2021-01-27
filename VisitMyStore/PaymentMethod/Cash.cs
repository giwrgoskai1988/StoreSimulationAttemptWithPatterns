using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitMyStore.PaymentMethod
{
    public class Cash : IPayment
    {
        public void PaymentMethod()
        {
            Console.WriteLine("Pay with Cash!");
        }
    }
}
