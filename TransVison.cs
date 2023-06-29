using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TransVison
{
    public enum ColorModel
    {
        RGB   = 0, 
        HSV   = 1,
        YCrCb = 2,
        GRAY  = 3,
    }

    static internal class TransVison
    {
        static public Mat GetHSV(Bitmap source)
        {
           Mat src = OpenCvSharp.Extensions.BitmapConverter.ToMat(source);
           Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
           Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2HSV);
           //OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);
           return dst;
        }
        static public Mat GetYCrCb(Bitmap source)
        {
            Mat src = OpenCvSharp.Extensions.BitmapConverter.ToMat(source);
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2YCrCb);
            return dst;
        }
        static public Mat GetGray(Bitmap source)
        {
            Mat src = OpenCvSharp.Extensions.BitmapConverter.ToMat(source);
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2GRAY);
            return dst;
        }
    }
}
