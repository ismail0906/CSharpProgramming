namespace _4_GenericType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Islem<int> islem1 =new Islem<int>();

            Islem<double> islem2 =new Islem<double>();

         // Islem<string> islem3 =new Islem<string>(); // string tipi class oldu�u i�in islem generi�inde kullan�lamaz.

            islem1.Ekle(20);
            islem1.Ekle(2000);
            // islem1.Ekle("aaaa");  i�lemi instance int oldu�u i�in string parametreyi kabul etmeyecektir.

            islem2.Ekle(1);
            islem2.Ekle(1.1);
            
        }
    }
}