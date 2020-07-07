using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> listCustomer = new List<Customer>();
        //private static object listCustomer;

        static void Main(string[] args)
        {
            List<Customer> listCustomer = new List<Customer>();
            Console.Title = "Responsi UAS Matakuliah Pemrograman by M Bagus Rizky";
        

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                
                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilihan Menu : \n");
            Console.WriteLine("1. Tambah Customer ");
            Console.WriteLine("2. Hapus Customer ");
            Console.WriteLine("3. Tampilkan Customer ");
            Console.WriteLine("4. Keluar \n");
           
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahCustomer()
        {
            Console.Clear();
            Customer Customer = new Customer();
            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection

            Console.Write("Kode : ");
            Customer.kode = Console.ReadLine();
            Console.Write("Nama : ");
            Customer.nama = Console.ReadLine();
            Console.Write("Piutang : ");
            Customer.piutang = Convert.ToDouble(Console.ReadLine());
            listCustomer.Add(Customer);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            int no = -1, hapus = -1;
            Console.Clear();
            Console.Write("\nHapus Customer \n");
            Console.Write("\nKode Customer : ");
            string kode = Console.ReadLine();
            foreach (Customer Customer in listCustomer)
            {
                no++;
                if (Customer.kode == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                listCustomer.RemoveAt(hapus);
                Console.WriteLine("\nData Customer berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode Customer tidak ditemukan");
            }
            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            Console.Write("\n\n");
            int i = 1;
            Console.WriteLine("Data Customer");
            foreach (Customer Customer in listCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}",
                i, Customer.kode, Customer.nama, Customer.piutang,i);
                i++;
            }
            if (i < 1)
            {
                Console.WriteLine("Anda belum menambahkan data");
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
