using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_safronov
{
    public partial class WIN_CALC : Form
    {
        Calcul monResultat;
        string temp;

        public WIN_CALC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zt_Write.Text = null;
            zt_read.Text = null;

            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(WIN_CALC_KeyPress);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "0";
            this.ActiveControl = null;
            temp += "0";

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "1";
            this.ActiveControl = null;
            temp += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "2";
            this.ActiveControl = null;
            temp += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "3";
            this.ActiveControl = null;
            temp += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "4";
            this.ActiveControl = null;
            temp += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "5";
            temp += "5";
            this.ActiveControl = null;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "6";
            temp += "6";
            this.ActiveControl = null;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "7";
            temp += "7";
            this.ActiveControl = null;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "8";
            this.ActiveControl = null;
            temp += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "9";
            temp += "9";
            this.ActiveControl = null;
        }

        private void btn_divise_Click(object sender, EventArgs e)
        {

            if(monResultat == null)
            {
                monResultat = new Diviser();
                monResultat.Operande1 = decimal.Parse(temp);
            }
            else if (monResultat.Operande1.HasValue)
            { 
                 monResultat.Operande2 = decimal.Parse(temp);
                 if(monResultat.Operande2 == 0)
                {
                    MessageBox.Show("Division par zero est impossible");
                }
                else
                {
                    temp = monResultat.Calculer().ToString();
                    monResultat = new Diviser();
                    monResultat.Operande1 = decimal.Parse(temp);
                    zt_Write.Text = temp;
                    zt_read.Text = temp;
                }
                    
            }
           
                zt_Write.Text += "/";
                temp = string.Empty;
                this.ActiveControl = null;
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {

            if(monResultat == null)
            {
                monResultat = new Multiplier();
                monResultat.Operande1 = decimal.Parse(temp);
            }
            else if(monResultat.Operande1.HasValue)
            {
                monResultat.Operande2 = decimal.Parse(temp);
                temp = monResultat.Calculer().ToString();
                monResultat = new Multiplier();
                monResultat.Operande1 = decimal.Parse(temp);
                zt_Write.Text = temp;
                zt_read.Text = temp;
            }

            zt_Write.Text += "*";
            temp = string.Empty;
            this.ActiveControl = null;
        }

        private void btn_less_Click(object sender, EventArgs e)
        {

            if(monResultat == null)
            {
                monResultat = new Soustraire();
                monResultat.Operande1 = decimal.Parse(temp);
            }
            else if(monResultat.Operande1.HasValue)
            {
                monResultat.Operande2 = decimal.Parse(temp);
                temp = monResultat.Calculer().ToString();
                monResultat = new Soustraire();
                monResultat.Operande1 = decimal.Parse(temp);
                zt_Write.Text = temp;
                zt_read.Text = temp;
            }

            zt_Write.Text += "-";
            this.ActiveControl = null;
            temp = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(monResultat == null)
            {
                monResultat = new Ajouter();
                monResultat.Operande1 = decimal.Parse(temp);
            }
            else if(monResultat.Operande1.HasValue)
            {
                monResultat.Operande2 = decimal.Parse(temp);
                temp = monResultat.Calculer().ToString();
                monResultat = new Ajouter();
                monResultat.Operande1 = decimal.Parse(temp);
                zt_Write.Text = temp;
                zt_read.Text = temp;
            }

            zt_Write.Text += "+";
            temp = string.Empty;
            this.ActiveControl = null;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            zt_Write.Text += ",";
            this.ActiveControl = null;
            temp += ",";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            zt_Write.Text = null;
            zt_read.Text = null;
            this.ActiveControl = null;
            temp = string.Empty;
            monResultat = null;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            monResultat.Operande2 = decimal.Parse(temp);

            try
            {
                this.ActiveControl = null;
                zt_read.Text = monResultat.Calculer().ToString();
                temp = zt_read.Text;
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Division par zero est impossible...");
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Racine carré de valeur null est impossible");
            }
            catch(FormatException)
            {
                MessageBox.Show("Traitement sans valeur est impossible...");
            }
           
        }

        private void WIN_CALC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                btn_0_Click(btn_0, new EventArgs());
            }
            else if (e.KeyChar == '1')
            {
                btn_1_Click(btn_1, new EventArgs());
            }
            else if (e.KeyChar == '2')
            {
                btn_2_Click(btn_2, new EventArgs());
            }
            else if (e.KeyChar == '3')
            {
                btn_3_Click(btn_3, new EventArgs());
            }
            else if (e.KeyChar == '4')
            {
                btn_4_Click(btn_4, new EventArgs());
            }
            else if (e.KeyChar == '5')
            {
                btn_5_Click(btn_5, new EventArgs());
            }
            else if (e.KeyChar == '6')
            {
                btn_6_Click(btn_6, new EventArgs());
            }
            else if (e.KeyChar == '7')
            {
                btn_7_Click(btn_7, new EventArgs());
            }
            else if (e.KeyChar == '8')
            {
                btn_8_Click(btn_8, new EventArgs());
            }
            else if (e.KeyChar == '9')
            {
                btn_9_Click(btn_9, new EventArgs());
            }
            else if (e.KeyChar == ',')
            {
                btn_dot_Click(btn_dot, new EventArgs());
            }
            else if (e.KeyChar == '+')
            {
                btn_add_Click(btn_add, new EventArgs());
            }
            else if (e.KeyChar == '-')
            {
                btn_less_Click(btn_less, new EventArgs());
            }
            else if (e.KeyChar == '*')
            {
                btn_multi_Click(btn_multi, new EventArgs());
            }
            else if (e.KeyChar == '/')
            {
                btn_divise_Click(btn_divise, new EventArgs());
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;          
                btn_equal_Click(btn_equal, new EventArgs());
            }
        }

        private void btn_carre_Click(object sender, EventArgs e)
        {
            if(monResultat == null)
            {
                monResultat = new Carre();
                monResultat.Operande1 = decimal.Parse(temp);
            }
            else if(monResultat.Operande1.HasValue)
            {
                monResultat.Operande2 = decimal.Parse(temp);
                temp = monResultat.Calculer().ToString();
                monResultat = new Carre();
                monResultat.Operande1 = decimal.Parse(temp);
                zt_Write.Text = temp;
                zt_Write.Text = temp;
            }

            zt_Write.Text += "^";
            temp = string.Empty;
            this.ActiveControl = null;
        }

        private void btn_PI_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "3,14";
            this.ActiveControl = null;
            temp += "3,14";
        }

        private void btn_racine_Click(object sender, EventArgs e)
        {
            if (monResultat == null)
            {
                try
                {
                    monResultat = new RacineCarre();
                    monResultat.Operande1 = decimal.Parse(temp);
                    btn_equal_Click(btn_equal, new EventArgs());
                    zt_Write.Text = temp;
                    zt_read.Text = temp;
                }
                catch(ArgumentNullException)
                {
                    MessageBox.Show("Racine carré de valeur null est impossible");
                }
                 
            }
            else if(monResultat.Operande1.HasValue)
            {
                temp = monResultat.Calculer().ToString();
                monResultat = new RacineCarre();
                monResultat.Operande1 = decimal.Parse(temp);
                zt_Write.Text = temp;
                zt_read.Text = temp;
                btn_equal_Click(btn_equal, new EventArgs());
            }
            this.ActiveControl = null;
        }
    }
}
