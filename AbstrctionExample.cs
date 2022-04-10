using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpinteview
{
    //base class

    // base class constructer called first before child class called
   public class Vehilcle
   {
       private string _registrationNo;
        public Vehilcle(string registrationNo)
        {
            _registrationNo = registrationNo;
            Console.WriteLine("vehicle class initialized");
        }
    }

   public class car : Vehilcle
   {
       private string carType;
       public car(string registrationNo,string Cartype):base(registrationNo)//base method call
       {
           carType = Cartype;
           Console.WriteLine("car class initialized");
       }
   }
}
