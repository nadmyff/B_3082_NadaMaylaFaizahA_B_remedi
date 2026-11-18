using UTSPBO_Nada;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       MAFIA GALON SYSTEM");
        Console.WriteLine("=================================");

        Agen agen1 = new Agen("A001", "Agen Jember", 10);
        Agen agen2 = new Agen("A002", "Agen Surabaya", 5);

        Console.WriteLine("\n=== INFORMASI AGEN ===");
        agen1.TampilInfo();

        Console.WriteLine();
        agen2.TampilInfo();

        GalonAkua akua = new GalonAkua("P001", 100);

        GalonBerkeran berkeran = new GalonBerkeran(
            "P002", 50, "Keran Putar"
        );

        ProdukGalon produk1 = akua;
        ProdukGalon produk2 = berkeran;

        Console.WriteLine("\n=== PERHITUNGAN BIAYA ===");

        Console.WriteLine("Biaya Akua 5 galon : Rp" +
            produk1.HitungBiaya(5));

        Console.WriteLine("Biaya Berkeran 5 galon : Rp" +
            produk2.HitungBiaya(5));


        DistribusiGalon distribusi1 =
            new DistribusiGalon(agen1, akua, 20);

        distribusi1.KirimPaket();

        DistribusiGalon distribusi2 =
            new DistribusiGalon(agen2, berkeran, 100);

        distribusi2.KirimPaket();

        Console.WriteLine("\n=== STOK SETELAH DISTRIBUSI ===");

        Console.WriteLine("Stok Gudang Akua : " + akua.StokGudang);
        Console.WriteLine("Stok Gudang Berkeran : " + berkeran.StokGudang);

        Console.WriteLine("Stok Agen Jember : " + agen1.StokAgen);
        Console.WriteLine("Stok Agen Surabaya : " + agen2.StokAgen);

        Console.WriteLine("\nProgram selesai.");

        Console.ReadLine();
    }
}