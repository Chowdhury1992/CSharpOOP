using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjectsApp
{
    public class Table
    {
        int _width;
        int _height;
        public int Width { get; set; }
        public int Height { get; set; }

        public Table(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void ShowData()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }
    }
}
