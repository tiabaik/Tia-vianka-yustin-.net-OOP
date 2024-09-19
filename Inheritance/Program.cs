using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritace
{
    //Parent Class
    public class Lingkaran
    {
        double luas;
        
        //methoid untu luas
        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }
    }

    //Child
    public class Tabung : Lingkaran
    {
        double volume;
        public Tabung( int tinggi, double r)
             {
                // neggunakan metode luas lingkaran dari kelas lingkaran
                volume = tinggi * this.LuasLingkaran(r);
            }
        public double getVolume()

        {
            return volume;

        }


        static void Main(string[] args)
        {
            Tabung tabung = new Tabung(5, 10);

            Console.WriteLine("volume = " + tabung.getVolume());
        }

    }
 }