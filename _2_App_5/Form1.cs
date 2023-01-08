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

                this.Hide();// Giriþ Formunu gizle
          
            }
            if(counter > 1)
            {
                
                MessageBox.Show($"Hatalý kullanýcý adý veya þifre girdiniz. Lütfen tekrar deneyiniz... Kalan hakkýnýz =  {--counter}");
            }
            else
            {
                MessageBox.Show("Giriþ hakkýnýz bitti. Lütfen bizimle iletiþime geçiniz !");
            }
        }
    }
}