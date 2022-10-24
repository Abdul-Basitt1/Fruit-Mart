using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Fruit_Mart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void applecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (applecheckBox.Checked == true)
            {
                applequantity.Enabled = true;  
                applequality.Enabled= true;
            }
            else
            {
                applequantity.Enabled = false;
                applequality.Enabled= false;
            }
        }

        private void orangecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (orangecheckBox.Checked == true)
            {
                orangequantity.Enabled = true;
                orangequality.Enabled = true;
            }
            else
            {
                orangequantity.Enabled = false;
                orangequality.Enabled = false;
            }
        }

        private void mangocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mangocheckBox.Checked == true)
            {
                mangoquantity.Enabled = true;
                mangoquality.Enabled = true;
            }
            else
            {
                mangoquantity.Enabled = false;
                mangoquality.Enabled = false;
            }
        }

        private void peachcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (peachcheckBox.Checked == true)
            {
                peachquantity.Enabled = true;
                peachquality.Enabled = true;
            }
            else
            {
                peachquantity.Enabled = false;
                peachquality.Enabled = false;
            }
        }

        private void pineapplecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pineapplecheckBox.Checked == true)
            {
                pineapplequantity.Enabled = true;
                pineapplequality.Enabled = true;
            }
            else
            {
                pineapplequantity.Enabled = false;
                pineapplequality.Enabled = false;
            }
        }

        private void strawberrycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (strawberrycheckBox.Checked == true)
            {
                strawberryquantity.Enabled = true;
                strawberryquality.Enabled = true;
            }
            else
            {
                strawberryquantity.Enabled = false;
                strawberryquality.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            applecheckBox.Checked = false;
            orangecheckBox.Checked = false;
            mangocheckBox.Checked = false;
            peachcheckBox.Checked = false;
            pineapplecheckBox.Checked = false;
            strawberrycheckBox.Checked = false;
            applequantity.Value = 0;
            orangequantity.Value = 0;
            mangoquantity.Value = 0;
            peachquantity.Value = 0;
            pineapplequantity.Value = 0;
            strawberryquantity.Value = 0;
            applequality.Text = "Select";
            orangequality.Text = "Select";
            mangoquality.Text = "Select";
            peachquality.Text = "Select";
            pineapplequality.Text = "Select";
            strawberryquality.Text = "Select";
            label59.Text = ("0");
            label62.Text = ("0");
            label66.Text = ("0");
            label64.Text = ("0");
            label70.Text = ("0");
            label68.Text = ("0");
            label43.Text = ("0");
            label45.Text = ("0");
            label72.Text = ("0");
            label74.Text = ("0");
            label76.Text = ("0");
            label80.Text = ("0");
            label82.Text = ("0");
            label78.Text = ("0");
            label32.Text = ("0");
            label38.Text = ("0");
            label36.Text = ("0");
            panel1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void applequantity_ValueChanged(object sender, EventArgs e)
        {
            if(applequantity.Value == 0)
            {
                applequantity.Increment = 1;
            }
            else if(applequantity.Value == 1)
            {
                applequantity.Increment = 2;
            }
            
        }

        private void orangequantity_ValueChanged(object sender, EventArgs e)
        {
            if (orangequantity.Value == 0)
            {
                orangequantity.Increment = 1;
            }
            else if (orangequantity.Value == 1)
            {
                orangequantity.Increment = 2;
            }
        }

        private void mangoquantity_ValueChanged(object sender, EventArgs e)
        {
            if (mangoquantity.Value == 0)
            {
                mangoquantity.Increment = 1;
            }
            else if (mangoquantity.Value == 1)
            {
                mangoquantity.Increment = 2;
            }
        }

        private void peachquantity_ValueChanged(object sender, EventArgs e)
        {
            if (peachquantity.Value == 0)
            {
                peachquantity.Increment = 1;
            }
            else if (peachquantity.Value == 1)
            {
                peachquantity.Increment = 2;
            }
        }

        private void pineapplequantity_ValueChanged(object sender, EventArgs e)
        {
            if (pineapplequantity.Value == 0)
            {
                pineapplequantity.Increment = 1;
            }
            else if (pineapplequantity.Value == 1)
            {
                pineapplequantity.Increment = 2;
            }
        }

        private void strawberryquantity_ValueChanged(object sender, EventArgs e)
        {
            if (strawberryquantity.Value == 0)
            {
                strawberryquantity.Increment = 1;
            }
            else if (strawberryquantity.Value == 1)
            {
                strawberryquantity.Increment = 2;
            }
        }

        private void label59_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(applecheckBox.Checked == false && orangecheckBox.Checked == false && mangocheckBox.Checked == false && peachcheckBox.Checked == false && pineapplecheckBox.Checked == false && strawberrycheckBox.Checked == false)
            {
                MessageBox.Show("Basket Empty! Select Items First");
                return;
            }
           // int applehigh = 200;
           // int applemedium
            int kgapple = Convert.ToInt32(applequantity.Value);
            int kgorange = Convert.ToInt32(orangequantity.Value);
            int kgmango = Convert.ToInt32(mangoquantity.Value);
            int kgpeach = Convert.ToInt32(peachquantity.Value);
            int kgpineapple = Convert.ToInt32(pineapplequantity.Value);
            int kgstrawberry = Convert.ToInt32(strawberryquantity.Value);
            label59.Text = kgapple.ToString();
            label62.Text = kgorange.ToString();
            label66.Text = kgmango.ToString();
            label64.Text = kgpeach.ToString();
            label70.Text = kgpineapple.ToString();
            label68.Text = kgstrawberry.ToString();
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string time = DateTime.Now.ToString("h:mm:ss tt");
            label43.Text = date;
            label45.Text = time;
            

            if (applecheckBox.Checked == true)
            {
                if (applequality.SelectedItem == null)
                {
                    MessageBox.Show("Please Select Quality!");
                    return;
                }
                else if (applequality.SelectedItem == "High")
                {
                    if(applequantity.Value == 1)
                    {
                        label72.Text = ("200").ToString();
                    }
                    else if(applequantity.Value == 3)
                    {
                        label72.Text = (200*3).ToString();
                    }
                    else if(applequantity.Value == 5)
                    {
                        label72.Text = (200 * 5).ToString();
                    }
                    
                }
                else if (applequality.SelectedItem == "Medium")
                {
                    if (applequantity.Value == 1)
                    {
                        label72.Text = ("150").ToString();
                    }
                    else if (applequantity.Value == 3)
                    {
                        label72.Text = (150 * 3).ToString();
                    }
                    else if (applequantity.Value == 5)
                    {
                        label72.Text = (150 * 5).ToString();
                    }
                }
            }
            
            if(orangecheckBox.Checked == true)
            {
                if (orangequality.SelectedItem == null)
                {
                    MessageBox.Show("Please Select Quality!");
                    return ;
                }
                else if (orangequality.SelectedItem == "High")
                {
                    if (orangequantity.Value == 1)
                    {
                        label74.Text = ("300").ToString();
                    }
                    else if (orangequantity.Value == 3)
                    {
                        label74.Text = (300 * 3).ToString();
                    }
                    else if (orangequantity.Value == 5)
                    {
                        label74.Text = (300 * 5).ToString();
                    }
                }
                else if (orangequality.SelectedItem == "Medium")
                {
                    if (orangequantity.Value == 1)
                    {
                        label74.Text = ("200").ToString();
                    }
                    else if (orangequantity.Value == 3)
                    {
                        label74.Text = (200 * 3).ToString();
                    }
                    else if (orangequantity.Value == 5)
                    {
                        label74.Text = (200 * 5).ToString();
                    }
                }
            }

            if (mangocheckBox.Checked == true)
            {
                if (mangoquality.SelectedItem == null)
                {
                    MessageBox.Show("Please Select Quality!");
                    return;
                }
                else if (mangoquality.SelectedItem == "High")
                {
                    if (mangoquantity.Value == 1)
                    {
                        label78.Text = ("150").ToString();
                    }
                    else if (mangoquantity.Value == 3)
                    {
                        label78.Text = (150 * 3).ToString();
                    }
                    else if (mangoquantity.Value == 5)
                    {
                        label78.Text = (150 * 5).ToString();
                    }
                }
                else if (mangoquality.SelectedItem == "Medium")
                {
                    if (mangoquantity.Value == 1)
                    {
                        label78.Text = ("120").ToString();
                    }
                    else if (mangoquantity.Value == 3)
                    {
                        label78.Text = (120 * 3).ToString();
                    }
                    else if (mangoquantity.Value == 5)
                    {
                        label78.Text = (120 * 5).ToString();
                    }
                }
            }

            if (peachcheckBox.Checked == true)
            {
                if (peachquality.SelectedItem == null)
                {
                    MessageBox.Show("Please Select Quality!");
                    return;
                }
                else if (peachquality.SelectedItem == "High")
                {
                    if (peachquantity.Value == 1)
                    {
                        label76.Text = ("250").ToString();
                    }
                    else if (peachquantity.Value == 3)
                    {
                        label76.Text = (250 * 3).ToString();
                    }
                    else if (peachquantity.Value == 5)
                    {
                        label76.Text = (250 * 5).ToString();
                    }
                }
                else if (peachquality.SelectedItem == "Medium")
                {
                    if (peachquantity.Value == 1)
                    {
                        label76.Text = ("200").ToString();
                    }
                    else if (peachquantity.Value == 3)
                    {
                        label76.Text = (200 * 3).ToString();
                    }
                    else if (peachquantity.Value == 5)
                    {
                        label76.Text = (200 * 5).ToString();
                    }
                }
            }

            if (pineapplecheckBox.Checked == true)
            {
                if (pineapplequality.SelectedItem == null)
                {
                    MessageBox.Show("Please Select Quality!");
                    return;
                }
                else if (pineapplequality.SelectedItem == "High")
                {
                    if (pineapplequantity.Value == 1)
                    {
                        label82.Text = ("1000").ToString();
                    }
                    else if (pineapplequantity.Value == 3)
                    {
                        label82.Text = (1000 * 3).ToString();
                    }
                    else if (pineapplequantity.Value == 5)
                    {
                        label82.Text = (1000 * 5).ToString();
                    }
                }
                else if (pineapplequality.SelectedItem == "Medium")
                {
                    if (pineapplequantity.Value == 1)
                    {
                        label82.Text = ("800").ToString();
                    }
                    else if (pineapplequantity.Value == 3)
                    {
                        label82.Text = (800 * 3).ToString();
                    }
                    else if (pineapplequantity.Value == 5)
                    {
                        label82.Text = (800 * 5).ToString();
                    }
                }
            }

            if (strawberrycheckBox.Checked == true)
            {
                if (strawberryquality.SelectedItem == null)
                {
                    MessageBox.Show("Please Select Quality!");
                    return;
                }
                else if (strawberryquality.SelectedItem == "High")
                {
                    if (strawberryquantity.Value == 1)
                    {
                        label80.Text = ("90").ToString();
                    }
                    else if (strawberryquantity.Value == 3)
                    {
                        label80.Text = (90 * 3).ToString();
                    }
                    else if (strawberryquantity.Value == 5)
                    {
                        label80.Text = (90 * 5).ToString();
                    }

                }
                else if (strawberryquality.SelectedItem == "Medium")
                {
                    if (strawberryquantity.Value == 1)
                    {
                        label80.Text = ("60").ToString();
                    }
                    else if (strawberryquantity.Value == 3)
                    {
                        label80.Text = (60 * 3).ToString();
                    }
                    else if (strawberryquantity.Value == 5)
                    {
                        label80.Text = (60 * 5).ToString();
                    }
                }
            }

            int a = int.Parse(label72.Text);
            int b = int.Parse(label80.Text);
            int c = int.Parse(label82.Text);
            int d = int.Parse(label76.Text);
            int e1 = int.Parse(label74.Text);
            int f = int.Parse(label78.Text);
            //int subtotal = int.Parse(label80.Text + label82.Text + label76.Text + label74.Text + label72.Text + label78.Text);
            int sub = a + b + c + d + e1 + f;
            label36.Text = sub.ToString();

            if(radioButton1.Checked == true)
            {
                label32.Text = ("20").ToString();
            }
            else
            {
                label32.Text = ("0").ToString();
            }

            int bag = int.Parse(label32.Text);
            int total = sub + bag;
            label38.Text = total.ToString();
            panel1.Visible = true;

            
        }


    }
}

