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
            // Ayn� isimde iki farkl� classlardaki property �zellikleri birletirilerek kullan�lm��t�r.
            ogr.Adi = "�smail";
            ogr.Soyad� = "Alsan";
            ogr.Vize = 75;
            ogr.Final = 85;
        }
    }
}