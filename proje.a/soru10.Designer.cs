namespace proje.a
{
    partial class soru10
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtgoster = new System.Windows.Forms.TextBox();
            this.btngoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "sonuç";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtgoster
            // 
            this.txtgoster.Location = new System.Drawing.Point(239, 163);
            this.txtgoster.Name = "txtgoster";
            this.txtgoster.Size = new System.Drawing.Size(100, 22);
            this.txtgoster.TabIndex = 17;
            this.txtgoster.TextChanged += new System.EventHandler(this.txtgoster_TextChanged);
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(405, 156);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(99, 42);
            this.btngoster.TabIndex = 16;
            this.btngoster.Text = "SONUÇ";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "KAT SAYI DEĞERİNİ GİRİNİZ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "SORU:10 Ders notunda bulunan 9 sorudaki fonksiyonlarda girilen kat sayı değerine " +
    "göre en küçük n değerini veren programı yazınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soru10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgoster);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "soru10";
            this.Text = "soru10:Ders notunda bulunan 9 sorudaki Fonksiyonlarda girilen kat sayı değerine g" +
    "öre en küçük değenirini veren programı yazınız";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgoster;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}