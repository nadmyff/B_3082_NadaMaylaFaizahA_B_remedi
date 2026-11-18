using System;

namespace UTSPBO_Nada
{
    public class Agen
    {
        public string IdAgen { get; set; }
        public string NamaAgen { get; set; }
        public int StokAgen { get; private set; }

        public Agen(string idAgen, string namaAgen, int stokAgen)
        {
            IdAgen = idAgen;
            NamaAgen = namaAgen;
            StokAgen = stokAgen;
        }

        public void TambahStok(int jumlah)
        {
            StokAgen += jumlah;
        }

        public void TampilInfo()
        {
            Console.WriteLine("ID Agen   : " + IdAgen);
            Console.WriteLine("Nama Agen : " + NamaAgen);
            Console.WriteLine("Stok Agen : " + StokAgen);
        }
    }
}