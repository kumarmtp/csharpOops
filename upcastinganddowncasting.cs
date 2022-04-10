using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpinteview
{

    public class Shape
    {
        public int Width { get; set; }
        public int Hight { get; set; }

        public void Draw()
        {

        }
    }


    public class Text : Shape
    {
        public int Font { get; set; }
    }

}
