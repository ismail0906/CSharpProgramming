namespace _6_Nullable_Types
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
            this.btnNulableType = new System.Windows.Forms.Button();
            this.btnNullable2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNulableType
            // 
            this.btnNulableType.Location = new System.Drawing.Point(54, 102);
            this.btnNulableType.Name = "btnNulableType";
            this.btnNulableType.Size = new System.Drawing.Size(75, 23);
            this.btnNulableType.TabIndex = 0;
            this.btnNulableType.Text = "Nullable Type";
            this.btnNulableType.UseVisualStyleBackColor = true;
            this.btnNulableType.Click += new System.EventHandler(this.btnNulableType_Click);
            // 
            // btnNullable2
            // 
            this.btnNullable2.Location = new System.Drawing.Point(184, 102);
            this.btnNullable2.Name = "btnNullable2";
            this.btnNullable2.Size = new System.Drawing.Size(75, 23);
            this.btnNullable2.TabIndex = 1;
            this.btnNullable2.Text = "Nullable 2";
            this.btnNullable2.UseVisualStyleBackColor = true;
            this.btnNullable2.Click += new System.EventHandler(this.btnNullable2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 259);
            this.Controls.Add(this.btnNullable2);
            this.Controls.Add(this.btnNulableType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNulableType;
        private Button btnNullable2;
    }
}