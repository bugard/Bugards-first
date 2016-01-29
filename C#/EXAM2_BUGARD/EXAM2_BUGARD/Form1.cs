using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM2_BUGARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                int fromCurrency = int.Parse(txtAmount.Text);
                double conversedCurrency;

                if (radFromUs.Checked == true)
                {
                    if (radToUs.Checked == true)
                    {
                        conversedCurrency = fromCurrency;
                        lblResult.Text = fromCurrency + " U.S. Dollars is equal to " +
                            conversedCurrency.ToString("0.00") + " U.S. Dollars";
                        lblResult.Visible = true;
                    }
                    else if (radToEuros.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 0.917114;
                        lblResult.Text = fromCurrency + " U.S. Dollars is equal to " +
                            conversedCurrency.ToString("0.00") + " Euros";
                        lblResult.Visible = true;
                    }
                    else if (radToBritish.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 0.672924;
                        lblResult.Text = fromCurrency + " U.S. Dollars is equal to " +
                            conversedCurrency.ToString("0.00") + " British Pounds";
                        lblResult.Visible = true;
                    }
                    else if (radToMexican.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 14.9394;
                        lblResult.Text = fromCurrency + " U.S. Dollars is equal to " +
                            conversedCurrency.ToString("0.00") + " Mexican Pesos";
                        lblResult.Visible = true;
                    }
                }//End of From US conversion

                if (radFromEuros.Checked == true)
                {
                    if (radToEuros.Checked == true)
                    {
                        conversedCurrency = fromCurrency;
                        lblResult.Text = fromCurrency + " Euros is equal to " +
                            conversedCurrency.ToString("0.00") + " Euros";
                        lblResult.Visible = true;
                    }
                    else if (radToUs.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 1.09062;
                        lblResult.Text = fromCurrency + " Euros is equal to " +
                            conversedCurrency.ToString("0.00") + " U.S. Dollars";
                        lblResult.Visible = true;
                    }
                    else if (radToBritish.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 0.733714;
                        lblResult.Text = fromCurrency + " Euros is equal to " +
                            conversedCurrency.ToString("0.00") + " British Pounds";
                        lblResult.Visible = true;
                    }
                    else if (radToMexican.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 16.2905;
                        lblResult.Text = fromCurrency + " Euros is equal to " +
                            conversedCurrency.ToString("0.00") + " Mexican Pesos";
                        lblResult.Visible = true;
                    }
                }//End of From Euros conversion

                if (radFromBritish.Checked == true)
                {
                    if (radToEuros.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 1.36307;
                        lblResult.Text = fromCurrency + " British Pounds is equal to " +
                            conversedCurrency.ToString("0.00") + " Euros";
                        lblResult.Visible = true;
                    }
                    else if (radToUs.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 1.48655;
                        lblResult.Text = fromCurrency + " British Pounds is equal to " +
                            conversedCurrency.ToString("0.00") + " U.S. Dollars";
                        lblResult.Visible = true;
                    }
                    else if (radToBritish.Checked == true)
                    {
                        conversedCurrency = fromCurrency;
                        lblResult.Text = fromCurrency + " British Pounds is equal to " +
                            conversedCurrency.ToString("0.00") + " British Pounds";
                        lblResult.Visible = true;
                    }
                    else if (radToMexican.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 22.1978;
                        lblResult.Text = fromCurrency + " British Pounds is equal to " +
                            conversedCurrency.ToString("0.00") + " Mexican Pesos";
                        lblResult.Visible = true;
                    }
                }//End of From British conversion

                if (radFromMexican.Checked == true)
                {
                    if (radToEuros.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 0.0614037;
                        lblResult.Text = fromCurrency + " Mexican Pesos is equal to " +
                            conversedCurrency.ToString("0.00") + " Euros";
                        lblResult.Visible = true;
                    }
                    else if (radToUs.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 0.0669428;
                        lblResult.Text = fromCurrency + " Mexican Pesos is equal to " +
                            conversedCurrency.ToString("0.00") + " U.S. Dollars";
                        lblResult.Visible = true;
                    }
                    else if (radToBritish.Checked == true)
                    {
                        conversedCurrency = fromCurrency * 0.0450464;
                        lblResult.Text = fromCurrency + " Mexican Pesos is equal to " +
                            conversedCurrency.ToString("0.00") + " British Pounds";
                        lblResult.Visible = true;
                    }
                    else if (radToMexican.Checked == true)
                    {
                        conversedCurrency = fromCurrency;
                        lblResult.Text = fromCurrency + " Mexican Pesos is equal to " +
                            conversedCurrency.ToString("0.00") + " Mexican Pesos";
                        lblResult.Visible = true;
                    }
                }//End of From Mexican conversion
            }//end of checking for input
            else
            {
                MessageBox.Show("No data was entered");
            }
        }
    }
}
