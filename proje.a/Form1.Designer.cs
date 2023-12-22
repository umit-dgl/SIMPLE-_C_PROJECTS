namespace proje.a
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
            this.lbltek = new System.Windows.Forms.Label();
            this.lblcift = new System.Windows.Forms.Label();
            this.btngoster = new System.Windows.Forms.Button();
            this.txtgoster = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORU:8 Klavyeden girilen sayılardan tek olanları ayrıçift olanları ayrı toplayan " +
    "programı yazınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI GİRİNİZ";
            // 
            // lbltek
            // 
            this.lbltek.AutoSize = true;
            this.lbltek.Location = new System.Drawing.Point(75, 194);
            this.lbltek.Name = "lbltek";
            this.lbltek.Size = new System.Drawing.Size(92, 16);
            this.lbltek.TabIndex = 2;
            this.lbltek.Text = "TEK SAYILAR";
            // 
            // lblcift
            // 
            this.lblcift.AutoSize = true;
            this.lblcift.Location = new System.Drawing.Point(75, 239);
            this.lblcift.Name = "lblcift";
            this.lblcift.Size = new System.Drawing.Size(95, 16);
            this.lblcift.TabIndex = 3;
            this.lblcift.Text = "ÇİFT SAYILAR";
            this.lblcift.Click += new System.EventHandler(this.label4_Click);
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(373, 137);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(99, 42);
            this.btngoster.TabIndex = 4;
            this.btngoster.Text = "SONUÇ";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgoster
            // 
            this.txtgoster.Location = new System.Drawing.Point(197, 144);
            this.txtgoster.Name = "txtgoster";
            this.txtgoster.Size = new System.Drawing.Size(100, 22);
            this.txtgoster.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgoster);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.lblcift);
            this.Controls.Add(this.lbltek);
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
        private System.Windows.Forms.Label lbltek;
        private System.Windows.Forms.Label lblcift;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.TextBox txtgoster;
        private System.Windows.Forms.Label label5;
    }
}

