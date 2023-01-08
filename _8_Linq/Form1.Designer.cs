namespace _8_Linq
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBay = new System.Windows.Forms.Button();
            this.dgwResult = new System.Windows.Forms.DataGridView();
            this.btnTumu = new System.Windows.Forms.Button();
            this.btnBayanlar = new System.Windows.Forms.Button();
            this.btnGecen = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnGecenBayan = new System.Windows.Forms.Button();
            this.btnGecenBay = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnBaylarExtention = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBay
            // 
            this.btnBay.Location = new System.Drawing.Point(167, 70);
            this.btnBay.Name = "btnBay";
            this.btnBay.Size = new System.Drawing.Size(75, 23);
            this.btnBay.TabIndex = 1;
            this.btnBay.Text = "Baylar";
            this.btnBay.UseVisualStyleBackColor = true;
            this.btnBay.Click += new System.EventHandler(this.btnBay_Click);
            // 
            // dgwResult
            // 
            this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwResult.Location = new System.Drawing.Point(0, 328);
            this.dgwResult.Name = "dgwResult";
            this.dgwResult.RowTemplate.Height = 25;
            this.dgwResult.Size = new System.Drawing.Size(537, 150);
            this.dgwResult.TabIndex = 2;
            // 
            // btnTumu
            // 
            this.btnTumu.Location = new System.Drawing.Point(167, 41);
            this.btnTumu.Name = "btnTumu";
            this.btnTumu.Size = new System.Drawing.Size(75, 23);
            this.btnTumu.TabIndex = 3;
            this.btnTumu.Text = "Tümü";
            this.btnTumu.UseVisualStyleBackColor = true;
            this.btnTumu.Click += new System.EventHandler(this.btnTumu_Click);
            // 
            // btnBayanlar
            // 
            this.btnBayanlar.Location = new System.Drawing.Point(167, 99);
            this.btnBayanlar.Name = "btnBayanlar";
            this.btnBayanlar.Size = new System.Drawing.Size(75, 23);
            this.btnBayanlar.TabIndex = 4;
            this.btnBayanlar.Text = "Bayanlar";
            this.btnBayanlar.UseVisualStyleBackColor = true;
            this.btnBayanlar.Click += new System.EventHandler(this.btnBayanlar_Click);
            // 
            // btnGecen
            // 
            this.btnGecen.Location = new System.Drawing.Point(167, 128);
            this.btnGecen.Name = "btnGecen";
            this.btnGecen.Size = new System.Drawing.Size(75, 23);
            this.btnGecen.TabIndex = 5;
            this.btnGecen.Text = "Geçenler";
            this.btnGecen.UseVisualStyleBackColor = true;
            this.btnGecen.Click += new System.EventHandler(this.btnGecen_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(343, 41);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select Deyimi";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(343, 70);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 23);
            this.btnSelect2.TabIndex = 7;
            this.btnSelect2.Text = "Select 2";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // btnGecenBayan
            // 
            this.btnGecenBayan.Location = new System.Drawing.Point(167, 157);
            this.btnGecenBayan.Name = "btnGecenBayan";
            this.btnGecenBayan.Size = new System.Drawing.Size(75, 49);
            this.btnGecenBayan.TabIndex = 8;
            this.btnGecenBayan.Text = "Geçen Bayanlar";
            this.btnGecenBayan.UseVisualStyleBackColor = true;
            this.btnGecenBayan.Click += new System.EventHandler(this.btnGecenBayan_Click);
            // 
            // btnGecenBay
            // 
            this.btnGecenBay.Location = new System.Drawing.Point(167, 212);
            this.btnGecenBay.Name = "btnGecenBay";
            this.btnGecenBay.Size = new System.Drawing.Size(75, 46);
            this.btnGecenBay.TabIndex = 9;
            this.btnGecenBay.Text = "Geçen Baylar";
            this.btnGecenBay.UseVisualStyleBackColor = true;
            this.btnGecenBay.Click += new System.EventHandler(this.btnGecenBay_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(343, 111);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(75, 23);
            this.btnLambda.TabIndex = 10;
            this.btnLambda.Text = "Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnBaylarExtention
            // 
            this.btnBaylarExtention.Location = new System.Drawing.Point(343, 151);
            this.btnBaylarExtention.Name = "btnBaylarExtention";
            this.btnBaylarExtention.Size = new System.Drawing.Size(107, 61);
            this.btnBaylarExtention.TabIndex = 11;
            this.btnBaylarExtention.Text = "Baylar Extention Metot";
            this.btnBaylarExtention.UseVisualStyleBackColor = true;
            this.btnBaylarExtention.Click += new System.EventHandler(this.btnBaylarExtention_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 478);
            this.Controls.Add(this.btnBaylarExtention);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnGecenBay);
            this.Controls.Add(this.btnGecenBayan);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnGecen);
            this.Controls.Add(this.btnBayanlar);
            this.Controls.Add(this.btnTumu);
            this.Controls.Add(this.dgwResult);
            this.Controls.Add(this.btnBay);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button btnBay;
        private DataGridView dgwResult;
        private Button btnTumu;
        private Button btnBayanlar;
        private Button btnGecen;
        private Button btnSelect;
        private Button btnSelect2;
        private Button btnGecenBayan;
        private Button btnGecenBay;
        private Button btnLambda;
        private Button btnBaylarExtention;
    }
}