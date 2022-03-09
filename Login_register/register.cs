using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_register
{
    public partial class register : Form
    {
      
        
        public register()
        {
            InitializeComponent();
        }
         
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRregistarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
            
        }
    }
}
