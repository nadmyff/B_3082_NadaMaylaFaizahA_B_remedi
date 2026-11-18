using System;

namespace UTSPBO_Nada
{
    public class DistribusiGalon : DapatDidistribusikan
    {
        private Agen agenTujuan;
        private ProdukGalon produk;
        private int jumlah;

        public DistribusiGalon(Agen agenTujuan, ProdukGalon produk, int jumlah)
        {
            this.agenTujuan = agenTujuan;
            this.produk = produk;
            this.jumlah = jumlah;
        }

        public void KirimPaket()
        {
            Console.WriteLine("\n=== PROSES DISTRIBUSI ===");

            if (jumlah <= 0)
            {
                Console.WriteLine("Pengiriman gagal! Jumlah harus lebih dari 0.");
            }
            else if (jumlah > produk.StokGudang)
            {
                Console.WriteLine("Pengiriman gagal! Stok gudang tidak mencukupi.");
            }
            else
            {
                produk.KurangiStok(jumlah);
                agenTujuan.TambahStok(jumlah);

                Console.WriteLine("Paket berhasil dikirimkan ke agen " + agenTujuan.NamaAgen);
                Console.WriteLine("Produk      : " + produk.NamaProduk);
                Console.WriteLine("Jumlah      : " + jumlah + " galon");
                Console.WriteLine("Total Biaya : Rp" + produk.HitungBiaya(jumlah));
            }
        }
    }
}