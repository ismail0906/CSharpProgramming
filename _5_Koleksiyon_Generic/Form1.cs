namespace _5_Koleksiyon_Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KoleksiyonGeneric_Click(object sender, EventArgs e)
        {
            // non-generic koleksiyon => (collections vb) birden fazla veriyi bir arada tutmak için kullanilan yapilardir...

            // generic  koleksiyon =>  ayni tipde birden fazla veriyi bir arada tutmak için kullanilan yapilardir...

            // ArrayList'in generic karþýlýðý  List tipidir. Ancak List sýnýfý generic olduðu  için instance alýnýrken tip belirtilmelidir
            List<string> names = new List<string>();
            List<int> nums = new List<int>();
            List<char> chars = new List<char>();

            names.Add("Ziya");
            names.Add("Ýsmail");

            nums.Add(10);
            nums.Add(20);
            nums.Add(30);

            chars.Add('A');
            chars.Add('B');

            char c = chars[0];
            string n= names[0];
            int nu = nums[0];

            Kullanýcý k1 = new Kullanýcý();
            k1.KullanýcýAdý = "Ýsmail";
            k1.Password = 1234;

            Kullanýcý k2 = new Kullanýcý();
            k1.KullanýcýAdý = "zerdoðdu";
            k1.Password = 54321;

            List<Kullanýcý> kullanicis = new List<Kullanýcý>();
            kullanicis.Add(k1);
            kullanicis.Add(k2);

            //names.Add(1); // koleksiyonlardaki gibi object beklemediði için ve intance alýnýrken string belirtildiði için sadece string eleman eklenebilir...


            // Hashtable tipinin generic karþýlýðý => Dictionary

            Dictionary<string, int> dnums =new Dictionary<string, int>();
            dnums.Add("a", 10);
            dnums.Add("b", 20);
            dnums.Add("c", 30);

            int dn = dnums["b"];  // b indexindeli elemaný dn deðþkenine ata 
            dnums["c"] = 300;     // c indexindeki

            // KeyValuePair => dictionary sýnýfý içersindeki 1. satýrý temsil eder.
            foreach  (KeyValuePair<string,int> dic in dnums)
            {
                MessageBox.Show(dic.Key); // Key'ini yazdýr.
                MessageBox.Show(dic.Value.ToString()); // Value yazdýr.
            }



        }

        List<string> kisiler = new List<string>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtName.Text);
            txtName.Clear();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lboxName.Items.Clear();
            /*
            for (int i = 0; i < kisiler.Count; i++)
            {
                lboxName.Items.Add(i);
            }
            */


            foreach (string kisi in kisiler)
            {
                lboxName.Items.Add(kisi);
            }
        }

      
    }
}