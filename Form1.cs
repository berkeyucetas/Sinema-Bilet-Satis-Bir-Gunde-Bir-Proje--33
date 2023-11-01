using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans2 = 0;
        int seans3 = 0;
        int seans4 = 0;
        int seans5 = 0;
        int seans6 = 0;
        int seans1ücret = 0;
        int seans2ücret = 0;
        int seans3ücret = 0;
        int seans4ücret = 0;
        int seans5ücret = 0;
        int seans6ücret = 0;

        private void btns1artı_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1ücret = seans1ücret + 37;
            texts1.Text = seans1.ToString();
            texts1ücret.Text = seans1ücret.ToString();
            if (seans1 == 25)
            {
                btns1artı.Enabled = false;
                MessageBox.Show("Salon komple dolu..!");
            }
            else 
            {
                btns1artı.Enabled=true;
            }
        }

        private void btns1eksi_Click(object sender, EventArgs e)
        {
            btns1artı.Enabled = true;
            seans1--;
            seans1ücret = seans1ücret - 37;
            texts1.Text = seans1.ToString();
            texts1ücret.Text = seans1ücret.ToString();
        }

        private void btns2artı_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2ücret = seans2ücret + 43;
            texts2.Text = seans2.ToString();
            texts2ücret.Text = seans2ücret.ToString();
            if (seans2 == 25)
            {
                btns2artı.Enabled = false;
                MessageBox.Show("Salon komple dolu..!");
            }
            else
            {
                btns2artı.Enabled = true;
            }
        }

        private void btns2eksi_Click(object sender, EventArgs e)
        {
            btns2artı.Enabled = true;
            seans2--;
            seans2ücret = seans2ücret - 43;
            texts2.Text = seans2.ToString();
            texts2ücret.Text = seans2ücret.ToString();
        }

        private void btns3artı_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3ücret = seans3ücret + 51;
            texts3.Text = seans3.ToString();
            texts3ücret.Text = seans3ücret.ToString();
            if (seans3 == 25)
            {
                btns3artı.Enabled = false;
                MessageBox.Show("Salon komple dolu..!");
            }
            else
            {
                btns3artı.Enabled = true;
            }
        }

        private void btns3eksi_Click(object sender, EventArgs e)
        {
            btns3artı.Enabled = true;
            seans3--;
            seans3ücret = seans3ücret - 51;
            texts3.Text = seans3.ToString();
            texts3ücret.Text = seans3ücret.ToString();
        }

        private void btns4artı_Click(object sender, EventArgs e)
        {
            seans4++;
            seans4ücret = seans4ücret + 67;
            texts4.Text = seans4.ToString();
            texts4ücret.Text = seans4ücret.ToString();
            if (seans4 == 25)
            {
                btns4artı.Enabled = false;
                MessageBox.Show("Salon komple dolu..!");
            }
            else
            {
                btns4artı.Enabled = true;
            }
        }

        private void btns4eksi_Click(object sender, EventArgs e)
        {
            btns4artı.Enabled = true;
            seans4--;
            seans4ücret = seans4ücret - 67;
            texts4.Text = seans4.ToString();
            texts4ücret.Text = seans4ücret.ToString();
        }

        private void btns5artı_Click(object sender, EventArgs e)
        {
            seans5++;
            seans5ücret = seans5ücret + 73;
            texts5.Text = seans5.ToString();
            texts5ücret.Text = seans5ücret.ToString();
            if (seans5 == 25)
            {
                btns5artı.Enabled = false;
                MessageBox.Show("Salon komple dolu..!");
            }
            else
            {
                btns5artı.Enabled = true;
            }
        }

        private void btns5eksi_Click(object sender, EventArgs e)
        {
            btns5artı.Enabled = true;
            seans5--;
            seans5ücret = seans5ücret - 73;
            texts5.Text = seans5.ToString();
            texts5ücret.Text = seans5ücret.ToString();
        }
        private void btns6artı_Click(object sender, EventArgs e)
        {
            seans6++;
            seans6ücret = seans6ücret + 90;
            texts6.Text = seans6.ToString();
            texts6ücret.Text = seans6ücret.ToString();
            if (seans6 == 25)
            {
                btns6artı.Enabled = false;
                MessageBox.Show("Salon komple dolu..!");
            }
            else
            {
                btns6artı.Enabled = true;
            }
        }
        private void btns6eksi_Click(object sender, EventArgs e)
        {
            btns6artı.Enabled = true;
            seans6--;
            seans6ücret = seans6ücret - 90;
            texts6.Text = seans6.ToString();
            texts6ücret.Text = seans6ücret.ToString();
        }

        int ma = 0;
        int mf = 0;
        int ka = 0;
        int kf = 0;
        int sa = 0;
        int sf = 0;
        private void buttonMA_Click(object sender, EventArgs e)
        {
            ma++;
            mf = mf + 42;
            textMA.Text = ma.ToString();
            textMF.Text = mf.ToString();
            
        }

        private void buttonME_Click(object sender, EventArgs e)
        {
            buttonMA.Enabled = true;
            ma--;
            mf = mf - 42;
            textMA.Text = ma.ToString();
            textMF.Text = mf.ToString();
        }

        private void buttonKA_Click(object sender, EventArgs e)
        {
            ka++;
            kf = kf + 16;
            textKM.Text = ka.ToString();
            textKF.Text = kf.ToString();
            
        }

        private void buttonKE_Click(object sender, EventArgs e)
        {
            buttonKE.Enabled = true;
            ka--;
            kf = kf - 16;
            textKM.Text = ka.ToString();
            textKF.Text = kf.ToString();
        }

        private void buttonSA_Click(object sender, EventArgs e)
        {
            sa++;
            sf = mf + 7;
            textSM.Text = sa.ToString();
            textSF.Text = sf.ToString();
            
        }

        private void buttonSE_Click(object sender, EventArgs e)
        {
            buttonSE.Enabled = true;
            sa--;
            sf = sf - 7;
            textSM.Text = sa.ToString();
            textSF.Text = sf.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int toplamizleyici;
            int toplampara;
            toplamizleyici= seans1+seans2+seans3+seans4+seans5+seans6;
            toplampara = seans1ücret + seans2ücret + seans3ücret + seans4ücret + seans5ücret + seans6ücret;
            textBox1.Text = "1 gün boyunca ATATÜRK filminin toplam izleyicisi" + " " + toplamizleyici + " " + " " + " " + "toplam kazanılan para:" + " " + toplampara;
            int toplamsatıs;
            int toplambüfeücret;
            toplamsatıs = ma + ka + sa;
            toplambüfeücret = mf + kf + sf;
            textBox2.Text = "1 gün boyunca büfe ürün satış miktarı:" + " " + toplamsatıs + " " + " " + " " + "toplam kazanılan para:" + " " + toplambüfeücret;
        }
    }
}
