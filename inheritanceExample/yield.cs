using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_polymorphismExample
{
//    At first sight, yield return is a.NET sugar to return an IEnumerable.

//    Without yield, all the items of the collection are created at once:

    class SomeData
    {
        public SomeData() { }

        static public IEnumerable<SomeData> CreateSomeDatas()
        {
            return new List<SomeData> {
                new SomeData(),
                new SomeData(),
                new SomeData()
            };
        }
    }
    //Same code using yield, it returns item by item:

    class SomeDatayield
    {
        public SomeDatayield() { }

        static public IEnumerable<SomeData> CreateSomeDatas()
        {
            yield return new SomeData();
            yield return new SomeData();
            yield return new SomeData();
        }
    }
  /*  The advantage of using yield is that if the function
   consuming your data simply needs the first item of the collection, 
  the rest of the items won't be created.*/
}
