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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IXYZMidTier IMid = new MidInfo();
            DataSet ds = IMid.GetCoursesOffered();
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows) // add to list box
            {
                lbCourses.Items.Add(dr[0].ToString());
                cbCoursesOffered.Items.Add(dr[0].ToString());
            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            IXYZMidTier IMid = new MidInfo();
            DataSet ds = IMid.GetCourseEnrollment(lbCourses.SelectedItem.ToString());
            DataTable dt = ds.Tables[0];
            //-- or DataTable dt = myDS.Tables[0];

            dg1.DataSource = ds.Tables[0].DefaultView;
            dg1.Refresh();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(txtStID.Text);
            string cnum = cbCoursesOffered.SelectedItem.ToString();
            IXYZMidTier IMid = new MidInfo();
            string res = IMid.CheckAndRegisterStInCourse(stid, cnum);
            MessageBox.Show(res);
        }
    }
}
