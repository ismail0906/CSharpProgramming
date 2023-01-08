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

                MessageBox.Show("L�tfen girdi�iniz de�erleri kontrol ediniz !!");
            }

            // C# diline object b�t�n tiplerin atas�d�r. Object b�t�n tiplerin referans�n� tutabilir.

            // boxing => object e d�n���me denir.
            // unboxing => object ten ba�ka bir tipe d�n���me  denir.


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