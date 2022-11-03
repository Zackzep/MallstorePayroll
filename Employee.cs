using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_MallStores
{
    public class Employee
    {
        //Fields
        string _efirstName;
        string _elastName;
        int _eweeklyHours;
        double _ehourlyPay;

        //Constructor
        public Employee(string efirstName, string elastName, int eweeklyHours, double ehourlyPay)
        {
            _efirstName = efirstName;
            _elastName = elastName;
            _eweeklyHours = eweeklyHours;
            _ehourlyPay = ehourlyPay;
        }

        //Properties
        public string EfirstName
        {
            get { return _efirstName; }
            set { _efirstName = value; }
        }
        public string ElastName
        {
            get { return _elastName; }
            set { _elastName = value; }
        }
        public int EweeklyHours
        {
            get { return _eweeklyHours; }
            set { _eweeklyHours = value; }
        }
        public double EhourlyPay
        {
            get { return _ehourlyPay; }
        }

        //Increase pay method
        public double EIncreasePay(double ehourlyPay)
        {
            if(ehourlyPay <= 0)
            {
                _ehourlyPay += ehourlyPay;
                return ehourlyPay;
            }
            else
            {
                return ehourlyPay;
            }
        }

        //Weekly pay method
        public double EWeeklyPay()
        {
            
            double eweeklypay = _eweeklyHours * _ehourlyPay;
            return eweeklypay;
        }
    }
}
