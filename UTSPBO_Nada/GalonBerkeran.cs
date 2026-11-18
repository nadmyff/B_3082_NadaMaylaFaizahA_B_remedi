namespace UTSPBO_Nada
{
    public class GalonBerkeran : ProdukGalon
    {
        public string JenisKeran { get; set; }

        public GalonBerkeran(string idProduk, int stokGudang, string jenisKeran)
            : base(idProduk, "Galon Berkeran", stokGudang)
        {
            JenisKeran = jenisKeran;
        }

        public override int HitungBiaya(int jumlah)
        {
            return jumlah * 12000;
        }
    }
}