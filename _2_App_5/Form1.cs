 namespace _2_App_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 3;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {


            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text=="123" )
            {
                frmAna frm = new frmAna();
                frm.Show();

                this.Hide();// Giri� Formunu gizle
          
            }
            if(counter > 1)
            {
                
                MessageBox.Show($"Hatal� kullan�c� ad� veya �ifre girdiniz. L�tfen tekrar deneyiniz... Kalan hakk�n�z =  {--counter}");
            }
            else
            {
                MessageBox.Show("Giri� hakk�n�z bitti. L�tfen bizimle ileti�ime ge�iniz !");
            }
        }
    }
}