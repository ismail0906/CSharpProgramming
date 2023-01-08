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
            // Anonymous Type => C# dilinde  açýkça tip belirtmeden oluþturulan tiplerdir.
            // Anonim = var
            

            var num = 1; // int tipinde deðiþken 
            var name = "Bt Akedemi"; // string tipinde deðiþken
            var cinsiyet = 'E'; // char tipinde deðiþken
            // Anonim tipli deðiþkenlerin tipleri deðer atandýðýnda oluþur.. Bu yüzden anonim tiplerde ilk deðer atamasý zorunludur.
            // Eðer ilk deðer yoksa;
            // default özelliði => anonim tipin deðer atamasý yapýlmadýðý yerde tip belirlemek için kullanýlýr.
            var maas = default(decimal);

            
            var kisi = new
            {
                Adi ="Ziya",
                Soyadi = "Erdoðdu",
                Yas = 23
            };
         // kisi.Adi = "Ýsmail"; //=> Anonim tipli bir nesnenin propertyleri readonly'dir. Yani sadece okunabilir, property scobu dýþýnda set edilemez.

            MessageBox.Show($"{kisi.Adi} {kisi.Soyadi} {kisi.Yas}");
            
            // Anoni tipler dizi veya deðiþken olarakta kullanýlýr. 
        }

        private void btnAnonymousType2_Click(object sender, EventArgs e)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Ziya");
            isimler.Add("Celalettin");

            List<int> sayýlar = new List<int>();
            sayýlar.Add(100);
            sayýlar.Add(500);

            Dictionary<string,string> deger = new Dictionary<string, string>();
            deger.Add("KurumAdi", "Bt akademi");
            deger.Add("EgitimAdi", "Yazýlým Uzmanlýðý");

            foreach (var item in isimler)
            {
                MessageBox.Show(item);
            }
            foreach (var item in deger)
            {
                MessageBox.Show(item.Key);
            }
            foreach (var s in sayýlar)
            {
                
            }

            User user = new User();
            user.ID = 1;
            user.Name = "eyýldýrým";
            user.Surname = "Yýldýrým";
            user.Password = "123";


            UserDTO dto = new UserDTO();
            dto.Name = user.Name;
            dto.Surname= user.Surname;

            var dto1= new {name =user.Name, SurName= user.Surname};
            var dto2= new {Adi = user.Name, Soyadi = user.Surname};

            var user1 =new User();
            user1.Name = "Ziya";
            user1.Surname = "Erdoðdu";

        }
    }
}