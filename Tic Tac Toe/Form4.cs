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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Boolean kontrolcu;
        int biriciOyuncuSkor;
        int ikinciOyuncuSkor;
        //butonları tıklanmaz yapan kodu yazdım
        public void butonlarıDeaktifet()
        {
            for (int i = 1; i <= 49; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Enabled = false;
            }
            kontrolcu = false;


        }
        //butoların içindeki değerleri boşalttım.
        public void butonlarıbosalt()
        {
            for (int i = 1; i <= 49; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Text = "";
            }

        }
        private bool esitMi(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6, Button b7)
        {
            if (b1.Text == "X" && b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b1.Text == b5.Text && b1.Text == b6.Text && b1.Text == b7.Text)
            {
                return true;

            }
            if (b1.Text == "O" && b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b1.Text == b5.Text && b1.Text == b6.Text && b1.Text == b7.Text)
            {
                return true;

            }
            return false;

        }
        public void kazanma()
        {
            for (int i = 0; i < 7; i++)
            {
                //satır bazında kontrol ettim
                if (esitMi(Controls["button" + (i * 7 + 1)] as Button,
                        Controls["button" + (i * 7 + 2)] as Button,
                        Controls["button" + (i * 7 + 3)] as Button,
                        Controls["button" + (i * 7 + 4)] as Button,
                        Controls["button" + (i * 7 + 5)] as Button,
                         Controls["button" + (i * 7 + 6)] as Button,
                        Controls["button" + (i * 7 + 7)] as Button))
                {
                    butonlarıDeaktifet();
                    Button button1 = Controls["button" + (i * 7 + 1)] as Button;
                    Button button2 = Controls["button" + (i * 7 + 2)] as Button;
                    Button button3 = Controls["button" + (i * 7 + 3)] as Button;
                    Button button4 = Controls["button" + (i * 7 + 4)] as Button;
                    Button button5 = Controls["button" + (i * 7 + 5)] as Button;
                    Button button6 = Controls["button" + (i * 7 + 6)] as Button;
                    Button button7 = Controls["button" + (i * 7 + 7)] as Button;
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Red;

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
            for (int i = 1; i <= 7; i++)
            {
                if (esitMi(Controls["button" + i] as Button,
                        Controls["button" + (i + 7)] as Button,
                        Controls["button" + (i + 14)] as Button,
                        Controls["button" + (i + 21)] as Button,
                        Controls["button" + (i + 28)] as Button,
                         Controls["button" + (i + 35)] as Button,
                          Controls["button" + (i + 42)] as Button))
                {
                    butonlarıDeaktifet();
                    Button button1 = Controls["button" + (i)] as Button;
                    Button button2 = Controls["button" + (i + 7)] as Button;
                    Button button3 = Controls["button" + (i + 14)] as Button;
                    Button button4 = Controls["button" + (i + 21)] as Button;
                    Button button5 = Controls["button" + (i + 28)] as Button;
                    Button button6 = Controls["button" + (i + 35)] as Button;
                    Button button7 = Controls["button" + (i + 42)] as Button;

                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Red;

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
                    Controls["button9"] as Button,
                    Controls["button17"] as Button,
                    Controls["button25"] as Button,
                    Controls["button33"] as Button,
                    Controls["button41"] as Button,
                    Controls["button49"] as Button))
            {
                butonlarıDeaktifet();
                Button button1 = Controls["button1"] as Button;
                Button button2 = Controls["button9"] as Button;
                Button button3 = Controls["button17"] as Button;
                Button button4 = Controls["button25"] as Button;
                Button button5 = Controls["button33"] as Button;
                Button button6 = Controls["button41"] as Button;
                Button button7 = Controls["button49"] as Button;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;

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
            
            if (esitMi(Controls["button7"] as Button,
                                Controls["button13"] as Button,
                                Controls["button19"] as Button,
                                Controls["button25"] as Button,
                                Controls["button31"] as Button,
                                Controls["button37"] as Button,
                                Controls["button43"] as Button))
            {
                butonlarıDeaktifet();
                Button button1 = Controls["button7"] as Button;
                Button button2 = Controls["button13"] as Button;
                Button button3 = Controls["button19"] as Button;
                Button button4 = Controls["button25"] as Button;
                Button button5 = Controls["button31"] as Button;
                Button button6 = Controls["button37"] as Button;
                Button button7 = Controls["button43"] as Button;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;

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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //yeni oyun için buton ayarladım
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            butonlarıbosalt();
            for (int i = 1; i <= 49; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Enabled = true;
                button.BackColor = Color.SandyBrown;
            }
            kontrolcu = false;


            lblOyuncuBirSkor.Text = "0";
            lblOyoncuİkiSkor.Text = "0";
        }
        //tekrar başlama için butonu ayarladım
        private void btnTekrarBasla_Click(object sender, EventArgs e)
        {
            butonlarıbosalt();
            for (int i = 1; i <= 49; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Enabled = true;
                button.BackColor = Color.SandyBrown;
            }
            kontrolcu = false;
        }
        //bütün butonlara tek bir buton komutu üzerinde emir verdim
        private void button49_Click(object sender, EventArgs e)
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
        //ana sayfaya dönen butonu ayarladım.
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
