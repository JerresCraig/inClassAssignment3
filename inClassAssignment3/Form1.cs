using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClassAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            string strWeight = textBox1.Text;
            double weight = double.Parse(strWeight);
            double marsWeight = (weight / 9.81) * 3.771;
            textBox2.Text = marsWeight.ToString();


        }
  
        //divide by 9.81
        //multiply by 3.771
      

    }
}
