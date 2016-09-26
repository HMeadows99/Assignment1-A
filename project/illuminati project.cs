using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FrmGreetings : Form
    {
        public FrmGreetings()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnIlluminati_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = ("Welcome to illuminati");
        }
    }
}
