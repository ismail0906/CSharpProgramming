namespace _2_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sayac = 0;
        private void btnTýkla_Click(object sender, EventArgs e)
        {
            sayac = sayac + 1;
            btnTýkla.Text= $"Týkladýn {sayac}";
        }

        private int counter = 0;
        private bool durum = true;
        public void Arttir(object sender, EventArgs e) 
        {
            if (durum == true)
               counter++;   
            
            else
               counter--;
            
            if (counter==10)
               durum = false;

            if (counter == 0)
                durum = true;

            /* 
            if (btnArttir.Text == "Arttýr")
                counter++;
            else
                counter--;
            if (counter == 10)
            {
                btnArttir.Text = "Azalt";
            }
            else if (counter == 0)
            {
                btnArttir.Text = "Arttýr";
            }
            */                  

            lblCounter.Text = counter.ToString(); // 1. Yol
         // lblCounter.Text = Convert.ToString(counter); // 2. Yol
        }

       
    }
}