using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFormsAndJumpingButton
{
    public partial class Form2 : Form
    {
        Form form2;
        Form form1;
        public Form2(Form frm)
        {
            InitializeComponent();
            form1 = frm;
            form2 = this;
        }
        //if (form1.Controls.Contains(button1))
        //    {
        //        form2.Controls.Add(button1);
        //    }
        //    else
        //    {
        //        form1.Controls.Add(button1);
        //    }
private void button2_Click(object sender, EventArgs e)
        {
            if (form1.Controls.Contains(textBox1))
            {
                form2.Controls.Add(textBox1);
            }
            else
            {
                form1.Controls.Add(textBox1);
            }

        }
    }
}
