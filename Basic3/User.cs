using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Basic3
{
    public class User
    {
        //Fields
        public string FirtName;
        public string LastName;

        // Method
        public string FullName(string _fname, string _lname)
        {
            string Full = _fname + " " + _lname;
            return "Hello from function " + Full;
        }

        // method overloading, multiple methods can have the same name with
        // different parameters (type or number of parameters)

        // 1 different  number of parameters

        public string FullName(string _fname, string _mdname, string _lname)
        {
            string Full = _fname + " " + _mdname + " " + _lname;
            return "function overloading 3parameters " + Full;
        }
        // 2 different  type of parameters

        public string FullName(string _fname, double _mark)
        {
            string Full = _fname + " your mark is " + _mark;
            return "function overloading different type " + Full;
        }

        public double calcAvg(double _m1, double _m2, double _m3)
        {

            double avg = ((_m1 + _m2 + _m3) / 3);
            return avg;
        }
        // if return string , you should put type of method string
        public string calcAvgAndStatus(double _m1, double _m2, double _m3)
        {

            double avg = ((_m1 + _m2 + _m3) / 3);
            string status = " ";
            if (avg >= 80)
            {
                status = "excellent";
            }
            else if (avg < 80 && avg >= 70)
            {
                status = "very good";
            }
            else if (avg < 70 && avg >= 60)
            {
                status = "good";
            }
            else if (avg < 60 && avg >= 50)
            {
                status = "poor grade";
            }
            else if (avg < 50)
            {
                status = "failed";
            }
            return "your Avg is " + avg + " your status is " + status;
        }

        // switch

        public string Weather(int _temperature)
        {
            string temp = "";
            switch (_temperature)
            {
                case >= 25:
                    temp = " Hot";
                    break;
                case < 25 and >= 20:
                    temp = " it's Warm";
                    break;
                case < 20 and >= 15:
                    temp = " it's Cool";
                    break;
                case < 15 and >= 10:
                    temp = " it's Cold";
                    break;
                case < 10:
                    temp = "it's very Cold";
                    break;

                default:
                    temp = "out of range";
                    break;
            }

            return " the temperature is  " + _temperature + " " + temp;

        }





    }


}
