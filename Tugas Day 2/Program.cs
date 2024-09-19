using System;
using Tugas_Day_2;

namespace TugasDay2
{
    // Kelas dasar User
    

    // Kelas turunan Admin dari User

    // Kelas turunan Customer dari User


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
