using System.Collections;

namespace _5_Koleksiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Array (uzunluk sabittir (statikdir))
        // Collections (uzunluk sabit de�ildir (dinamiktir)). Collection s�n�flar System.Collections namepsacesi i�erisindedir..
        // Generic Collection

        //string[] kisiler = new string[5];
        //int ind; // s�n�f seviye fieldlar�n default de�erleri vard�r. int 0'd�r
        ArrayList kisiList = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //kisiler[ind] = txtIsim.Text;
            //ind++;
            kisiList.Add(txtIsim.Text);

            txtIsim.Clear(); // texti temizle...

            //Add Metodu koleksiyonlarda eleman eklemek i�in kullan�l�r....
            //Count property'si koleksiyonun uzunlu�unu verir 

            kisiList.Add("test");
            kisiList.Remove("test"); // test eleman�n� sil... 

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kisiList.Count; i++)
            {
                lboxIsimler.Items.Add(kisiList[i]);
            }
        }

        private void btnKoleksiyonDetayl�_Click(object sender, EventArgs e)
        {
            // key value �eklinde veri saklayan koleksiyon yap�s�d�r. Dizi veya ArrayListten farkl� keyler bizim indexlerimiz ve taraf�m�zdan olu�turulur...

            Hashtable ht = new Hashtable(); // koleksiyon...
            ht.Add("a", "Ekrem");
            ht.Add("b", "Ziya");
            ht.Add("c", "B��ra");

            // Not : keyler unique (benzersiz) olmal�d�r
            //  ht.Add("b", "�smail");

            ht["b"] = "�smail"; // var olan bir indexe eleman atamas� yap�labilir...


            string str = ht["c"].ToString();

            // Koleksiyonlar kullan�l�rken dizilerdki gibi tip belirtilmez. ��nk� koleksiyon object tipinde eleman saklar (elemanlar object tipindedir). object c# dilinde b�t�n tiplerin atas�d�r. yani b�t�n tiplerin referans�n� tutabilir. 

            // onject olarak sakland�klar� kullanal�aca�� zaman tekrar objecttten d�n���m yap�lmas� gerekir. ��nk� object referans tutan bir varl�kt�r. buda performans sorunu olarak kar��m�za ��kar...

            ArrayList arrNames = new ArrayList();
            arrNames.Add("Onur");
            arrNames.Add("Celalettin");

            ArrayList arrNums = new ArrayList();
            arrNums.Add(10);
            arrNums.Add(20);
            arrNums.Add(30);

            ArrayList arrChars = new ArrayList();
            arrChars.Add('A');
            arrChars.Add('B');
            arrChars.Add('C');


            Ogrenci o = new Ogrenci();
            o.Adi = "�smail";
            o.SoyAdi = "Aslan";

            Ogrenci o1 = new Ogrenci();
            o1.Adi = "B��ra";
            o1.SoyAdi = "Gen�";

            ArrayList arrOgr = new ArrayList();
            arrOgr.Add(o);
            arrOgr.Add(o1);

            // object'e d�n���m boxing
            // object'ten d�n���n unboxing
            // i�lemidir...

            int num = 0;
            for (int i = 0; i < arrNums.Count; i++)
            {
                num += (int)arrNums[i]; // unboxing
            }

            for (int i = 0; i < arrOgr.Count; i++)
            {
                Ogrenci otemp = (Ogrenci)arrOgr[i];
                MessageBox.Show(otemp.Adi);
            }

            // koleksiyon yap�lar�nda tip g�venli�i yoktur..
            string[] arr = new string[2]; // dizilerin tip g�venli�i vard�r. yani dizi tipinde eleman eklenebilir
            //arr[0] = 100;

            //int s = "aaa"; // de�i�kenlerin tip g�venli�i vard�r. degisken tipinde veri set edilebilir..

            ArrayList arrrTemp = new ArrayList();
            arrrTemp.Add("ekrem");
            arrrTemp.Add(100);
            arrrTemp.Add('E');

            // i 1 olkdu�ubnda 1. eleman int tipinde oldu�u i�in string tipinde ��kar�lamaz. �al��ma zaman� hatas� al�r�z.

            // koleksiyonlarda bu �ekilde farkl� tipten veriler bir arada saklanabildi�i i�in bu bir dezavantajd�r..Dikkatli olmakl� gerekir.. 
            for (int i = 0; i < arrrTemp.Count; i++)
            {
                string name = (string)arrrTemp[i];
            }
        }
    }
    
}