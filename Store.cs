using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_MallStores
{
    public class Store
    {
        //Fields
        string _storeName;
        Manager _manager;
        List<Employee> _employees = new List<Employee>();
        double _weeklyCost;
        

        //Constructor 1
        public Store(string storeName, double weeklyCost)
        {
            _storeName = storeName;
            _weeklyCost = weeklyCost;
            _employees = new List<Employee>();
        }

        //Constructor 2
        public Store(string storeName, Manager manager, double weeklyCost)
        {
            _storeName = storeName;
            _manager = manager;
            _weeklyCost = weeklyCost;
            _employees = new List<Employee>();
        }

        //Properties
        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; }
        }
        public Manager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
        public List<Employee> Employees
        {
            get { return _employees; }
        }
        public double WeeklyCost
        {
            get { return _weeklyCost; }
            set { _weeklyCost = value; }
        }


        //Method for store cost
        public double StoreCost(double storecost)
        {
            foreach(Employee emp in Employees)
            {
                storecost = _weeklyCost + emp.EWeeklyPay() + Manager.MWeeklyPay();
                
            }
            return storecost;
        }

        //Hire employee method
        public void HireEmployee(Employee addemployee)
        {
            _employees.Add(addemployee);
        }

        
    }
}
