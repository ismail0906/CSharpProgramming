namespace _2_App_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Merhaba Ýsmail");
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            lblBilgi.Text = txtBilgi.Text;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (txtValue.Text.Length < 100 )     
            {
                lblValue.Text = txtValue.Text;
            }
           
            if (txtValue.Text.Length <= 100)
            {
                lblCounter.Text = $"{100-txtValue.Text.Length} Karakter Kaldý";        
            }


            
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çýkmak istediðine emin misin ?", "UYARI", MessageBoxButtons.YesNo);

            if (result== DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}