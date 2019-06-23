using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BitmapEditor
{
    public class HsvColor
    {
        private int _h;
        public int H
        {
            get
            {
                return _h;
            }
            set
            {
                if (value > 360)
                {
                    _h = value - 360;
                }
                else if (value < 0)
                {
                    _h = value + 360;
                }
                else
                {
                    _h = value;
                }
            }
        }

        private double _s;
        public double S
        {
            get
            {
                return _s;
            }
            set
            {
                if (value < 0)
                {
                    _s = 0;
                }
                else if (value > 1)
                {
                    _s = 1;
                }
                else
                {
                    _s = value;
                }
            }
        }

        private int _v;
        public int V
        {
            get
            {
                return _v;
            }
            set
            {
                if (value < 0)
                {
                    _v = 0;
                }
                else if (value > 255)
                {
                    _v = 255;
                }
                else
                {
                    _v = value;
                }
            }
        }  
    }
}
