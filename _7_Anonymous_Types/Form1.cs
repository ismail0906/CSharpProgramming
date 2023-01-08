namespace _7_Anonymous_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnonymousType_Click(object sender, EventArgs e)
        {
            // Anonymous Type => C# dilinde  a��k�a tip belirtmeden olu�turulan tiplerdir.
            // Anonim = var
            

            var num = 1; // int tipinde de�i�ken 
            var name = "Bt Akedemi"; // string tipinde de�i�ken
            var cinsiyet = 'E'; // char tipinde de�i�ken
            // Anonim tipli de�i�kenlerin tipleri de�er atand���nda olu�ur.. Bu y�zden anonim tiplerde ilk de�er atamas� zorunludur.
            // E�er ilk de�er yoksa;
            // default �zelli�i => anonim tipin de�er atamas� yap�lmad��� yerde tip belirlemek i�in kullan�l�r.
            var maas = default(decimal);

            
            var kisi = new
            {
                Adi ="Ziya",
                Soyadi = "Erdo�du",
                Yas = 23
            };
         // kisi.Adi = "�smail"; //=> Anonim tipli bir nesnenin propertyleri readonly'dir. Yani sadece okunabilir, property scobu d���nda set edilemez.

            MessageBox.Show($"{kisi.Adi} {kisi.Soyadi} {kisi.Yas}");
            
            // Anoni tipler dizi veya de�i�ken olarakta kullan�l�r. 
        }

        private void btnAnonymousType2_Click(object sender, EventArgs e)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Ziya");
            isimler.Add("Celalettin");

            List<int> say�lar = new List<int>();
            say�lar.Add(100);
            say�lar.Add(500);

            Dictionary<string,string> deger = new Dictionary<string, string>();
            deger.Add("KurumAdi", "Bt akademi");
            deger.Add("EgitimAdi", "Yaz�l�m Uzmanl���");

            foreach (var item in isimler)
            {
                MessageBox.Show(item);
            }
            foreach (var item in deger)
            {
                MessageBox.Show(item.Key);
            }
            foreach (var s in say�lar)
            {
                
            }

            User user = new User();
            user.ID = 1;
            user.Name = "ey�ld�r�m";
            user.Surname = "Y�ld�r�m";
            user.Password = "123";


            UserDTO dto = new UserDTO();
            dto.Name = user.Name;
            dto.Surname= user.Surname;

            var dto1= new {name =user.Name, SurName= user.Surname};
            var dto2= new {Adi = user.Name, Soyadi = user.Surname};

            var user1 =new User();
            user1.Name = "Ziya";
            user1.Surname = "Erdo�du";

        }
    }
}