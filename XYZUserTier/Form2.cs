using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZMidTier;

namespace XYZUserTier
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uid = txtUsername.Text;
            string passwd = txtPassword.Text;
            IXYZMidTier IMid = new MidInfo();
            bool login = IMid.Login(uid, passwd);
            if (login)
            //Application.Run(new Form1());
            {
                Form1 frm = new Form1();
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    frm.Close();
                }
            }
            else
                MessageBox.Show("Invalid Username or Password.");
        }
    }
}
