using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inheritance_polymorphismExample;

namespace inheritanceExample
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //polimorphism -method overloading  and it is also called early binding or static binding.

    //        Calculate c = new Calculate();
    //            c.AddNumbers(1, 2);
    //            c.AddNumbers(1, 2, 3);
    //            Console.WriteLine("\nPress Enter Key to Exit..");
    //            Console.ReadLine();




    //        //inheritance
    //        List<EmployeeBaseClass> emplist = new List<EmployeeBaseClass>();

    //        LocalEmployee localEmployee = new LocalEmployee()
    //        {
    //            EmpCode = 123,
    //            FirstName = "kumar",
    //            LastName = "jaya"
    //        };

    //        ForignEmployee forignEmployee = new ForignEmployee()
    //        {
    //            EmpCode = 123,
    //            FirstName = "kumar",
    //            LastName = "raja"
    //        };

    //        emplist.Add(localEmployee);
    //        emplist.Add(forignEmployee);



    //        calculateSalary calculateSalary = new calculateSalary(emplist);
    //        calculateSalary.calculateEmpSalary();



    //    }
    //}


    public class Program
    {
        public static async Task Main()
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            await foreach (int number in YieldReturnNumbers(numbers))
            {
                Console.WriteLine(number);
            }

        }

        public static async IAsyncEnumerable<int> YieldReturnNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                await Task.Delay(1000);
                yield return number;
            }
        }
    }
    public abstract class EmployeeBaseClass //internal with in assembly
    {

        private  DateTime CreatedTime; //if readonly it assign value only in constrctor -field can not be abstrct
        private int _empCode;
        private string _firstName;
        private string _lastName;

        public EmployeeBaseClass()
        {
            CreatedTime = DateTime.Now;
        }

        public int EmpCode
        {
            get => _empCode;
            set => _empCode = value;
        }


        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public abstract decimal CalculateSalary(); //only diclaration


        public string FullName()
        {

            return FirstName + " " + LastName;
        }
        //public virtual decimal  CalculateSalary()
        //{
        //    throw new NotImplementedException("method not implemented");
        //}
    }


    public class LocalEmployee : EmployeeBaseClass
    {

        public LocalEmployee()
        {
           
        }
        //salary calculation for loacal employee
        public override decimal CalculateSalary() //Run Time Polymorphism  -over riding late binding or dynamic binding.


        {
            Console.WriteLine("calculate LocalEmp Salary");
            return 0.0m;

        }
    }


    public class ForignEmployee : EmployeeBaseClass
    {
        public ForignEmployee()
        {

        }
        //sallary calculation for forgine employee
        public override decimal CalculateSalary() //
        {
            Console.WriteLine("calculate ForignEmp Salary");
            return 0.0m;
        }
    }

    public class calculateSalary
    {
        private readonly List<EmployeeBaseClass> _employeeBaseList;


        public calculateSalary(List<EmployeeBaseClass> employeeBaseList)
        {
            _employeeBaseList = employeeBaseList;
        }

        public void calculateEmpSalary()
        {
            foreach (var emp in _employeeBaseList)
            {
                Console.WriteLine(emp.GetType().ToString());
                emp.CalculateSalary();
            }
        }

    }

}
//Polymorphism literally means "many forms"
//In software engineering, it refers to the same "operation" that can be performed on different types
//    Exmaples include:
//Function overloading
//Generics
//    Subtyping
//Function overloading
//Functions can have the same name as long as they have different argument types
//Like different constructors for the same class, for example
//    The compiler figures out what function you actually want based on the inputs
//    This allows you to call the "same" function with different results
//Console.WriteLine() is a great example of this


