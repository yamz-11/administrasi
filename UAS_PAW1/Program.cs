using System;

namespace UAS_PAW1
{
    public class Administrasi
    {
        public void administrasi()
        {
            //mendeklarasikan atau mendefinisikan variabel data
            string[] nama = new string[35];
            string[] NIS = new string[35];
            string[] kelas = new string[35];
            string[] alamat = new string[35];
            string[] JK = new string[35];
            string[] WK = new string[35];

            int i, n = 0;
            //menginput jumlah data siswa di inputkan
            Console.WriteLine("     DATA ADMINISTRASI SISWA    ");
            Console.WriteLine("================================");
            Console.Write("Masukan Jumlah Siswa =  ");
            Console.Write("\n");
            n = int.Parse(Console.ReadLine());
            //Mengisi data yg di inputkan user dengan Perulangan For
            for (i = 1; i <= n; i++)
            {
                //menampilkan 'Masukan Data Siswa ke-' variable i
                Console.WriteLine("Masukan Data Siswa ke-" + i);
                Console.WriteLine("================================");
                Console.Write("\n");
                //menampilkan Masukan Nama Siswa
                Console.Write("Masukan Nama Siswa = ");
                nama[i] = Console.ReadLine();
                //menampilkan Masukan Nomor Induk Siswa
                Console.Write("Masukan Nomor Induk Siswa = ");
                NIS[i] = Console.ReadLine();
                //menampilkan Masukan Jenis Kelamin
                Console.Write("Masukan Jenis Kelamin = ");
                JK[i] = Console.ReadLine();
                //menampilkan Masukan Alamat
                Console.Write("Masukan Alamat = ");
                alamat[i] = Console.ReadLine();
                //menampilkan Masukan Kelas
                Console.Write("Masukan Kelas = ");
                kelas[i] = Console.ReadLine();
                //menampilkan Masukan Nama Wali Kelas
                Console.Write("Masukan Nama Wali Kelas = ");
                WK[i] = Console.ReadLine();
                Console.WriteLine();

            }
            
            Console.WriteLine();
            Console.Write("Data Telah DiMasukkan, Tekan Sembarang Untuk Menampilkan Data");
            Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("                Data Administrasi Siswa yang Telah Anda Input                       ");
            Console.WriteLine("====================================================================================");
            Console.Write("\n");
            Console.WriteLine("NO | Nama | NIS | Jenis Kelamin | Alamat |  Kelas | Wali Kelas");

            //menampilkan hasil dari data yg telah di masukan oleh user dengan perulangan for
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(" " + i + "    " + nama[i] + "\t " + NIS[i] + " \t " + JK[i] + " \t  " + alamat[i] + " \t  " + kelas[i]
                                  + " \t " + WK[i]);


            }
            Console.WriteLine();
            Console.Write("Tekan 'ENTER' Untuk Keluar.....");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //memanggil class kasir
            Administrasi Admnst = new Administrasi();
            Admnst.administrasi();
        }
    }
}
