namespace _6_7uygulamalar
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.txtNot4 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listeNotlar = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(223, 60);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazılı 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazılı 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sözlü 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sözlü 2";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(71, 268);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(41, 22);
            this.txtNot1.TabIndex = 6;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(185, 268);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(41, 22);
            this.txtNot2.TabIndex = 7;
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(295, 268);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(41, 22);
            this.txtNot3.TabIndex = 8;
            // 
            // txtNot4
            // 
            this.txtNot4.Location = new System.Drawing.Point(405, 268);
            this.txtNot4.Name = "txtNot4";
            this.txtNot4.Size = new System.Drawing.Size(41, 22);
            this.txtNot4.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(468, 98);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listeNotlar
            // 
            this.listeNotlar.FormattingEnabled = true;
            this.listeNotlar.ItemHeight = 16;
            this.listeNotlar.Location = new System.Drawing.Point(571, 63);
            this.listeNotlar.Name = "listeNotlar";
            this.listeNotlar.Size = new System.Drawing.Size(155, 276);
            this.listeNotlar.TabIndex = 11;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(608, 373);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listeNotlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtNot4);
            this.Controls.Add(this.txtNot3);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.TextBox txtNot4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listeNotlar;
        private System.Windows.Forms.Button btnListele;
    }
}

