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
            // Null => deðeri olmayan yapýdýr.
            // Stok = 0    => stokta bitti.
            // stok = null => stokta yok.


            int stok = 0;
            string name = null;
            // int stock = null; // int bir value tpye'tir. sadece deðer atanabilir...Bu bütün value typler için geçerlidir...
            
             // Value type lara null atamak için tipin nullable olmasý gerekir. bu durumda eðer bir value type nullable deðilse non-nullable'dir


            Nullable<int> stock = null;         

            if (stock == null)
                MessageBox.Show("Stokta Yok");
            else
                MessageBox.Show("Stok Bitmiþ");

            // Veya

           
            if (!stock.HasValue)
                MessageBox.Show("Stokta Yok");
            else
                MessageBox.Show("Stok Bitmiþ");
            
        }

        private void btnNullable2_Click(object sender, EventArgs e)
        {
         
            // Nullable<int> stock = null; // 1. yol
            int? stock = null; // 2. yol

            if (stock == null)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("stoktta bitmiþ");


            stock = 0;
            // bu sayede gereksiz convert veya casting iþlemi yapýlmýyor.
            if (stock.HasValue)
            {
                int dgr = stock.Value;// Deðeri dgr deðiþkenine ata.. 
            }
            

        }
    }
}