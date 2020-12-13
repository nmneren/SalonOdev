using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10AralıkOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            try
            {
                Olustur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_sat_Click(object sender, EventArgs e)
        {
            try
            {
                Bilet.Sat(checkBox1.Checked);
                checkBox1.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Bilet.Iptal();
        }
        private void btn_bakiye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Bilet Bakiyesi = " + Bilet.Bakiye);
        }
        private void btn_bos_koltuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Koltuk Sayısı = " + Bilet.BosKoltuk);

        }


        void Olustur()
        {
            if (Salon.BosKoltuk <= 0)
            {
                Salon.SalonName = txt_name.Text;
                Salon.KoltukSayisi = int.Parse(txt_koltuk_sayisi.Text);
                Salon.BosKoltuk = int.Parse(txt_koltuk_sayisi.Text);

                MessageBox.Show("Salon Oluşturuldu.");
                txt_koltuk_sayisi.Clear();
                txt_name.Clear();

            }
            else
            {
                MessageBox.Show("Boş Koltuk Var.");
            }
        }
    }
}
