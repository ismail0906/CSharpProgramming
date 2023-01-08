namespace _2_App_2
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
            this.btnTikla = new System.Windows.Forms.Button();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTikla
            // 
            this.btnTikla.Location = new System.Drawing.Point(43, 47);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(75, 23);
            this.btnTikla.TabIndex = 0;
            this.btnTikla.Text = "Tıkla";
            this.btnTikla.UseVisualStyleBackColor = true;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(43, 134);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(100, 23);
            this.txtBilgi.TabIndex = 1;
            // 
            // btnBilgi
            // 
            this.btnBilgi.Location = new System.Drawing.Point(171, 134);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(75, 23);
            this.btnBilgi.TabIndex = 2;
            this.btnBilgi.Text = "Yazdır";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(288, 142);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(38, 15);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "label1";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(188, 183);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(38, 15);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(43, 175);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 86);
            this.txtValue.TabIndex = 5;
            this.txtValue.Click += new System.EventHandler(this.btnTikla_Click);
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(44, 272);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(38, 15);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "label1";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(261, 273);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 356);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.btnTikla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTikla;
        private TextBox txtBilgi;
        private Button btnBilgi;
        private Label lblBilgi;
        private Label lblValue;
        private TextBox txtValue;
        private Label lblCounter;
        private Button btnKapat;
    }
}