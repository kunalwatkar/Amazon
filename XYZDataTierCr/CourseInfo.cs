using System;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace XYZDataTierCr
{
    public interface IXYZDataTierCr
    {
        DataSet GetCoursesOffered();
        bool IsThereRoom(string CourseNum);
        DataSet GetCourseEnrollment(string CourseNum);
        void IncrementCourseCount(string CourseNum);
        void DecrementCourseCount(string CourseNum);
    }

    [ObjectPooling]
    public class CourseInfo : ServicedComponent, IXYZDataTierCr
    {
        static readonly string CONN_STRING =
            "Data Source=(localdb)\\MyInstance;Initial Catalog=StDb2SQL;Integrated Security=True";

        public CourseInfo()
        {
        }
        public DataSet GetCoursesOffered()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = CONN_STRING;
            cn.Open();

            SqlDataAdapter dAdapt = new SqlDataAdapter
                ("SELECT CourseNum from CoursesOffered", cn);
            DataSet myDS = new DataSet("Courses");
            dAdapt.Fill(myDS, "Courses");
            cn.Close();
            return myDS;
        }

        public bool IsThereRoom(string cnum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();

            string sqlstr = "Select NumRegistered, Capacity" +
                " from CoursesOffered where CourseNum='" +
                cnum + "'";
            SqlCommand cmd1 = new SqlCommand(sqlstr, con);
            SqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                int numRegistered = int.Parse(reader[0].ToString());
                int capacity = int.Parse(reader[1].ToString());
                if ((numRegistered) < capacity)
                    return true;
                else
                    return false;
            }
            return false;
        }


        public DataSet GetCourseEnrollment(string CourseNum)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = CONN_STRING;
            cn.Open();

            string sqlstr = "Select Students.FirstName, Students.LastName," +
                "Enrollment.CourseNum, Courses.CourseName from " +
                "Students, Enrollment, Courses " +
                "where Students.StudentID=Enrollment.StudentID" +
                " and Courses.CourseNum=Enrollment.CourseNum" +
                " and Enrollment.CourseNum='" + CourseNum + "'";
            SqlDataAdapter dAdapt = new SqlDataAdapter(sqlstr, cn);
            DataSet myDS = new DataSet();
            dAdapt.Fill(myDS);
            cn.Close();
            return myDS;
        }


        public void IncrementCourseCount(string CourseNum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();
            string sqlstr = "Update CoursesOffered set NumRegistered=" +
                "NumRegistered+1 where CourseNum='" +
                CourseNum + "'";
            SqlCommand cmd1 = new SqlCommand(sqlstr, con);
            int rowsAffected = cmd1.ExecuteNonQuery();
            if (rowsAffected != 1)
                throw new Exception("incorrect row update in CoursesOffered -inc. NumRegistered");
        }

        public void DecrementCourseCount(string CourseNum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();
            string sqlstr = "Update CoursesOffered set NumRegistered=" +
                "NumRegistered-1 where CourseNum='" +
                CourseNum + "'";
            SqlCommand cmd1 = new SqlCommand(sqlstr, con);
            int rowsAffected = cmd1.ExecuteNonQuery();
            if (rowsAffected != 1)
                throw new Exception("incorrect row update in CoursesOffered -dec. NumRegistered");
        }
    }
}
