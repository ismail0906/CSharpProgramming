namespace _3_PartialClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            // Ayný isimde iki farklý classlardaki property özellikleri birletirilerek kullanýlmýþtýr.
            ogr.Adi = "Ýsmail";
            ogr.Soyadý = "Alsan";
            ogr.Vize = 75;
            ogr.Final = 85;
        }
    }
}