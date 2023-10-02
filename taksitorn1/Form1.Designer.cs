namespace taksitorn1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaksitTutari = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tbTaskitSayisi = new System.Windows.Forms.TrackBar();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaskitSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİYAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAKSİT SAYISI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTaksitTutari
            // 
            this.lblTaksitTutari.AutoSize = true;
            this.lblTaksitTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitTutari.Location = new System.Drawing.Point(12, 249);
            this.lblTaksitTutari.Name = "lblTaksitTutari";
            this.lblTaksitTutari.Size = new System.Drawing.Size(120, 16);
            this.lblTaksitTutari.TabIndex = 2;
            this.lblTaksitTutari.Text = "TAKSİT TUTARİ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(123, 194);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 30);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // tbTaskitSayisi
            // 
            this.tbTaskitSayisi.Location = new System.Drawing.Point(123, 127);
            this.tbTaskitSayisi.Maximum = 12;
            this.tbTaskitSayisi.Minimum = 1;
            this.tbTaskitSayisi.Name = "tbTaskitSayisi";
            this.tbTaskitSayisi.Size = new System.Drawing.Size(202, 45);
            this.tbTaskitSayisi.TabIndex = 4;
            this.tbTaskitSayisi.Value = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(123, 56);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 297);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.tbTaskitSayisi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblTaksitTutari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaskitSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTaksitTutari;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TrackBar tbTaskitSayisi;
        private System.Windows.Forms.TextBox txtFiyat;
    }
}

