using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagit_Makas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int oyuncu_puan = 0;
        int bilgisayar_puan = 0;
        string oyuncuhamle = "";
        string bilgisayarhamle = "";

        //1-Tas 2-Kagit 3-Makas
        public void BilgisayarHamleSec()
        {
            int a = random.Next(3);

            if (a == 0)
            {
                pictureBox2.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "app-images", "tas.png");
                bilgisayarhamle = "tas";
            }

            else if (a == 1)
            {
                pictureBox2.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "app-images", "kagit.png");
                bilgisayarhamle = "kagit";
            }

            else
            {
                pictureBox2.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "app-images", "makas.png");
                bilgisayarhamle = "makas";
            }
        }

        public void KimKazandi()
        {
            if (oyuncuhamle == "tas" && bilgisayarhamle == "tas")
            {
                label4.Text = "OYUN BERABERE!";
            }
            else if (oyuncuhamle == "tas" && bilgisayarhamle == "kagit")
            {
                label4.Text = "Kagit tasi sarar. BİLGİSAYAR KAZANDI !!";
                bilgisayar_puan++;
                label8.Text = bilgisayar_puan.ToString();
            }
            else if (oyuncuhamle == "tas" && bilgisayarhamle == "makas")
            {
                label4.Text = "Tas makası kırar. OYUNCU KAZANDI !!";
                oyuncu_puan++;
                label7.Text = oyuncu_puan.ToString();
            }
            else if (oyuncuhamle == "kagit" && bilgisayarhamle == "tas")
            {
                label4.Text = "Kagit tasi sarar. OYUNCU KAZANDI !!";
                oyuncu_puan++;
                label7.Text = oyuncu_puan.ToString();
            }
            else if (oyuncuhamle == "kagit" && bilgisayarhamle == "kagit")
            {
                label4.Text = "OYUN BERABERE!";
            }
            else if (oyuncuhamle == "kagit" && bilgisayarhamle == "makas")
            {
                label4.Text = "Makas kagidi keser. BİLGİSAYAR KAZANDI !!";
                bilgisayar_puan++;
                label8.Text = bilgisayar_puan.ToString();
            }
            else if (oyuncuhamle == "makas" && bilgisayarhamle == "tas")
            {
                label4.Text = "Tas makası kırar. BİLGİSAYAR KAZANDI !!";
                bilgisayar_puan++;
                label8.Text = bilgisayar_puan.ToString();
            }
            else if (oyuncuhamle == "makas" && bilgisayarhamle == "kagit")
            {
                label4.Text = "Makas kağıdı keser. OYUNCU KAZANDI !!";
                oyuncu_puan++;
                label7.Text = oyuncu_puan.ToString();
            }
            else if (oyuncuhamle == "makas" && bilgisayarhamle == "makas")
            {
                label4.Text = "OYUN BERABERE!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "app-images", "tas.png");
            label4.Text = "Seçtiğin Hamle : TAŞ";
            oyuncuhamle = "tas";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "app-images", "kagit.png");
            label4.Text = "Seçtiğin Hamle : KAĞIT";
            oyuncuhamle = "kagit";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "app-images", "makas.png");
            label4.Text = "Seçtiğin Hamle : MAKAS";
            oyuncuhamle = "makas";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oyuncuhamle == "")
                MessageBox.Show("Oynamak için hamle seçmelisin !!");
            else
            {
                BilgisayarHamleSec();
                KimKazandi();
            }
        }
    }
}
