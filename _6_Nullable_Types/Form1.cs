namespace _6_Nullable_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNulableType_Click(object sender, EventArgs e)
        {
            // Null => de�eri olmayan yap�d�r.
            // Stok = 0    => stokta bitti.
            // stok = null => stokta yok.


            int stok = 0;
            string name = null;
            // int stock = null; // int bir value tpye'tir. sadece de�er atanabilir...Bu b�t�n value typler i�in ge�erlidir...
            
             // Value type lara null atamak i�in tipin nullable olmas� gerekir. bu durumda e�er bir value type nullable de�ilse non-nullable'dir


            Nullable<int> stock = null;         

            if (stock == null)
                MessageBox.Show("Stokta Yok");
            else
                MessageBox.Show("Stok Bitmi�");

            // Veya

           
            if (!stock.HasValue)
                MessageBox.Show("Stokta Yok");
            else
                MessageBox.Show("Stok Bitmi�");
            
        }

        private void btnNullable2_Click(object sender, EventArgs e)
        {
         
            // Nullable<int> stock = null; // 1. yol
            int? stock = null; // 2. yol

            if (stock == null)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("stoktta bitmi�");


            stock = 0;
            // bu sayede gereksiz convert veya casting i�lemi yap�lm�yor.
            if (stock.HasValue)
            {
                int dgr = stock.Value;// De�eri dgr de�i�kenine ata.. 
            }
            

        }
    }
}