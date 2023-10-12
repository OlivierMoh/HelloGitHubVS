using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloGitHubVS
{
    public partial class HelloGitHubVSForm : Form
    {
        public HelloGitHubVSForm()
        {
            InitializeComponent();
        }

        private void HelloGitHubButton_Click(object sender, EventArgs e)
        {
            Font newPolice = new Font("Cascadia Code", 10);

            MessageBox.Show("Hello GitHub");


        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
