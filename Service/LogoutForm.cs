using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class LogoutForm : Form
    {
        public LogoutForm()
        {
            InitializeComponent();
        }

        private bool accept = false;



        public bool Accept { get { return accept; } }

        private void Acpt_Btn_Click(object sender, EventArgs e)
        {
            accept = true;
            this.Close();
        }

        private void Cncl_Btn_Click(object sender, EventArgs e)
        {
            accept = false;
            this.Close();
        }
    }
}
