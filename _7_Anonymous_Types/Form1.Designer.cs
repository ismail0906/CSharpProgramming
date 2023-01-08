namespace _7_Anonymous_Types
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
            this.btnAnonymousType = new System.Windows.Forms.Button();
            this.btnAnonymousType2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnonymousType
            // 
            this.btnAnonymousType.Location = new System.Drawing.Point(96, 92);
            this.btnAnonymousType.Name = "btnAnonymousType";
            this.btnAnonymousType.Size = new System.Drawing.Size(142, 45);
            this.btnAnonymousType.TabIndex = 0;
            this.btnAnonymousType.Text = "Anonymous Type";
            this.btnAnonymousType.UseVisualStyleBackColor = true;
            this.btnAnonymousType.Click += new System.EventHandler(this.btnAnonymousType_Click);
            // 
            // btnAnonymousType2
            // 
            this.btnAnonymousType2.Location = new System.Drawing.Point(96, 189);
            this.btnAnonymousType2.Name = "btnAnonymousType2";
            this.btnAnonymousType2.Size = new System.Drawing.Size(142, 44);
            this.btnAnonymousType2.TabIndex = 1;
            this.btnAnonymousType2.Text = "Ananymous Type 2";
            this.btnAnonymousType2.UseVisualStyleBackColor = true;
            this.btnAnonymousType2.Click += new System.EventHandler(this.btnAnonymousType2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 289);
            this.Controls.Add(this.btnAnonymousType2);
            this.Controls.Add(this.btnAnonymousType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnonymousType;
        private Button btnAnonymousType2;
    }
}