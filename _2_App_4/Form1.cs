 namespace _2_App_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // EventArgs => Eventi temsil eder.
        // Sender => Eventi tetikleyen nesneyi temsi eder.
        private void Islem_Click(object sender,EventArgs e) 
        {
            int sayi1=0, sayi2=0, sonuc = 0;

            try
            {
                sayi1 = Convert.ToInt32(txtSayi1);
                sayi2 = Convert.ToInt32(txtSayi2);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen girdiðiniz deðerleri kontrol ediniz !!");
            }

            // C# diline object bütün tiplerin atasýdýr. Object bütün tiplerin referansýný tutabilir.

            // boxing => object e dönüþüme denir.
            // unboxing => object ten baþka bir tipe dönüþüme  denir.


            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "+":
                   sonuc = sayi1 + sayi2;
                    break;
                   
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;

            }
            lblSonuc.Text= sonuc.ToString();
           
        }

    }
}