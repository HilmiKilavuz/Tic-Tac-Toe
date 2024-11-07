using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //değişkenleri tanımladım
        Boolean kontrolcu;
        int biriciOyuncuSkor;
        int ikinciOyuncuSkor;
        //butonları tıklanmaz yapan kudu yazdım
        public void butonlarıDeaktifet()
        {
            for (int i = 1; i <= 25; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Enabled = false;
            }
            kontrolcu = false;


        }
        //butoların içindeki değerleri boşalttım.
        public void butonlarıbosalt()
        {
            for (int i = 1; i <= 25; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Text = "";
            }

        }
        //kazanma durumları belirledim.
        public void kazanma()
        {
            //satır bazında kontrol ettim
            for (int i = 0; i < 5; i++)
            {
                if (esitMi(Controls["button" + (i * 5 + 1)] as Button,
                                Controls["button" + (i * 5 + 2)] as Button,
                                Controls["button" + (i * 5 + 3)] as Button,
                                Controls["button" + (i * 5 + 4)] as Button,
                                Controls["button" + (i * 5 + 5)] as Button))
                {
                    butonlarıDeaktifet();
                    Button button1 = Controls["button" + (i * 5 + 1)] as Button;
                    Button button2 = Controls["button" + (i * 5 + 2)] as Button;
                    Button button3 = Controls["button" + (i * 5 + 3)] as Button;
                    Button button4 = Controls["button" + (i * 5 + 4)] as Button;
                    Button button5 = Controls["button" + (i * 5 + 5)] as Button;
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;

                    if (button1.Text == "X")
                    {
                        biriciOyuncuSkor++;
                        lblOyuncuBirSkor.Text = biriciOyuncuSkor.ToString();
                        MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (button1.Text == "O")
                    {
                        ikinciOyuncuSkor++;
                        lblOyoncuİkiSkor.Text = ikinciOyuncuSkor.ToString();
                        MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            //sütun bazında kontrol ettim
            for (int i = 1; i <= 5; i++)
            {
                if (esitMi(Controls["button" + i] as Button,
                                Controls["button" + (i + 5)] as Button,
                                Controls["button" + (i + 10)] as Button,
                                Controls["button" + (i + 15)] as Button,
                                Controls["button" + (i + 20)] as Button))
                {
                    butonlarıDeaktifet();
                    Button button1 = Controls["button" + (i)] as Button;
                    Button button2 = Controls["button" + (i + 5)] as Button;
                    Button button3 = Controls["button" + (i + 10)] as Button;
                    Button button4 = Controls["button" + (i + 15)] as Button;
                    Button button5 = Controls["button" + (i + 20)] as Button;
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;

                    if (button1.Text == "X")
                    {
                        biriciOyuncuSkor++;
                        lblOyuncuBirSkor.Text = biriciOyuncuSkor.ToString();
                        MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (button1.Text == "O")
                    {
                        ikinciOyuncuSkor++;
                        lblOyoncuİkiSkor.Text = ikinciOyuncuSkor.ToString();
                        MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //çapraz olabileceği iki durumu kotrol ettim.
            if (esitMi(Controls["button1"] as Button,
                   Controls["button7"] as Button,
                   Controls["button13"] as Button,
                   Controls["button19"] as Button,
                   Controls["button25"] as Button))
            {
                butonlarıDeaktifet();
                Button button1 = Controls["button1"] as Button;
                Button button2 = Controls["button7"] as Button;
                Button button3 = Controls["button13"] as Button;
                Button button4 = Controls["button19"] as Button;
                Button button5 = Controls["button25"] as Button;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;

                if (button1.Text == "X")
                {
                    biriciOyuncuSkor++;
                    lblOyuncuBirSkor.Text = biriciOyuncuSkor.ToString();
                    MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (button1.Text == "O")
                {
                    ikinciOyuncuSkor++;
                    lblOyoncuİkiSkor.Text = ikinciOyuncuSkor.ToString();
                    MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (
                 esitMi(Controls["button5"] as Button,
                   Controls["button9"] as Button,
                   Controls["button13"] as Button,
                   Controls["button17"] as Button,
                   Controls["button21"] as Button))
            {
                butonlarıDeaktifet();
                Button button1 = Controls["button5"] as Button;
                Button button2 = Controls["button9"] as Button;
                Button button3 = Controls["button13"] as Button;
                Button button4 = Controls["button17"] as Button;
                Button button5 = Controls["button21"] as Button;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;

                if (button1.Text == "X")
                {
                    biriciOyuncuSkor++;
                    lblOyuncuBirSkor.Text = biriciOyuncuSkor.ToString();
                    MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (button1.Text == "O")
                {
                    ikinciOyuncuSkor++;
                    lblOyoncuİkiSkor.Text = ikinciOyuncuSkor.ToString();
                    MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        //yanyana veya çapraz olarak denk gelen sembollerin eşit olup olmadığını kontrol eden metodu tanımladım.
        private bool esitMi(Button b1, Button b2, Button b3, Button b4, Button b5)
        {
            if (b1.Text == "X" && b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b1.Text == b5.Text)
            {
                return true;

            }
            if (b1.Text == "O" && b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b1.Text == b5.Text)
            {
                return true;

            }
            return false;

        }
        //butonara tıklandığında hangi sembolü yazacağının belirledim ve her butonna basıldığında kazananın olup olmadığını kontrol ededen foksiyonu çağırdım
       private void button21_Click_1(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;
            if (kontrolcu == false)
            {
                tiklananButon.Text = "X";
                kontrolcu = true;

            }
            else
            {
                tiklananButon.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            tiklananButon.Enabled = false;
        }
        //tekrar başla tuşuna basınca butonları sıfırladım
        private void btnTekrarBasla_Click(object sender, EventArgs e)
        {
            butonlarıbosalt();
            for (int i = 1; i <= 25; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Enabled = true;
                button.BackColor = Color.SandyBrown;
            }
            kontrolcu = false;


        }
        //yeni oyuna girince hem butonları hem skorları sıfırladım.
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {

            butonlarıbosalt();
            for (int i = 1; i <= 25; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Enabled = true;
                button.BackColor = Color.SandyBrown;
            }
            kontrolcu = false;


            lblOyuncuBirSkor.Text = "0";
            lblOyoncuİkiSkor.Text = "0";
        }
        //ana sayfaya dönmeyi sağladım
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

       
    }
}
