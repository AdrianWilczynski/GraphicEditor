using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using BitmapEditor;

namespace Tests
{
    [TestClass]
    public class ColorConversionTests
    {
        [TestMethod]
        public void Can_Convert_To_Hsv()
        {
            Color originalRgbColor = Color.FromArgb(85, 156, 19);
            HsvColor colorConvertedToHsv = HsvRgbColorConverter.ConvertRgbToHsv(originalRgbColor);

            int expectedH = 91;
            double expectedS = 0.88;
            int expectedV = (int) (0.61 * 255);

            Assert.IsTrue(Math.Abs(colorConvertedToHsv.H - expectedH) <= 1);
            Assert.IsTrue(Math.Abs(colorConvertedToHsv.S - expectedS) <= 0.1);
            Assert.IsTrue(Math.Abs(colorConvertedToHsv.V - expectedV) <= 1);
        }

        [TestMethod]
        public void Can_Convert_To_Rgb()
        {
            HsvColor originalHsvColor = new HsvColor { H = 217, S = 0.35, V = 104 };
            Color colorConvertedToRgb = HsvRgbColorConverter.ConvertHsvToRgb(originalHsvColor);

            int expectedR = 68;
            int expectedG = 82;
            int expectedB = 105;

            Assert.IsTrue(Math.Abs(colorConvertedToRgb.R - expectedR) <= 1);
            Assert.IsTrue(Math.Abs(colorConvertedToRgb.G - expectedG) <= 1);
            Assert.IsTrue(Math.Abs(colorConvertedToRgb.B - expectedB) <= 1);
        }

        [TestMethod]
        public void Can_Convert_To_Hsv_And_Back_To_Rgb()
        {
            Color originalRgbColor = Color.FromArgb(200, 14, 55);
            HsvColor colorConvertedToHsv = HsvRgbColorConverter.ConvertRgbToHsv(originalRgbColor);
            Color colorConvertedToRgb = HsvRgbColorConverter.ConvertHsvToRgb(colorConvertedToHsv);

            Assert.IsTrue(Math.Abs(colorConvertedToRgb.R - originalRgbColor.R) <= 1);
            Assert.IsTrue(Math.Abs(colorConvertedToRgb.G - originalRgbColor.G) <= 1);
            Assert.IsTrue(Math.Abs(colorConvertedToRgb.B - originalRgbColor.B) <= 1);
        }

    }
}
