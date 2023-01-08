namespace _5_Koleksiyon_Generic
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
            this.KoleksiyonGeneric = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lboxName = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KoleksiyonGeneric
            // 
            this.KoleksiyonGeneric.Location = new System.Drawing.Point(29, 254);
            this.KoleksiyonGeneric.Name = "KoleksiyonGeneric";
            this.KoleksiyonGeneric.Size = new System.Drawing.Size(75, 50);
            this.KoleksiyonGeneric.TabIndex = 0;
            this.KoleksiyonGeneric.Text = "Koleksiyon Generic";
            this.KoleksiyonGeneric.UseVisualStyleBackColor = true;
            this.KoleksiyonGeneric.Click += new System.EventHandler(this.KoleksiyonGeneric_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(152, 65);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lboxName
            // 
            this.lboxName.FormattingEnabled = true;
            this.lboxName.ItemHeight = 15;
            this.lboxName.Location = new System.Drawing.Point(152, 143);
            this.lboxName.Name = "lboxName";
            this.lboxName.Size = new System.Drawing.Size(120, 94);
            this.lboxName.TabIndex = 3;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(152, 114);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 334);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lboxName);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.KoleksiyonGeneric);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button KoleksiyonGeneric;
        private TextBox txtName;
        private Button btnEkle;
        private ListBox lboxName;
        private Button btnGoster;
    }
}