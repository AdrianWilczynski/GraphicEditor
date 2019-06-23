using System;
using System.Drawing;

namespace BitmapEditor
{
    public static class Transformations
    {
        public static Func<Color, Color> TransformHue(int strenght)
        {
            return (Color rgbColor) =>
            {
                HsvColor hsvColor = HsvRgbColorConverter.ConvertRgbToHsv(rgbColor);

                hsvColor.H += strenght;

                return HsvRgbColorConverter.ConvertHsvToRgb(hsvColor);
            };
        }

        public static Func<Color, Color> TransformSaturation(int strenght)
        {
            return (Color rgbColor) =>
            {
                HsvColor hsvColor = HsvRgbColorConverter.ConvertRgbToHsv(rgbColor);

                double floatingPointStrenght = (double)strenght / 100;

                hsvColor.S += floatingPointStrenght;

                return HsvRgbColorConverter.ConvertHsvToRgb(hsvColor);
            };
        }

        public static Func<Color, Color> TransformValue(int strenght)
        {
            return (Color rgbColor) =>
            {
                HsvColor hsvColor = HsvRgbColorConverter.ConvertRgbToHsv(rgbColor);

                hsvColor.V += strenght;

                return HsvRgbColorConverter.ConvertHsvToRgb(hsvColor);
            };
        }

        public static Func<Color, Color> TransformContrast(int strenght)
        {
            return (Color rgbColor) =>
            {
                double contrastLevel = Math.Pow((100.0 + strenght) / 100.0, 2);

                int r, g, b;

                r = (int)(((((rgbColor.R / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0);
                g = (int)(((((rgbColor.G / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0);
                b = (int)(((((rgbColor.B / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0);

                r = LimitToRange(r, 0, 255);
                g = LimitToRange(g, 0, 255);
                b = LimitToRange(b, 0, 255);

                return Color.FromArgb(r, g, b);
            };
        }

        public static Color Invert(Color rgbColor)
        {
            int invertedR = 255 - rgbColor.R;
            int invertedG = 255 - rgbColor.G;
            int invertedB = 255 - rgbColor.B;

            return Color.FromArgb(invertedR, invertedG, invertedB);
        }

        public static Color Blur(Color[,] neighborsMatrix)
        {
            int[,] blurMatrix = new int[,]
            {
                {1, 1, 1 },
                {1, 1, 1 },
                {1, 1, 1 }
            };

            return ApplyMatrix(neighborsMatrix, blurMatrix, (double)1/9);
        }

        public static Color Sharpen(Color[,] neighborsMatrix)
        {
            int[,] sharpenMatrix = new int[,]
            {
                {0, -1, 0 },
                {-1, 5, -1 },
                {0, -1, 0 }
            };

            return ApplyMatrix(neighborsMatrix, sharpenMatrix, 1);
        }

        public static Color DetectEdges(Color[,] neighborsMatrix)
        {
            int[,] edgeDetectionMatrix = new int[,]
            {
                {-1, -1, -1 },
                {-1, 8, -1 },
                {-1, -1, -1 }
            };

            return ApplyMatrix(neighborsMatrix, edgeDetectionMatrix, 1);
        }

        public static Func<Color, Color> Binarize(int threshold)
        {
            return (Color rgbColor) =>
            {
                double brightness = (0.299 * rgbColor.R) + (0.587 * rgbColor.G) + (0.114 * rgbColor.B);

                if (brightness > threshold)
                {
                    return Color.White;
                }
                else
                {
                    return Color.Black;
                }
            };
        }

        private static Color ApplyMatrix(Color[,] neighborsMatrix, int[,] transformationMatrix, double normalizationRate)
        {
            int resultR = 0;
            int resultG = 0;
            int resultB = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultR += transformationMatrix[i, j] * neighborsMatrix[i, j].R;
                    resultG += transformationMatrix[i, j] * neighborsMatrix[i, j].G;
                    resultB += transformationMatrix[i, j] * neighborsMatrix[i, j].B;
                }
            }

            resultR = (int)(resultR * normalizationRate);
            resultG = (int)(resultG * normalizationRate);
            resultB = (int)(resultB * normalizationRate);

            resultR = LimitToRange(resultR, 0, 255);
            resultG = LimitToRange(resultG, 0, 255);
            resultB = LimitToRange(resultB, 0, 255);

            return Color.FromArgb(resultR, resultG, resultB);
        }

        private static int LimitToRange(int value, int min, int max)
        {
            if (value > max)
            {
                return max;
            }
            else if (value < min)
            {
                return min;
            }

            return value;
        }
    }
}
