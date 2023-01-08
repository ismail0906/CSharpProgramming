namespace _8_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LINQ (Language Integrated Query) => Dile entegre sorgula veya Dil ile b�t�nle�ik sorgulama 

            // Sorgulama dilleri veriler �zerinde i�lem (man�plasyon) yapmam�z� sa�lar.

            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(10);
            nums.Add(4);
            nums.Add(8);
            nums.Add(16);
            nums.Add(13);

            // Tekleri bulduk
            List<int> tekler = new List<int>();
            foreach (int i in nums)
            {
                if (i %2 == 1)
                {
                    tekler.Add(i);
                }

            }

            List<int> kucukler = new List<int>();
            foreach (int i in kucukler)
            {
                if (i<10)
                {
                    kucukler.Add(i);
                }
            }
            // Linq yap�lar� sayesinde gereksiz d�ng� ve karar yap�lar�ndan kurtuluruz. Tamamen tek sat�rda queryyazarak sonucu elde ederiz.
            
            // 1. G�sterim
            List<int> teknums = (from a in nums   // verileri a' ya ata 
                                 where a%2 == 0   // filitre uygula 
                                 select a).ToList();// a'lar� se�
            // 2. G�sterim
            List<int> kucuknums = (from a in nums where a< 10 select a).ToList(); 



        }

        List<Ogrenci> ogrencis = new List<Ogrenci>();
        private void Form1_Load(object sender, EventArgs e) // Formun y�klenme olay�. Form y�klenirken tetiklenir. Genelde ba�lang�� verileri buraya set edilir.
        {
            Ogrenci ogr = new Ogrenci();
            ogr.AdiSoyadi = "Ziya Erdo�du";
            ogr.Cinsiyet = 'E';
            ogr.Vize = 40;
            ogr.Final = 60;

            // Object Initializer
            Ogrenci ogr1 = new Ogrenci
            {
                AdiSoyadi = "Celalettin Miktan",
                Cinsiyet = 'E',
                Vize = 50,
                Final = 70

            };

            Ogrenci ogr2 = new Ogrenci { AdiSoyadi = "Onur Derman", Cinsiyet = 'E', Vize = 20, Final = 100 };
            Ogrenci ogr3 = new Ogrenci { AdiSoyadi = "�smail Alsan", Cinsiyet = 'E', Vize = 80, Final = 70 };
            Ogrenci ogr4 = new Ogrenci { AdiSoyadi = "K�bra Karaku�", Cinsiyet = 'K', Vize = 30, Final = 90 };

            
            ogrencis.Add(ogr);
            ogrencis.Add(ogr1);
            ogrencis.Add(ogr2);
            ogrencis.Add(ogr3);
            ogrencis.Add(ogr4);
            ogrencis.Add(new Ogrenci { AdiSoyadi = "B��ra Gen�", Cinsiyet = 'K', Vize = 60, Final = 70 });


        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            // DataGridWiew dizi koleksiyon gibi yap�lar� sat�r ve sutun �eklinde d�zenli olarak verileri g�sterir.
            // DataSource �zelli�i listelenecek veri kayna�� bekler. ogrencis veri kayna��n� gride source ediyoruz..
            dgwResult.DataSource = ogrencis;
        }

        private void btnBay_Click(object sender, EventArgs e)
        {
            List<Ogrenci> baylar = new List<Ogrenci>(); // Ko�ula uygun verileri tutmak i�in liste tan�mlad�k
         /* foreach (var item in ogrencis)     // foreach d�ng�s� y�ntemi ile
            {
                if (item.Cinsiyet == 'E')
                {
                    baylar.Add(item); // Ko�ula uygun item'i listeye ekle
                }
                
            }

            // Di�er yol 1
            baylar = (from o in ogrencis
                      where o.Cinsiyet == 'E'
                      select).ToList();
            
            // Di�er yol 2 
            dgwResult.DataSource = (from o in ogrencis
                                    where o.Cinsiyet == 'E'
                                    select o).ToList();
           
            dgwResult.DataSource = baylar; // DataGridWiew'e atama yapar.

            */



            List<Ogrenci> bayOgrencis = (from o in ogrencis
                                         where o.Cinsiyet == 'E'
                                         select o).ToList();
            dgwResult.DataSource = bayOgrencis;           
           



        }

        private void btnBayanlar_Click(object sender, EventArgs e)
        {
            dgwResult.DataSource = (from o in ogrencis
                                    where o.Cinsiyet == 'K'
                                    select o).ToList();
        }

        private void btnGecen_Click(object sender, EventArgs e)
        {
         /* float sum = 0;
            foreach (var item in ogrencis)
            {
                sum += item.Ortalama;
            }
            float avg =sum / ogrencis.Count; // ortalamay� bul

            List<Ogrenci> gecenler = new List<Ogrenci>();
            
            foreach (var item in gecenler)  // Normal Y�ntem 
            {
                if (item.Ortalama >= avg)
                {
                    gecenler.Add(item);
                }
            }
            dgwResult.DataSource = gecenler;
         */
            
            // Linq ;
            List<float> ortalamalari = (from o in ogrencis
                                        select o.Ortalama).ToList();
            float avg1 = ortalamalari.Average();
            
            // Avarege metodu ile
            float avg2 = (from o in ogrencis
                          select o.Ortalama).Average();
            List<Ogrenci> gecenOgrencis = (from a in ogrencis
                                          where a.Ortalama >avg2
                                          select a).ToList();
            dgwResult.DataSource = gecenOgrencis;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // select ifadesi => sorgudan ��kt� olarak �retilecek nesneleri ifade eder..

            // Ogrencileri se�
            List<Ogrenci> ogrenciler = (from o in ogrencis
                                        where o.Cinsiyet == 'K'
                                        select o).ToList();
            foreach (var item in ogrenciler)
            {
                MessageBox.Show(item.AdiSoyadi + item.Vize + item.Final);
            }
            
            
            List<string> isimleri = (from a in ogrencis
                                     select a.AdiSoyadi).ToList();
           
            foreach (var item in isimleri)
            {
                MessageBox.Show(item);
            }

            
            List<float> ortalamalari = (from ogr in ogrencis
                                        select ogr.Ortalama).ToList();
            
            foreach (var item in ortalamalari)
            {
                MessageBox.Show(item.ToString());
            }

        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            var ogrencilerim = (from a in ogrencis
                                select new 
                                {
                                    a.AdiSoyadi,
                                    a.Ortalama
                                }).ToList();

            dgwResult.DataSource = ogrencilerim;
        }

        private void btnGecenBayan_Click(object sender, EventArgs e)
        {
            var ortalama =(from a in ogrencis
                           select a.Ortalama).Average();


            var gecenbayanogrencis =(from a in ogrencis
                                     where a.Ortalama >= ortalama && a.Cinsiyet == 'K'
                                     select a).ToList();
            dgwResult.DataSource = gecenbayanogrencis;
        }

        private void btnGecenBay_Click(object sender, EventArgs e)
        {
            var ortalama = (from a in ogrencis
                            select a.Ortalama).Average();
            var anonimList = (from a in ogrencis
                              where a.Ortalama >= ortalama && a.Cinsiyet == 'E'
                              select new
                              {
                                  a.AdiSoyadi,
                                  a.Vize,
                                  a.Final
                              }).ToList();
            dgwResult.DataSource = anonimList;
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            // Lambda �fadeleri => Girdi parametrelerinden sonu� �retmemizi sa�layan isimsiz fonksiyonlar denilebilir. 

            // Tan�m ;
            // Girdi parametresi => Sonu� ifadesi

            // c => c + c ( c parametresini c ile topla )
            // c => c + 10 ( c parametresini 10 ile topla)
            // x => x > 5 ( x �yle bir x ki 5'ten b�y�kse sonu� true)

            // giri� parametresi int, d�n��� int lambda ifadesi ..
            Func<int, int> ifade1 = c => c + c;
            int result = ifade1(4);
            MessageBox.Show(result.ToString());

            Func<int,bool> ifade2 = c => c == 10;
            bool result2 = ifade2(1);
            MessageBox.Show(result2.ToString());


            Func<char, bool> ifade3 = c => c == 'K'; // c == 'K' ya ifade2 true d�ns�n
            foreach (var item in ogrencis)
            {
                if (ifade3(item.Cinsiyet))
                {
                    MessageBox.Show(item.AdiSoyadi);
                }
            }

            var resultBayanlar = (from a in ogrencis
                                  where ifade3(a.Cinsiyet)
                                  select a);
        }

        private void btnBaylarExtention_Click(object sender, EventArgs e)
        {
            // Extention Metot => instance �zreinden �a�r�lan c# metotlar�d�r.
            // Linq sorgular�na alternatif sorgular(sorguyu k�saltmak) yazmak i�in kullan�l�r.

            List<Ogrenci> bayogrencis = ogrencis.Where(c => c.Cinsiyet == 'E').ToList();
            dgwResult.DataSource = bayogrencis;
        }
    }
}