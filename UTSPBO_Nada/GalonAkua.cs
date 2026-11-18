namespace UTSPBO_Nada
{
    public class GalonAkua : ProdukGalon
    {
        // Constructor
        public GalonAkua(string idProduk, int stokGudang)
            : base(idProduk, "Galon Akua", stokGudang)
        {
        }

        // Override method HitungBiaya
        public override int HitungBiaya(int jumlah)
        {
            return jumlah * 20000;
        }
    }
}