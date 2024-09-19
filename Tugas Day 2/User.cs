using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Day_2
{
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
}
