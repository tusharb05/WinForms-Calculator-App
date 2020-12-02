using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_GUI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "9";
        }


        private bool isAddClicked = false;
        private string first_num_add;
        private void addition_button_Click(object sender, EventArgs e)
        {
            this.first_num_add = textBox1.Text;
            this.isAddClicked = true;

            textBox1.Clear();
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            if(this.isAddClicked)
            {
                int f_num = Convert.ToInt32(this.first_num_add);
                int s_num = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(f_num + s_num);
            }
            else if (this.isSubtractClicked)
            {
                int f_num = Convert.ToInt32(this.first_num_subtract);
                int s_num = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(f_num - s_num);
            }
            else if (this.isMultipyClicked)
            {
                int f_num = Convert.ToInt32(this.first_number_multiply);
                int s_num = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(f_num * s_num);
            }
            else if (this.isDivideClicked)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(first_num_divide) / Convert.ToInt32(textBox1.Text));
            }
        }

        private bool isSubtractClicked = false;
        private string first_num_subtract;
        private void subtraction_button_Click(object sender, EventArgs e)
        {
            this.isSubtractClicked = true;
            this.first_num_subtract = textBox1.Text;
            textBox1.Clear();
        }

        private bool isMultipyClicked = false;
        private string first_number_multiply;
        private void multiply_button_Click(object sender, EventArgs e)
        {
            this.isMultipyClicked = true;
            this.first_number_multiply = textBox1.Text;
            textBox1.Clear();
        }

        private bool isDivideClicked = false;
        private string first_num_divide;
        private void divide_button_Click(object sender, EventArgs e)
        {
            this.isDivideClicked = true;
            this.first_num_divide = textBox1.Text;
            textBox1.Clear();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            string previous_string = textBox1.Text;
            textBox1.Text = previous_string + "0";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
