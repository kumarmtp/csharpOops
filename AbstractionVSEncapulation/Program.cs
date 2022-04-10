using System;

namespace AbstractionVSEncapulation
{

    //Abstrction only Expose what then need

    //Encapulation hiding Complaxcity
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
      
        

        public Employee()
        {
           

        }

        public string EmpName { get; set; }
        public string Email { get; set; }
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
