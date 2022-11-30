using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_Framework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Box1.Text);   
            int number2 = Convert.ToInt32(Box2.Text);  

            int sum  = number1 + number2;

            FinalBox.Text = sum.ToString();
        }
    }
}
