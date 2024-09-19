using System;
namespace Encapsulation
{
    // claas lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        //private field untuk menyimpan nilai radius
        private double radius;

        // public properti untuk mengakses dan mengatur radius

        public double Radius
        {
            get {  return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius Harus lebih dari nol");
                }
            }
        }

        // mettdhot untuk menghitung lias 
        public double Luas ()
        {
            return 3.14 * radius * radius;
        }

        // membuat clas tabung menggunakan lingkaran sebagai komponen
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            // konstruktor untuk inisiasi tabung
            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius;
                this.tinggi = tinggi;
            }
            public double HitungVolume()
            {
                return lingkaran.Luas() * tinggi;
            }

        }

        public class program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(2, 5);
                    Console.WriteLine("Volume Tbaung : " + tabung.HitungVolume());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);   
                }
            }

        }

    }

}