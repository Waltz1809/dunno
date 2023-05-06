using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace InuWayBackHome
{
    public class Transparent
    {
        private static void BlendPic(Bitmap bg, Bitmap front, int deltaX, int deltaY)
        {
            for (int y = 0; y < front.Height; y++)
            {
                for (int x = 0; x < front.Width; x++)
                {
                    if (front.GetPixel(x, y).A < 255)
                    {
                        Color newColor = bg.GetPixel(x + deltaX, y + deltaY);
                    }
                }
            }
        }

        public static void BlendPic(PictureBox back, PictureBox front)
        {
            int leftDiff = Math.Abs(back.Left - front.Left);
            int rightDiff = Math.Abs(back.Top - front.Top);

            BlendPic((Bitmap)back.Image, (Bitmap)front.Image, leftDiff, rightDiff);
        }

    }
}
