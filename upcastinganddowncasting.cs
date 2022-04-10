using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpinteview
{

    public class Shape
    {
        private int _width;
        private int _hight;

        public int Width
        {
            get => _width;
            set => _width = value;
        }

        public int Hight
        {
            get => _hight;
            set => _hight = value;
        }

        public void Draw()
        {

        }
    }


    public class Text : Shape
    {
        private int _font;

        public int Font
        {
            get => _font;
            set => _font = value;
        }
    }

}
