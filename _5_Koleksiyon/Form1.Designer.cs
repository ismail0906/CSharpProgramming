namespace _5_Koleksiyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lboxIsimler = new System.Windows.Forms.ListBox();
            this.btnKoleksiyonDetaylı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(66, 29);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 23);
            this.txtIsim.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(66, 78);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(66, 123);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lboxIsimler
            // 
            this.lboxIsimler.FormattingEnabled = true;
            this.lboxIsimler.ItemHeight = 15;
            this.lboxIsimler.Location = new System.Drawing.Point(46, 244);
            this.lboxIsimler.Name = "lboxIsimler";
            this.lboxIsimler.Size = new System.Drawing.Size(120, 94);
            this.lboxIsimler.TabIndex = 3;
            // 
            // btnKoleksiyonDetaylı
            // 
            this.btnKoleksiyonDetaylı.Location = new System.Drawing.Point(66, 178);
            this.btnKoleksiyonDetaylı.Name = "btnKoleksiyonDetaylı";
            this.btnKoleksiyonDetaylı.Size = new System.Drawing.Size(75, 45);
            this.btnKoleksiyonDetaylı.TabIndex = 4;
            this.btnKoleksiyonDetaylı.Text = "Koleksiyon Detaylı";
            this.btnKoleksiyonDetaylı.UseVisualStyleBackColor = true;
            this.btnKoleksiyonDetaylı.Click += new System.EventHandler(this.btnKoleksiyonDetaylı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.btnKoleksiyonDetaylı);
            this.Controls.Add(this.lboxIsimler);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIsim;
        private Button btnEkle;
        private Button btnGoster;
        private ListBox lboxIsimler;
        private Button btnKoleksiyonDetaylı;
    }
}