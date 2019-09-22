using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class New_Profile : Form
    {
        public New_Profile()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void New_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
