using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Midterm_MallStores
{
    public partial class Form1 : Form
    {
        //Store list
        public List<Store> storeslist = new List<Store>();
        public Form1()
        {
            InitializeComponent();
            Preload();
            DisplayAllStores(storeslist, cbStores);
            
            
        }

        //Preload method
        public void Preload()
        {
            Manager bill = new Manager("Bill", "Bo", 70000);
            Store hm = new Store("H&M", bill, 9875);
            storeslist.Add(hm);
            Employee kyle = new Employee("Kyle", "Bile", 40, 23.50);
            Employee pyle = new Employee("Pyle", "Mile", 23, 18.25);
            hm.Employees.Add(kyle); 
            hm.Employees.Add(pyle);


            Manager shelby = new Manager("Shelby", "Melby", 90000);
            Store containerstore = new Store("Container Store", shelby, 6132);
            storeslist.Add(containerstore);
            Employee scary = new Employee("Scary", "Mary", 38, 27.15);
            Employee amanda = new Employee("Amanda", "Buhlanda", 12, 18.50);
            containerstore.Employees.Add(scary);
            containerstore.Employees.Add(amanda);
            
            
            Manager brian = new Manager("Brian", "Lyin", 48000);
            Store mochinut = new Store("Mochinut", brian, 7898);
            storeslist.Add(mochinut);
            Employee larry = new Employee("Larry", "Barry", 32, 25.75);
            Employee mica = new Employee("Mica", "Bay", 43, 30.45);
            mochinut.Employees.Add(larry);
            mochinut.Employees.Add(mica);
            

            
        }

        //Add employee button method
        public void btnHire_AddEmployee(object sender, EventArgs e)
        {
            string efirstName = tbFirstName.Text;
            string elastName = tbLastName.Text;
            int eweeklyHours = int.Parse(tbHours.Text);
            double ehourlyPay = double.Parse(tbHourlyPay.Text);

            // Create a new employee
            Employee newEmployee = new Employee(efirstName, elastName, eweeklyHours, ehourlyPay);

            // Get the index of the selected store
            int index = cbStores.SelectedIndex;
            if (index >= 0)
            {
                Store selectedStore = storeslist[index];
                selectedStore.HireEmployee(newEmployee);
            }

            // Re-display all stores after hiring the employee
            DisplayAllStores(storeslist, cbStores);


        }

        
        //Display single store method
        public void DisplayStore(Store store)
        {
            // Store header and manager info
            string displaystore = $"{store.StoreName} - {store.StoreCost(0).ToString("c")}\n" +
                $"Manager: {store.Manager.MfirstName} {store.Manager.MlastName} - {store.Manager.MWeeklyPay().ToString("c")}\n";

            // Loop through all employees in the store
            foreach (Employee employee in store.Employees)
            {
                displaystore += $"Employee: {employee.EfirstName} {employee.ElastName} - {employee.EWeeklyPay().ToString("c")}\n";
            }

            // Add the store info to the display area
            rtbDisplay.Text += displaystore + "\n"; // Ensure you add a newline between stores
        }

        //Display all stores method
        public void DisplayAllStores(List<Store> stores, ComboBox cbStores)
        {
            cbStores.Items.Clear();
            rtbDisplay.Clear();

            foreach (Store store in stores)
            {
                cbStores.Items.Add(store.StoreName);
            }

            // Display each store's details in the rich text box
            foreach (Store store in stores)
            {
                DisplayStore(store);
            }

        }
    }
}
