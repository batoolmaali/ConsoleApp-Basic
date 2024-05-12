using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic2
{
    public class Employee
    {
        public string firstname;
        public string lastname;

        // Method

        public string getFullName(string _fname, string _lname)
        {
            return "Hello " + _fname + " " + _lname;
        }
        //public string getFullName(int age, string _lname)
        //{
        //    return "Hello " + age + " " + _lname;
        //}
        public string getFullName(string _fname, string _Mname, string _lname)
        {
            return "Hi " + _fname + " " + _Mname + " " + _lname;
        }
        public double calcAvg(double _m1, double _m2, double _m3)
        {
            double avg = ((_m1 + _m2 + _m3) / 3);
            return avg;
        }



        //public string calcAvg(double _m1, double _m2, double _m3, double _m4)
        //{

        //    double avg = ((_m1 + _m2 + _m3) / 3);
        //    string status = "";
        //    switch (avg)
        //    {
        //        case >= 50 and <= 68:

        //            status = "failed";
        //            break;
        //        case >= 68 and < 75:
        //            status = "good";
        //            break;
        //        case >= 75 and < 85:
        //            status = "vgood";
        //            break;
        //        case >= 85:
        //            status = "exellent";
        //            break;

        //        default:
        //            status = "out of range";
        //            break;
        //    }
        //    return "avg is: " + avg + " status is : " + status;
        //}

    }
}


