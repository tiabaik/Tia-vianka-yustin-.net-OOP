using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Day_2
{
    public class Customer : User
    {
        public Customer(string nama, decimal emoney)
            : base(nama, "Customer", emoney)
        {
        }

        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo {Nama}: {Emoney:C}");
        }
    }
}
