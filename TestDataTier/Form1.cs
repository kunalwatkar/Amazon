using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZDataTierCr;
using XYZDataTierSt;

namespace TestDataTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCourseEnrollment_Click(object sender, EventArgs e)
        {
            IXYZDataTierCr ICr = new CourseInfo();
            DataSet ds = ICr.GetCourseEnrollment("ee510");
            DataTable dt = ds.Tables[0];
            //-- or DataTable dt = myDS.Tables[0];

            dg1.DataSource = ds.Tables[0].DefaultView;
            dg1.Refresh();

        }

        private void btnIsThereRoom_Click(object sender, EventArgs e)
        {
            IXYZDataTierCr ICr = new CourseInfo();
            if (ICr.IsThereRoom("cs440") == true)
                MessageBox.Show("room in course");
            else
                MessageBox.Show("No Room in Course");

        }

        private void btnTestDataTierGetCoursesOffered_Click(object sender, EventArgs e)
        {
            IXYZDataTierCr ICr = new CourseInfo();
            DataSet ds = ICr.GetCoursesOffered();
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows) // add to list box
            {
                lstCourses.Items.Add(dr[0].ToString());
            }

        }

        private void btnDoesStudentExist_Click(object sender, EventArgs e)
        {
            XYZDataTierSt.IXYZDataTierSt ISt = new StudentInfo();
            if (ISt.DoesStudentExist(60208) == true)
                MessageBox.Show("student exists");
            else
                MessageBox.Show("student does not exist");
        }

        private void btnHasPrerequisitesTaken_Click(object sender, EventArgs e)
        {
            IXYZDataTierSt ISt = new StudentInfo();
            if (ISt.HasPreRequisitesTaken(80186, "CS555") == true)
                MessageBox.Show("prereqs taken");
            else
                MessageBox.Show("prereqs not taken");

        }
    }
}
