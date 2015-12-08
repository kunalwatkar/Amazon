using System;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace XYZDataTierSt
{
    public interface IXYZDataTierSt
    {
        bool DoesStudentExist(int stID);
        bool HasPreRequisitesTaken(int stID, string CourseNum);
        void RegisterStInCourse(int stID, string CourseNum);
        bool IsAlreadyRegistered(int stID, string CourseNum);
        void UnRegisterStInCourse(int stID, string CourseNum);
        bool ValidateUser(string uid, string passwd);
    }


    [ObjectPooling]
    public class StudentInfo : ServicedComponent, IXYZDataTierSt
    {
        static readonly string CONN_STRING =
            "Data Source=(localdb)\\MyInstance;Initial Catalog=StDb2SQL;Integrated Security=True";

        public StudentInfo()
        {
        }

        public bool DoesStudentExist(int StID)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();

            string sqlstr = "Select * from Students where StudentID='"
                + StID + "'";
            SqlCommand cmd1 = new SqlCommand(sqlstr, con);
            object obj = cmd1.ExecuteScalar();// returns first col. of first row
            if (obj != null)
                return true;
            else
                return false;
        }

        /* -- the following code will not work as DataReader is a
		 * connected operation, so for the same connection, you
		 * cannot issue another SQL as long as DataReader object is
		 * alive
		public bool HasPreRequisitesTaken(int stID, string CourseNum)
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = CONN_STRING;
			con.Open();

			string sqlstr1 = "select Prereq_Cnum from Prerequisites" +
				" where CourseNum='" + CourseNum + "'";

			string sql2 = "Select grade from CoursesTaken" +
				" where StudentID=" + stID +
				" and CourseNum='";   // partial SQL
			
			SqlCommand cmd = new SqlCommand(sqlstr1,con);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())  // check grade in each prereq course
			{
				string cnm = reader[0].ToString();
				string sqlstr2 = sql2+cnm + "'";
				SqlCommand cmd2 = new SqlCommand(sqlstr2,con);
				object obj = cmd2.ExecuteScalar();// returns first col. of first row
				if (obj != null)
				{
					float grade = float.Parse(obj.ToString());
					if (grade < 1.0)  // minimum D is required
						return false;
				}
				else
					return false;
			}
			return true;
		}
		*/


        public bool HasPreRequisitesTaken(int stID, string CourseNum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();
            string sqlstr1 = "select Prereq_Cnum from Prerequisites" +
                " where CourseNum='" + CourseNum + "'";

            string sql2 = "Select grade from CoursesTaken" +
                " where StudentID=" + stID +
                " and CourseNum='";   // partial SQL

            //SqlCommand cmd = new SqlCommand(sqlstr1,con);
            //SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter dAdapt = new SqlDataAdapter(sqlstr1, con);
            DataSet myDS = new DataSet();
            dAdapt.Fill(myDS);
            DataTable dt = myDS.Tables[0];
            foreach (DataRow dr in dt.Rows)   // check grade in each prereq course
            {
                string cnm = dr[0].ToString();
                string sqlstr2 = sql2 + cnm + "'";
                SqlCommand cmd2 = new SqlCommand(sqlstr2, con);
                object obj = cmd2.ExecuteScalar();// returns first col. of first row
                if (obj != null)
                {
                    float grade = float.Parse(obj.ToString());
                    if (grade < 1.0)  // minimum D is required
                        return false;
                }
                else
                    return false;
            }
            return true;
        }

        public void RegisterStInCourse(int stID, string CourseNum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();

            string sqlstr = "INSERT INTO Enrollment(CourseNum,StudentID,SectionNum)" +
                " VALUES ('" + CourseNum + "'," +
                stID + ",1)";
            SqlCommand cmd1 = new SqlCommand(sqlstr, con);

            int rowsAffected = cmd1.ExecuteNonQuery();
            if (rowsAffected != 1)
                throw new Exception("incorrect row update in Enrollment -RegisterSt");
            con.Close();
        }

        public bool IsAlreadyRegistered(int StID, string CourseNum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();

            string sqlstr = "Select * from Enrollment where CourseNum='" + CourseNum +
                "' and StudentID=" + StID;

            SqlCommand cmd1 = new SqlCommand(sqlstr, con);
            object obj = cmd1.ExecuteScalar();// returns first col. of first row
            if (obj != null)
                return true;
            else
                return false;
        }


        public void UnRegisterStInCourse(int StID, string CourseNum)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();

            string sqlstr = "DELETE from Enrollment where CourseNum='" +
                CourseNum + "'" + " and StudentID=" + StID;

            SqlCommand cmd1 = new SqlCommand(sqlstr, con);

            int rowsAffected = cmd1.ExecuteNonQuery();
            if (rowsAffected != 1)
                throw new Exception("incorrect row update in Enrollment -UnRegisterSt");
            con.Close();
        }

        public bool ValidateUser(string uid, string passwd)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONN_STRING;
            con.Open();

            string sqlstr = "SELECT * from Users where Username='" +
                uid + "'" + " and Password='" + passwd + "'";

            SqlCommand cmd1 = new SqlCommand(sqlstr, con);
            object obj = cmd1.ExecuteScalar();// returns first col. of first row
            con.Close();
            if (obj != null)
                return true;
            else
                return false;
        }
    }
}
