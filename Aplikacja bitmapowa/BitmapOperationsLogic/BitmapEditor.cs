using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BitmapEditor
{ 
    public class BitmapEditor
    {
        public Bitmap CurrentlyEditedBitmap { get; set; }

        private Stack<Bitmap> previousVersionsOfBitmap = new Stack<Bitmap>();

        public BitmapEditor(Bitmap bitmap)
        {
            CurrentlyEditedBitmap = bitmap;
        }

        public void Undo()
        {
            if (previousVersionsOfBitmap.Any())
            {
                CurrentlyEditedBitmap = previousVersionsOfBitmap.Pop();
            }
        }

        private void saveCurrentVersionOfBitmap()
        {
            previousVersionsOfBitmap.Push((Bitmap) CurrentlyEditedBitmap.Clone());
        }

        public void TransformAllPixels(Func<Color, Color> transformation)
        {
            saveCurrentVersionOfBitmap();

            Color color;
            for (int i = 0; i < CurrentlyEditedBitmap.Height; i++)
                for (int j = 0; j < CurrentlyEditedBitmap.Width; j++)
                {
                    color = CurrentlyEditedBitmap.GetPixel(j, i);

                    color = transformation(color);

                    CurrentlyEditedBitmap.SetPixel(j, i, color);
                }
        }

        public void TransformAllPixelsWithNeighbors(Func<Color[,], Color> transformation)
        {
            saveCurrentVersionOfBitmap();

            Color color;
            Queue<Color> colors = new Queue<Color>();

            for (int i = 0; i < CurrentlyEditedBitmap.Height; i++)
                for (int j = 0; j < CurrentlyEditedBitmap.Width; j++)
                {
                    Color[,] neighborsMatrix = new Color[3,3];

                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            int innerX = l + j - 1;
                            int innerY = k + i - 1;

                            bool isOutOfRange = (innerX < 0 || innerX >= CurrentlyEditedBitmap.Width) 
                                                || (innerY < 0 || innerY >= CurrentlyEditedBitmap.Height);

                            if (isOutOfRange)
                            {
                                neighborsMatrix[l, k] = CurrentlyEditedBitmap.GetPixel(j, i);
                                continue;
                            }

                            neighborsMatrix[l, k] = CurrentlyEditedBitmap.GetPixel(innerX, innerY);
                        }
                    }

                    color = transformation(neighborsMatrix);

                    //to preserve orignal values of pixles (for now)
                    colors.Enqueue(color);
                }

            for (int i = 0; i < CurrentlyEditedBitmap.Height; i++)
                for (int j = 0; j < CurrentlyEditedBitmap.Width; j++)
                {
                    CurrentlyEditedBitmap.SetPixel(j, i, colors.Dequeue());
                }
        }

        public int[] GetVLelevs()
        {
            int[] vLevels = new int[256];

            for (int i = 0; i < CurrentlyEditedBitmap.Height; i++)
                for (int j = 0; j < CurrentlyEditedBitmap.Width; j++)
                {
                    HsvColor hsvColor = HsvRgbColorConverter.ConvertRgbToHsv(CurrentlyEditedBitmap.GetPixel(j, i));

                    vLevels[hsvColor.V]++;
                }

            return vLevels;
        }
    }
}
