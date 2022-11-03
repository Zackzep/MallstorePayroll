using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_MallStores
{
    public class Manager
    {
        //Fields
        string _mfirstName;
        string _mlastName;
        double _myearlySalary;

        //Constructor
        public Manager(string mfirstName, string mlastName, double myearlySalary)
        {
            _mfirstName = mfirstName;
            _mlastName = mlastName;
            _myearlySalary = myearlySalary;
        }

        //Properties
        public string MfirstName
        {
            get { return _mfirstName; }
            set { _mfirstName = value; }
        }
        public string MlastName
        {
            get { return _mlastName; }
            set { _mlastName = value; }
        }
        public double MyearlySalary
        {
            get { return _myearlySalary; }
        }

        //Increase salary method
        public double MIncreaseSalary(double myearlySalary)
        {
            if(myearlySalary <= 0)
            {
                _myearlySalary += myearlySalary;
                return myearlySalary;
            }
            else
            {
                return myearlySalary;
            }
        }

        //Decrease salary method
        public double MDecreaseSalary(double myearlySalary)
        {
            if(myearlySalary <= 0 && myearlySalary >= 20000)
            {
                _myearlySalary -= myearlySalary;
                return myearlySalary;
            }
            else
            {
                return myearlySalary;
            }
        }

        //Weekly pay method
        public double MWeeklyPay()
        {
            double mweeklypay = _myearlySalary / 52;
            return mweeklypay;
        }
    }
}
