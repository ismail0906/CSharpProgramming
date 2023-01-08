namespace _2_App_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi1, sayi2, sonuc;

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // try-catch bloklarý
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) //sadece format exceptionlarý yakala
            {
                MessageBox.Show("Opss. Bir hata oluþtu ");
            }
            catch(OverflowException ex) //sadece taþma hatalarýný yakala
            {
                MessageBox.Show("Opsss. Deðer çok büyük veya küçük !!");
            }
          //  finally // hata olsun olmasýn en son çalýþan blok
          //  { 
          //  }
           
            
            sonuc= sayi1 + sayi2;
            // lblSonuc.Text = Convert.ToString(sonuc);
            lblSonuc.Text = sonuc.ToString();

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) //sadece format exceptionlarý yakala
            {
                MessageBox.Show("Opss. Bir hata oluþtu ");
            }
            sonuc = sayi1 - sayi2;
           
            lblSonuc.Text = sonuc.ToString();
        }
        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) //sadece format exceptionlarý yakala
            {
                MessageBox.Show("Opss. Bir hata oluþtu ");
            }
            sonuc = sayi1 / sayi2;

            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) //sadece format exceptionlarý yakala
            {
                MessageBox.Show("Opss. Bir hata oluþtu ");
            }
            sonuc = sayi1 * sayi2;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}