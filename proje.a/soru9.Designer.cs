namespace proje.a
{
    partial class soru9
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
            this.label5.Location = new System.Drawing.Point(143, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "sonuç";
            // 
            // txtgoster
            // 
            this.txtgoster.Location = new System.Drawing.Point(254, 182);
            this.txtgoster.Name = "txtgoster";
            this.txtgoster.Size = new System.Drawing.Size(100, 22);
            this.txtgoster.TabIndex = 12;
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(423, 182);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(99, 42);
            this.btngoster.TabIndex = 11;
            this.btngoster.Text = "SONUÇ";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "SAYI GİRİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "SORU:9 Klavyeden girilen sayılardan tek olanları ayrıçift olanları ayrı toplayan " +
    "programı yazınız";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgoster);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
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