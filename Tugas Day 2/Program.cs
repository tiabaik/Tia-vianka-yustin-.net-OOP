using System;

namespace TugasDay2
{
    // Kelas dasar User
    public class User
    {
        private string nama;
        private string role;
        private decimal emoney;
        public string Nama { get { return nama; } set { nama = value; } }
        public string Role { get { return role; } set { role = value; } }
        public decimal Emoney { get { return emoney; } set { emoney = value; } }

        public User(string nama, string role, decimal emoney)
        {
            Nama = nama;
            Role = role;
            Emoney = emoney;
        }
    }

    // Kelas turunan Admin dari User
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

    // Kelas turunan Customer dari User
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

    class Program
    {
     
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            
            customers.Add(new Customer("William", 5000));
            customers.Add(new Customer("Surya", 4000));

            Admin admin = new Admin(); 

            
            Console.WriteLine("Pilih role Anda (Admin/Customer): ");
            string role = Console.ReadLine();

            if (role.ToLower() == "admin")
            {
                

               
                Console.WriteLine("Pilih Customer (william/surya): ");
                string namaCustomer = Console.ReadLine();

                Customer customer = FindCustomerByName(namaCustomer);

                if (customer != null)
                {
                    Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan: ");
                    decimal jumlahSaldo = decimal.Parse(Console.ReadLine());

                    admin.TambahSaldo(customer, jumlahSaldo);
                }
                else
                {
                    Console.WriteLine("Customer tidak terdaftar!");
                }
            }
            else if (role.ToLower() == "customer")
            {
               
                Console.WriteLine("Masukkan nama Customer: ");
                string namaCustomer = Console.ReadLine();

                Customer customer = FindCustomerByName(namaCustomer);

                if (customer != null)
                {
                    
                    Console.WriteLine("Saldo sekarang:");
                    customer.LihatSaldo();
                }
                else
                {
                    Console.WriteLine("Anda bukan Customer!");
                }
            }
            else
            {
                Console.WriteLine("Role tidak valid! Silakan pilih Admin atau Customer.");
            }
        }

       
        static Customer FindCustomerByName(string name)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Nama.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
