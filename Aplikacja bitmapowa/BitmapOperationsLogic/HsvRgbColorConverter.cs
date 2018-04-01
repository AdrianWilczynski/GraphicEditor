using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BitmapEditor
{
    public static class HsvRgbColorConverter
    {
        public static HsvColor ConvertRgbToHsv(Color rgbColor)
        {
            int max = new[] { rgbColor.R, rgbColor.G, rgbColor.B }.Max();
            int min = new[] { rgbColor.R, rgbColor.G, rgbColor.B }.Min();
            int r = max - min;

            int h;
            double s;
            int v;

            v = max;
            s = max != 0 ? (double)r / max : 0;

            if (rgbColor.G == max)
            {
                h = (int)(60 * (double)(rgbColor.B - rgbColor.R) / r + 120);
            }
            else if (rgbColor.B == max)
            {
                h = (int)(60 * (double)(rgbColor.R - rgbColor.G) / r + 240);
            }
            else
            {
                h = (int)(60 * (double)(rgbColor.G - rgbColor.B) / r);
            }

            return new HsvColor { H = h, S = s, V = v };
        }

        public static Color ConvertHsvToRgb(HsvColor hsvColor)
        {
            int r = (int)Math.Floor((double)hsvColor.H / 60);
            double f = (double)hsvColor.H / 60 - r;

            int a = (int)(hsvColor.V * (1 - hsvColor.S));
            int b = (int)(hsvColor.V * (1 - hsvColor.S * f));
            int c = (int)(hsvColor.V * (1 - hsvColor.S * (1 - f)));

            int v = hsvColor.V;

            Color rgbColor;

            if (r == 0)
            {
                rgbColor = Color.FromArgb(v, c, a);
            }
            else if (r == 1)
            {
                rgbColor = Color.FromArgb(b, v, a);
            }
            else if (r == 2)
            {
                rgbColor = Color.FromArgb(a, v, c);
            }
            else if (r == 3)
            {
                rgbColor = Color.FromArgb(a, b, v);
            }
            else if (r == 4)
            {
                rgbColor = Color.FromArgb(c, a, v);
            }
            else
            {
                rgbColor = Color.FromArgb(v, a, b);
            }

            return rgbColor;
        }
    }
}
