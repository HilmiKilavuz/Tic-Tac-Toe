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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //değişkenleri tanımladım
        Boolean kontrolcu;
        int biriciOyuncuSkor;
        int ikinciOyuncuSkor;
        //beraberlik durumunu tanımladım
        public void beraberlik()
        {
            if (button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" ) {
                MessageBox.Show("Berabere.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }
        //butonların dokunulmaz yapan fonksiyonu tanımladım

        public void butonlarıDeaktifet()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            }
        //hangi durumlarda kazanılacaksa o durumları belirledim
        public void kazanma()
        {
            //oyuncunun yanyana veya çapraz olacak şekilde denk gelen semboller durumunda kazanmasını sağladım
            //kazanan butonları kırmızıya boyadım, butonu dokunlmaz yaptım ve yapan oyuncnun skorunu bir arttırdım.
            //Oyuncu Birin kazanması
            if (button1.Text=="X"&&button2.Text=="X"&&button3.Text=="X")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.","TicTacToe", MessageBoxButtons.OK,MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
         
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 1 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                biriciOyuncuSkor++;
                lblOyuncuBirSkor.Text = Convert.ToString(biriciOyuncuSkor);
                butonlarıDeaktifet();


            }
            //Oyuncu İki kazanması
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ikinciOyuncuSkor++;
                lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ikinciOyuncuSkor++;
                lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ikinciOyuncuSkor++;
                lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ikinciOyuncuSkor++;
                lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ikinciOyuncuSkor++;
               lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ikinciOyuncuSkor++;
               lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ikinciOyuncuSkor++;
                lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Oyuncu 2 Kazandı.", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ikinciOyuncuSkor++;
               lblOyoncuİkiSkor.Text = Convert.ToString(ikinciOyuncuSkor);
                butonlarıDeaktifet();


            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }
        //butonara tıklandığında hangi sembolü yazacağının belirledim ve her butonna basıldığında kazananın olup olmadığını kontrol ededen foksiyonu çağırdım
        private void button1_Click(object sender, EventArgs e)
        {
            if (kontrolcu==false)
            {
                button1.Text ="X";
                kontrolcu = true;

            }
            else
            {
                button1.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button1.Enabled = false;
            beraberlik();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button2.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button2.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button2.Enabled = false;
            beraberlik();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button3.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button3.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button3.Enabled = false;
            beraberlik();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button4.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button4.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button4.Enabled = false;
            beraberlik();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button5.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button5.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button5.Enabled = false;
            beraberlik();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button6.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button6.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button6.Enabled = false;
            beraberlik();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button7.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button7.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button7.Enabled = false;
            beraberlik();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button8.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button8.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button8.Enabled = false;
            beraberlik();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kontrolcu == false)
            {
                button9.Text = "X";
                kontrolcu = true;

            }
            else
            {
                button9.Text = "O";
                kontrolcu = false;
            }
            kazanma();
            button9.Enabled = false;
            beraberlik();
        }
        //tekrar başla tuşuna basınca butonları sıfırladım
        private void btnTekrarBasla_Click(object sender, EventArgs e)
        {
            kontrolcu = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
           
            button1.BackColor = Color.SandyBrown;
            button2.BackColor = Color.SandyBrown;
            button3.BackColor = Color.SandyBrown;
            button4.BackColor = Color.SandyBrown;
            button5.BackColor = Color.SandyBrown;
            button6.BackColor = Color.SandyBrown;
            button7.BackColor = Color.SandyBrown;
            button8.BackColor = Color.SandyBrown;
            button9.BackColor = Color.SandyBrown;




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            
           



        }
        //ana sayfaya dönmeyi sağladım
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        //yeni oyuna girince hem butonları hem skorları sıfırladım.
        private void btnYeniOyun_Click_1(object sender, EventArgs e)
        {
            kontrolcu = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            lblOyoncuİkiSkor.Text = "0";
            lblOyuncuBirSkor.Text = "0";
            biriciOyuncuSkor = 0;
            ikinciOyuncuSkor = 0;
            button1.BackColor = Color.SandyBrown;
            button2.BackColor = Color.SandyBrown;
            button3.BackColor = Color.SandyBrown;
            button4.BackColor = Color.SandyBrown;
            button5.BackColor = Color.SandyBrown;
            button6.BackColor = Color.SandyBrown;
            button7.BackColor = Color.SandyBrown;
            button8.BackColor = Color.SandyBrown;
            button9.BackColor = Color.SandyBrown;

        }
    }
}
