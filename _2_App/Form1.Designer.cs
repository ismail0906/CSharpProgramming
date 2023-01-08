namespace _2_App
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
            this.btnTıkla = new System.Windows.Forms.Button();
            this.btnArttir = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.Location = new System.Drawing.Point(73, 45);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(75, 23);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "Tıkla";
            this.btnTıkla.UseVisualStyleBackColor = true;
            this.btnTıkla.Click += new System.EventHandler(this.btnTıkla_Click);
            // 
            // btnArttir
            // 
            this.btnArttir.Location = new System.Drawing.Point(73, 140);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(75, 23);
            this.btnArttir.TabIndex = 1;
            this.btnArttir.Text = "Arttır";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.Arttir);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(83, 207);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 15);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(264, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(495, 306);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnArttir);
            this.Controls.Add(this.btnTıkla);
            this.Name = "Form1";
            this.Click += new System.EventHandler(this.btnTıkla_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTıkla;
        private Button btnArttir;
        private Label lblCounter;
        private CheckBox checkBox1;
    }
}