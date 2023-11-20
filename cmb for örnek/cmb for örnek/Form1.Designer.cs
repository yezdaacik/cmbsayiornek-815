namespace cmb_for_örnek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSayilar = new System.Windows.Forms.ComboBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbSayilar
            // 
            this.cmbSayilar.FormattingEnabled = true;
            this.cmbSayilar.Location = new System.Drawing.Point(36, 284);
            this.cmbSayilar.Name = "cmbSayilar";
            this.cmbSayilar.Size = new System.Drawing.Size(121, 21);
            this.cmbSayilar.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(37, 226);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(120, 23);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(37, 25);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(120, 173);
            this.lbSayilar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.cmbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSayilar;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

