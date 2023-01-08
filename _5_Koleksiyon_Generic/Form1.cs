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
            // non-generic koleksiyon => (collections vb) birden fazla veriyi bir arada tutmak i�in kullanilan yapilardir...

            // generic  koleksiyon =>  ayni tipde birden fazla veriyi bir arada tutmak i�in kullanilan yapilardir...

            // ArrayList'in generic kar��l���  List tipidir. Ancak List s�n�f� generic oldu�u  i�in instance al�n�rken tip belirtilmelidir
            List<string> names = new List<string>();
            List<int> nums = new List<int>();
            List<char> chars = new List<char>();

            names.Add("Ziya");
            names.Add("�smail");

            nums.Add(10);
            nums.Add(20);
            nums.Add(30);

            chars.Add('A');
            chars.Add('B');

            char c = chars[0];
            string n= names[0];
            int nu = nums[0];

            Kullan�c� k1 = new Kullan�c�();
            k1.Kullan�c�Ad� = "�smail";
            k1.Password = 1234;

            Kullan�c� k2 = new Kullan�c�();
            k1.Kullan�c�Ad� = "zerdo�du";
            k1.Password = 54321;

            List<Kullan�c�> kullanicis = new List<Kullan�c�>();
            kullanicis.Add(k1);
            kullanicis.Add(k2);

            //names.Add(1); // koleksiyonlardaki gibi object beklemedi�i i�in ve intance al�n�rken string belirtildi�i i�in sadece string eleman eklenebilir...


            // Hashtable tipinin generic kar��l��� => Dictionary

            Dictionary<string, int> dnums =new Dictionary<string, int>();
            dnums.Add("a", 10);
            dnums.Add("b", 20);
            dnums.Add("c", 30);

            int dn = dnums["b"];  // b indexindeli eleman� dn de��kenine ata 
            dnums["c"] = 300;     // c indexindeki

            // KeyValuePair => dictionary s�n�f� i�ersindeki 1. sat�r� temsil eder.
            foreach  (KeyValuePair<string,int> dic in dnums)
            {
                MessageBox.Show(dic.Key); // Key'ini yazd�r.
                MessageBox.Show(dic.Value.ToString()); // Value yazd�r.
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