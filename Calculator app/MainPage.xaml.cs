using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        float res;
        float y;
        float x;
        bool[] operation = { false, false, false, false,false };
        public MainPage()
        {
            InitializeComponent();
        }
        private void NUM0(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "0";
            }
            else
            {
                RESULT.Text += "0";
            }
        }
        private void NUM1(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "1";
            }
            else
            {
                RESULT.Text += "1";
            }
        }
        private void NUM2(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "2";
            }
            else
            {
                RESULT.Text += "2";
            }
        }
        private void NUM3(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "3";
            }
            else
            {
                RESULT.Text += "3";
            }
        }
        private void NUM4(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "4";
            }
            else
            {
                RESULT.Text += "4";
            }
        }
        private void NUM5(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "5";
            }
            else
            {
                RESULT.Text += "5";
            }
        }
        private void NUM6(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "6";
            }
            else
            {
                RESULT.Text += "6";
            }
        }
        private void NUM7(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "7";
            }
            else
            {
                RESULT.Text += "7";
            }
        }
        private void NUM8(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "8";
            }
            else
            {
                RESULT.Text += "8";
            }
        }
        private void NUM9(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
            {
                RESULT.Text = "9";
            }
            else
            {
                RESULT.Text += "9";
            }
        }
        private void CLEAR(object sender, EventArgs e)
        {
            RESULT.Text = "0";
        }
        private void SIGN(object sender, EventArgs e)
        {
            if (RESULT.Text == "0")
                RESULT.Text = "-";
            else if(!RESULT.Text.Contains("-"))
                RESULT.Text = "-" + RESULT.Text;
        }
        private void DECIMAL(object sender, EventArgs e)
        {
            if (!RESULT.Text.Contains("."))
            {
                RESULT.Text += ".";
            }
        }
        private void ADD(object sender, EventArgs e)
        {
            x = float.Parse(RESULT.Text);
            operation[0] = true;
            operation[1] = false;
            operation[2] = false;
            operation[3] = false;
            operation[4] = false;
            RESULT.Text = "0";
        }
        private void SUB(object sender, EventArgs e)
        {
            x = float.Parse(RESULT.Text);
            operation[0] = false;
            operation[1] = true;
            operation[2] = false;
            operation[3] = false;
            operation[4] = false;
            RESULT.Text = "0";
        }
        private void MUL(object sender, EventArgs e)
        {
            x = float.Parse(RESULT.Text);
            operation[0] = false;
            operation[1] = false;
            operation[2] = true;
            operation[3] = false;
            operation[4] = false;
            RESULT.Text = "0";
        }
        private void DIV(object sender,EventArgs e)
        {
            x= float.Parse(RESULT.Text);
            operation[0] = false;
            operation[1] = false;
            operation[2] = false;
            operation[3] = true;
            operation[4] = false;
            RESULT.Text = "0";
        }
        private void MOD(object sender, EventArgs e)
        {
            x = float.Parse(RESULT.Text);
            operation[0] = false;
            operation[1] = false;
            operation[2] = false;
            operation[3] = false;
            operation[4] = true;
            RESULT.Text = "0";
        }
        private void EQUAL(object sender, EventArgs e)
        {
            y = float.Parse(RESULT.Text);
            if (operation[0] == true)
            {
                res = x + y;
            }
            if (operation[1] == true)
            {
                res = x - y;
            }
            if (operation[2] == true)
            {
                res = x * y;
            }
            if (operation[3] == true)
            {
                res = x / y;
            }
            if (operation[4] == true)
            {
                res = x % y;
            }
            RESULT.Text = res.ToString();
        }
    }
}
