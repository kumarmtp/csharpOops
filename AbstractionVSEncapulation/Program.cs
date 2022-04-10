using System;

namespace AbstractionVSEncapulation
{

    //Abstrction only Expose what then need
    //It is used to hide unwanted data and shows only 
    //the required properties and methods.

    //Encapulation hiding Complaxcity
    //It binds data members and member functions into a single unit 
    //to prevent outsiders from accessing it directly.

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Email = "raja@s.com"; //raja@s.com already exit
            employee.EmpName = "kumar";

            employee.AddEmployee(); //abstrction need only addmethod to add employee


           // Console.WriteLine("Hello World!");
        }
    }

    public class Employee
    {
        private string _empName; //change value through geter setter only
        private string _email;


        public Employee()
        {
           

        }

        public string EmpName
        {
            get => _empName;
            set => _empName = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public void AddEmployee()
        {
          
            var result = CheckEmpAlreadyExit();

            if (result)
            {
                Console.WriteLine("EmpCode Already Exit");
            }
            else
            {

            }
        }
        private bool CheckEmpAlreadyExit() //Encapulation --hiding details of check already exit
        {
            if (Email == "raja@s.com")
            {
                return true;


            }
            else
            {
                return false;
            }
        }
    }
}
