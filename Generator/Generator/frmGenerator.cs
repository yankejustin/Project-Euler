using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Generator
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        private void btnLoadProblems_Click(object sender, EventArgs e)
        {
            // Loads all of the Project Euler Problems using the ProjectEulerFactory.

            // Each item will be iterated through a foreach loop and will be parsed
            //   into a tree node.
        }
    }
}