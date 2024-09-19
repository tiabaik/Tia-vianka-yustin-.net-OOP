using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasDay2;

namespace Tugas_Day_2
{
    public class Admin : User
    {
        public Admin() : base("Admin", "Admin", 0)
        {
        }

        // Method untuk menambah saldo Customer
        public void TambahSaldo(Customer customer, decimal jumlah)
        {
            decimal saldoLama = customer.Emoney;
            customer.Emoney += jumlah;
            Console.WriteLine($"Saldo lama {customer.Nama}: {saldoLama:C}");
            Console.WriteLine($"Saldo baru yang ditambahkan: {jumlah:C}");
            Console.WriteLine($"Saldo total sekarang: {customer.Emoney:C}");
        }
    }
}
