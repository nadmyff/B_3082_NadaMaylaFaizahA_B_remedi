namespace UTSPBO_Nada
{
    public abstract class ProdukGalon
    {
        private string idProduk;
        private string namaProduk;
        private int stokGudang;

        public string IdProduk
        {
            get { return idProduk; }
            set { idProduk = value; }
        }

        public string NamaProduk
        {
            get { return namaProduk; }
            set { namaProduk = value; }
        }

        public int StokGudang
        {
            get { return stokGudang; }
            private set
            {
                if (value >= 0)
                {
                    stokGudang = value;
                }
            }
        }

        public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
        {
            this.idProduk = idProduk;
            this.namaProduk = namaProduk;

            if (stokGudang >= 0)
            {
                this.stokGudang = stokGudang;
            }
            else
            {
                throw new System.ArgumentException("Stok tidak boleh negatif!");
            }
        }

        public void KurangiStok(int jumlah)
        {
            if (jumlah > 0 && jumlah <= stokGudang)
            {
                StokGudang -= jumlah;
            }
        }

        public abstract int HitungBiaya(int jumlah);
    }
}