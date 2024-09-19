using System;

namespace UserManagement
{
    class User
    {
        //Atribut 
        string nama = "Tia";
        string role = "CEO";
        int e_money = 1000000000;

        //Method
        public void UserDetail()
        {
            Console.WriteLine("ini detail usernya");
        }

        //Membuat Object
        static void Main(string[] args)
        {
            //kelas itu merupakan blueprint dari sebuah objek
            User userBootcamp = new User();
            userBootcamp.UserDetail();
            Console.WriteLine("Nama :" + userBootcamp.nama);
            Console.WriteLine("Role :" + userBootcamp.role);
            Console.WriteLine("E-Money :" + userBootcamp.e_money);
        }
    }
}