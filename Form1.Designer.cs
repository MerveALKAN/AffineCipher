namespace Affine
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifrelenecek = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKckSifrelenecek = new System.Windows.Forms.TextBox();
            this.txtSifrelenmis = new System.Windows.Forms.TextBox();
            this.txtDesifrelenmis = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnDesifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrelenecek Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "b =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifrelenecek Metin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifrelenmiş Metin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Deşifrelenmiş Metiin";
            // 
            // txtSifrelenecek
            // 
            this.txtSifrelenecek.Location = new System.Drawing.Point(152, 30);
            this.txtSifrelenecek.Name = "txtSifrelenecek";
            this.txtSifrelenecek.Size = new System.Drawing.Size(203, 20);
            this.txtSifrelenecek.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(152, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(203, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(152, 83);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(203, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtKckSifrelenecek
            // 
            this.txtKckSifrelenecek.Location = new System.Drawing.Point(152, 109);
            this.txtKckSifrelenecek.Name = "txtKckSifrelenecek";
            this.txtKckSifrelenecek.Size = new System.Drawing.Size(203, 20);
            this.txtKckSifrelenecek.TabIndex = 1;
            // 
            // txtSifrelenmis
            // 
            this.txtSifrelenmis.Location = new System.Drawing.Point(152, 135);
            this.txtSifrelenmis.Name = "txtSifrelenmis";
            this.txtSifrelenmis.Size = new System.Drawing.Size(203, 20);
            this.txtSifrelenmis.TabIndex = 1;
            // 
            // txtDesifrelenmis
            // 
            this.txtDesifrelenmis.Location = new System.Drawing.Point(152, 161);
            this.txtDesifrelenmis.Name = "txtDesifrelenmis";
            this.txtDesifrelenmis.Size = new System.Drawing.Size(203, 20);
            this.txtDesifrelenmis.TabIndex = 1;
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.Color.IndianRed;
            this.btnSifrele.Location = new System.Drawing.Point(152, 203);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(96, 23);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnDesifrele
            // 
            this.btnDesifrele.BackColor = System.Drawing.Color.IndianRed;
            this.btnDesifrele.Location = new System.Drawing.Point(259, 203);
            this.btnDesifrele.Name = "btnDesifrele";
            this.btnDesifrele.Size = new System.Drawing.Size(96, 23);
            this.btnDesifrele.TabIndex = 2;
            this.btnDesifrele.Text = "Deşifrele";
            this.btnDesifrele.UseVisualStyleBackColor = false;
            this.btnDesifrele.Click += new System.EventHandler(this.btnDesifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(431, 277);
            this.Controls.Add(this.btnDesifrele);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtDesifrelenmis);
            this.Controls.Add(this.txtSifrelenmis);
            this.Controls.Add(this.txtKckSifrelenecek);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSifrelenecek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifrelenecek;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKckSifrelenecek;
        private System.Windows.Forms.TextBox txtSifrelenmis;
        private System.Windows.Forms.TextBox txtDesifrelenmis;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnDesifrele;
    }
}

