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
            // try-catch bloklar�
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) //sadece format exceptionlar� yakala
            {
                MessageBox.Show("Opss. Bir hata olu�tu ");
            }
            catch(OverflowException ex) //sadece ta�ma hatalar�n� yakala
            {
                MessageBox.Show("Opsss. De�er �ok b�y�k veya k���k !!");
            }
          //  finally // hata olsun olmas�n en son �al��an blok
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
            catch (FormatException ex) //sadece format exceptionlar� yakala
            {
                MessageBox.Show("Opss. Bir hata olu�tu ");
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
            catch (FormatException ex) //sadece format exceptionlar� yakala
            {
                MessageBox.Show("Opss. Bir hata olu�tu ");
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
            catch (FormatException ex) //sadece format exceptionlar� yakala
            {
                MessageBox.Show("Opss. Bir hata olu�tu ");
            }
            sonuc = sayi1 * sayi2;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}