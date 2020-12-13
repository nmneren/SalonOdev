
namespace _10AralıkOdev
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_koltuk_sayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_sat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_bos_koltuk = new System.Windows.Forms.Button();
            this.btn_bakiye = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(157, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(210, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_koltuk_sayisi
            // 
            this.txt_koltuk_sayisi.Location = new System.Drawing.Point(157, 73);
            this.txt_koltuk_sayisi.Name = "txt_koltuk_sayisi";
            this.txt_koltuk_sayisi.Size = new System.Drawing.Size(210, 26);
            this.txt_koltuk_sayisi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Sayısı";
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(373, 41);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(139, 58);
            this.btn_olustur.TabIndex = 4;
            this.btn_olustur.Text = "Salon Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_sat);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(57, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış";
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(139, 78);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(113, 58);
            this.btn_iptal.TabIndex = 8;
            this.btn_iptal.Text = "Bilet İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_sat
            // 
            this.btn_sat.Location = new System.Drawing.Point(20, 78);
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.Size = new System.Drawing.Size(113, 58);
            this.btn_sat.TabIndex = 7;
            this.btn_sat.Text = "Bilet Sat";
            this.btn_sat.UseVisualStyleBackColor = true;
            this.btn_sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "İndirimli";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_bos_koltuk);
            this.groupBox2.Controls.Add(this.btn_bakiye);
            this.groupBox2.Location = new System.Drawing.Point(346, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 184);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // btn_bos_koltuk
            // 
            this.btn_bos_koltuk.Location = new System.Drawing.Point(139, 78);
            this.btn_bos_koltuk.Name = "btn_bos_koltuk";
            this.btn_bos_koltuk.Size = new System.Drawing.Size(113, 58);
            this.btn_bos_koltuk.TabIndex = 10;
            this.btn_bos_koltuk.Text = "Boş Koltuk";
            this.btn_bos_koltuk.UseVisualStyleBackColor = true;
            this.btn_bos_koltuk.Click += new System.EventHandler(this.btn_bos_koltuk_Click);
            // 
            // btn_bakiye
            // 
            this.btn_bakiye.Location = new System.Drawing.Point(20, 78);
            this.btn_bakiye.Name = "btn_bakiye";
            this.btn_bakiye.Size = new System.Drawing.Size(113, 58);
            this.btn_bakiye.TabIndex = 9;
            this.btn_bakiye.Text = "Bakiye";
            this.btn_bakiye.UseVisualStyleBackColor = true;
            this.btn_bakiye.Click += new System.EventHandler(this.btn_bakiye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_koltuk_sayisi);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_koltuk_sayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_sat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_bos_koltuk;
        private System.Windows.Forms.Button btn_bakiye;
    }
}

