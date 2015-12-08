using System;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using XYZDataTierCr;
using XYZDataTierSt;

namespace XYZMidTier
{

    public interface IXYZMidTier
    {
        string CheckAndRegisterStInCourse(int StID, string CourseNum);
        DataSet GetCoursesOffered();
        DataSet GetCourseEnrollment(string cnum);
        bool Login(string uid, string passwd);
    }

    public class MidInfo : ServicedComponent, IXYZMidTier
    {
        public MidInfo()
        {
        }

        public DataSet GetCoursesOffered()
        {
            IXYZDataTierCr ICr = new CourseInfo();
            DataSet ds = ICr.GetCoursesOffered();
            return ds;
        }

        public DataSet GetCourseEnrollment(string cnum)
        {
            IXYZDataTierCr ICr = new CourseInfo();
            DataSet ds = ICr.GetCourseEnrollment(cnum);
            return ds;
        }

        public string CheckAndRegisterStInCourse(int stID, string CourseNum)
        {
            string res;
            IXYZDataTierSt ISt = new StudentInfo();
            IXYZDataTierCr ICr = new CourseInfo();
            if (ISt.DoesStudentExist(stID) == true)
                if (ISt.IsAlreadyRegistered(stID, CourseNum) == false)
                {
                    if (ISt.HasPreRequisitesTaken(stID, CourseNum) == true)
                    {
                        if (ICr.IsThereRoom(CourseNum) == true)
                        {
                            ISt.RegisterStInCourse(stID, CourseNum);
                            res = "You are successfully registered";
                        }
                        else
                            res = " Not enough room in Course";
                    }
                    else
                        res = "Not enough prerequisites taken";
                }
                else res = "Student Already Registered for this Course";
            else res = "Student does not exist in Students Table";
            return res;
        }

        public bool Login(string uid, string passwd)
        {
            IXYZDataTierSt ISt = new StudentInfo();
            return ISt.ValidateUser(uid, passwd);
        }
    }
}
