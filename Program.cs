using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();
        static void Main(string[] args)
        {
            Console.Title = "RESPONSI";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        hapusprodak();
                        break;

                    case 3:
                        TampilProduk();
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
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine(" Daftar Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine(" 1. Tambahkan Produk");
            Console.WriteLine(" 2. Hapus Produk");
            Console.WriteLine(" 3. Tampilkan Produk");
            Console.WriteLine(" 4. Exit");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Produk prodak= new Produk();
            // TODO: tuliskan logika Anda di sini ...
            Console.Write(" 1. Kode Produk: ");
            prodak.kodebarang = Console.ReadLine();
            Console.Write(" 2. Nama Produk : ");
            prodak.namabarang = Console.ReadLine();
            Console.Write(" 3. Harga Beli : ");
            prodak.hargabeli = Console.ReadLine();
            Console.Write(" 4. Harga Jual : ");
            prodak.hargajual = Console.ReadLine();
            Console.WriteLine();
            daftarProduk.Add(prodak);

            Console.WriteLine("\nTekan ENTER untuk kembali ke Daftar Menu");
            Console.ReadKey();
        }

        static void hapusprodak()
        {
            Produk prodak= new Produk();

            Console.Clear();
            string hapusprodak;
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine(" 1. Hapus Produk");
            Console.WriteLine();
            Console.Write(" 2. Masukan Kode Produk: ");
            hapusprodak = Console.ReadLine();
            var hapus = daftarProduk.SingleOrDefault(f => f.namabarang == hapusprodak);
            if (hapus == null)
            {
                Console.WriteLine();
                Console.WriteLine("Kode Produk tidak ditemukan");
                Console.WriteLine();
            }
            else
            {
                daftarProduk.Remove(hapus);
                Console.WriteLine();
                Console.WriteLine("Data Produk berhasil dihapus");

            }
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int i = 1;
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Produk");
            Console.WriteLine();
            foreach (Produk prodak in daftarProduk)
            {
                
                Console.WriteLine("1.Kode Barang : \n 2.Nama Barang : \n 3.Harga Beli : \n  4.Harga Jual : \n", i, prodak.kodebarang, prodak.namabarang, prodak.hargabeli, prodak.hargabeli);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");

            Console.ReadKey();
        }
    }
}