using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2837
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(19112837, "Arya", 900000);
            Karyawan karyawan2 = new Karyawan(19113561, "Bakti", 800000);
            Karyawan karyawan3 = new Karyawan(19112235, "Pratama", 700000);

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("No.|\t NIK \t   |\t Nama \t   |\t  Gaji      |");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. |  {0} \t   |\t {1} \t   |\t {2}     |", karyawan.nik, karyawan.nama, karyawan.gajiBulanan);
            Console.WriteLine("2. |  {0} \t   |\t {1} \t   |\t {2}     |", karyawan2.nik, karyawan2.nama, karyawan2.gajiBulanan);
            Console.WriteLine("3. |  {0} \t   |\t {1}   |\t {2}     |", karyawan3.nik, karyawan3.nama, karyawan3.gajiBulanan);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("\n Selamat Anda mendapatkan kenaikan gaji sebesar 10 % \n");

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("No.| \t NIK \t   |\t Nama \t   |\t  Gaji      |");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. |  {0} \t   |\t {1} \t   |\t {2}     |", karyawan.nik, karyawan.nama, karyawan.naikGaji);
            Console.WriteLine("2. |  {0} \t   |\t {1} \t   |\t {2}     |", karyawan2.nik, karyawan2.nama, karyawan2.naikGaji);
            Console.WriteLine("3. |  {0} \t   |\t {1}   |\t {2}     |", karyawan3.nik, karyawan3.nama, karyawan3.naikGaji);
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }
        public int naikGaji { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }

            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            naikGaji = Convert.ToInt32(tmp) + gajiBulanan;
        }

    }
}