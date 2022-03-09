using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tracker2000
{
    public static class ColorProgramm
    {
        public static List<string> ColorList = new List<string>()
        {
                      "#32a852","#3246a8","#FF5722","#a432a8","#a83267",

                      "#81a832"
        };
        public static Color ChangeColorBrig(Color color, double correctingFactor, int v)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctingFactor < 0)
            {
                correctingFactor = 1 + correctingFactor;
                red *= correctingFactor;
                green *= correctingFactor;
                blue *= correctingFactor;
            }
            else
            {
                red = (255 - red) * correctingFactor + red;
                green = (255 - green) * correctingFactor + green;
                blue = (255 - blue) * correctingFactor + blue;
            }
            return Color.FromArgb(color.A,
                                  (byte)red,
                                  (byte)green,
                                  (byte)blue);
        }

    }
}








