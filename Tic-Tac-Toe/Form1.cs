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
    public partial class Form : System.Windows.Forms.Form
    {
        char jatekos = 'x';
        int lepesek = 0;
        int x = 0;
        int o = 0;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            if (jatekos == 'x')
            {
                btn.BackColor = Color.Red;
                btn.Text = "x";
                if (Dontes(btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9))
                {
                    MessageBox.Show("Az x játékos nyerte a kört!");
                    x++;
                    lblX.Text = $"x győzelem : {x}";
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                }
                jatekos = 'o';
            }
            else if (jatekos == 'o')
            {
                btn.BackColor = Color.Green;
                btn.Text = "o";
                if (Dontes(btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9))
                {
                    MessageBox.Show("Az o játékos nyerte a kört!");
                    o++;
                    lblO.Text = $"o győzelem : {o}";
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                }
                jatekos = 'x';
            }
            lepesek++;
            if (lepesek == 9)
            {
                MessageBox.Show("Döntetlen!");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
        }

        private void btnTörlés_Click(object sender, EventArgs e)
        {
            x = 0;
            o = 0;
            lblX.Text = $"x győzelem : {x}";
            lblO.Text = $"o győzelem : {o}";
        }

        private void ujJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jatekos = 'x';
            lepesek = 0;
            btn1.Text = ""; btn1.BackColor = SystemColors.Control; btn1.Enabled = true;
            btn2.Text = ""; btn2.BackColor = SystemColors.Control; btn2.Enabled = true;
            btn3.Text = ""; btn3.BackColor = SystemColors.Control; btn3.Enabled = true;
            btn4.Text = ""; btn4.BackColor = SystemColors.Control; btn4.Enabled = true;
            btn5.Text = ""; btn5.BackColor = SystemColors.Control; btn5.Enabled = true;
            btn6.Text = ""; btn6.BackColor = SystemColors.Control; btn6.Enabled = true;
            btn7.Text = ""; btn7.BackColor = SystemColors.Control; btn7.Enabled = true;
            btn8.Text = ""; btn8.BackColor = SystemColors.Control; btn8.Enabled = true;
            btn9.Text = ""; btn9.BackColor = SystemColors.Control; btn9.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void szabalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A két játékos X és O alakú jelekkel (bábukkal) játszik. A 3×3 mezőből álló táblára felváltva teszik le a jeleiket, bármelyik még szabad mezőre. Az nyer, akinek sikerül egy vonalban 3 jelet elhelyeznie, vízszintes, függőleges vagy átlós irányban.");
        }

        public bool Dontes(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, Button btn7, Button btn8, Button btn9)
        {
            if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                        (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                        (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                        (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                        (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                        (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                        (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                        (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
