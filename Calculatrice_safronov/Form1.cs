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

        public void Form1_Load(object sender, EventArgs e)
        {
            zt_Write.Text = null;
            zt_read.Text = null;

            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(WIN_CALC_KeyPress);
        }

        public void btn_0_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "0";
            this.ActiveControl = null;
            temp += "0";

        }

        public void btn_1_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "1";
            this.ActiveControl = null;
            temp += "1";
        }

        public void btn_2_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "2";
            this.ActiveControl = null;
            temp += "2";
        }

        public void btn_3_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "3";
            this.ActiveControl = null;
            temp += "3";
        }

        public void btn_4_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "4";
            this.ActiveControl = null;
            temp += "4";
        }

        public void btn_5_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "5";
            temp += "5";
            this.ActiveControl = null;
        }

        public void btn_6_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "6";
            temp += "6";
            this.ActiveControl = null;
        }

        public void btn_7_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "7";
            temp += "7";
            this.ActiveControl = null;
        }

        public void btn_8_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "8";
            this.ActiveControl = null;
            temp += "8";
        }

        public void btn_9_Click(object sender, EventArgs e)
        {
            zt_Write.Text += "9";
            temp += "9";
            this.ActiveControl = null;
        }

        public void btn_divise_Click(object sender, EventArgs e)
        {
            try
            {
                if (monResultat == null)
                {
                    monResultat = new Diviser();
                    monResultat.Operande1 = decimal.Parse(temp);
                }
                else if (monResultat.Operande1.HasValue)
                {
                    monResultat.Operande2 = decimal.Parse(temp);
                    if (monResultat.Operande2 == 0)
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
            catch(ArgumentNullException)
            {
                MessageBox.Show("Sans operandes l'operation est impossible");
                monResultat = null;
            }
            catch(FormatException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, vérifiez votre saisie");
                monResultat = null;
            }
        }

        public void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
                if (monResultat == null)
                {
                    monResultat = new Multiplier();
                    monResultat.Operande1 = decimal.Parse(temp);
                }
                else if (monResultat.Operande1.HasValue)
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
            catch(ArgumentNullException)
            {
                MessageBox.Show("Sans operandes l'operation est impossible");
                monResultat = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, vérifiez votre saisie");
                monResultat = null;
            }

        }

        public void btn_less_Click(object sender, EventArgs e)
        {
            try
            {
                if (monResultat == null)
                {
                    monResultat = new Soustraire();
                    monResultat.Operande1 = decimal.Parse(temp);
                }
                else if (monResultat.Operande1.HasValue)
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
            catch(ArgumentNullException)
            {
                MessageBox.Show("Sans operandes l'operation est impossible");
                monResultat = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, vérifiez votre saisie");
                monResultat = null;
            }
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (monResultat == null)
                {
                    monResultat = new Ajouter();
                    monResultat.Operande1 = decimal.Parse(temp);
                }
                else if (monResultat.Operande1.HasValue)
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
            catch (ArgumentNullException)
            {
                MessageBox.Show("Sans operandes l'operation est impossible");
                monResultat = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, vérifiez votre saisie");
                monResultat = null;
            }

        }

        public void btn_dot_Click(object sender, EventArgs e)
        {
            zt_Write.Text += ",";
            this.ActiveControl = null;
            temp += ",";
        }

        public void btn_reset_Click(object sender, EventArgs e)
        {
            zt_Write.Text = null;
            zt_read.Text = null;
            this.ActiveControl = null;
            temp = string.Empty;
            monResultat = null;
        }

        public void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                monResultat.Operande2 = decimal.Parse(temp);
                this.ActiveControl = null;
                decimal var1 = monResultat.Calculer();
                zt_read.Text = var1.ToString();
                temp = zt_read.Text;
                monResultat = null;

                zt_Write.Text = temp;
                zt_read.Text = temp;
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
            catch(NullReferenceException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, double égal est impossible!");
            }
           
        }

        public void WIN_CALC_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (e.KeyChar == '.')
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

        public void btn_carre_Click(object sender, EventArgs e)
        {
            try
            {
                if (monResultat == null)
                {
                    monResultat = new Carre();
                    monResultat.Operande1 = decimal.Parse(temp);
                }
                else if (monResultat.Operande1.HasValue)
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
            catch(FormatException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, vérifiez votre saisie");
                monResultat = null;
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Opérations sans opérandes est impossible!");
                monResultat = null;
            }

        }

        public void btn_PI_Click(object sender, EventArgs e)
        {
            // on test si c'est numero           
            decimal myInt;
            bool isNumerical = decimal.TryParse(zt_Write.Text, out myInt);

            //on test si la zone fichier est vide ou pas
            bool vide = String.IsNullOrEmpty(zt_Write.Text);

            //si la zone est vide, on initialise avec une valeur de "PI"
            if (vide == true)
            {  
                zt_Write.Text += "3,14";
                this.ActiveControl = null;
                temp += "3,14";
            }
            else
            {
                // sinon on test s'il est bien numérique, s'il n'est pas --> on initialise le champ à blanc
                if (isNumerical == false)
                {
                    //on vérifie qu'il s'agit d'une opération
                    if (zt_Write.Text.Contains('*') || zt_Write.Text.Contains('-') || zt_Write.Text.Contains('+') || zt_Write.Text.Contains('/') || zt_Write.Text.Contains('^'))
                    {
                        zt_Write.Text += "3,14";
                        this.ActiveControl = null;
                        temp += "3,14";
                    }
                    else
                    {
                        zt_Write.Text = null;
                    }
                }
                else
                {
                    zt_Write.Text = null;
                    zt_Write.Text = "3,14";
                    this.ActiveControl = null;
                    temp = "3,14";
                }
            }
        }

        public void btn_racine_Click(object sender, EventArgs e)
        {
            try {
                if (monResultat == null)
                {

                    monResultat = new RacineCarre();
                    monResultat.Operande1 = decimal.Parse(temp);
                    btn_equal_Click(btn_equal, new EventArgs());
                    zt_Write.Text = temp;
                    zt_read.Text = temp;

                }
                else if (monResultat.Operande1.HasValue)
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
            catch (ArgumentNullException)
            {
                MessageBox.Show("Racine carré de valeur null est impossible");
                monResultat = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Mauvaise manipulation de votre part, vérifiez votre saisie");
                monResultat = null;
            }
        }
    }
}
