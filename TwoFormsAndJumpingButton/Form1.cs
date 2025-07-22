using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFormsAndJumpingButton
{
    public partial class Form1 : Form
    {
        Form form2;
        Form form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
            Form2 frm = new Form2(form1);
            form2 = frm;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.Controls.Contains(button1))
            {
                form2.Controls.Add(button1);
            }
            else
            {
                form1.Controls.Add(button1);
            }
            
        }
    }
}
