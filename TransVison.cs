using OpenCvSharp;
using OpenCvSharp.Extensions;
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
        YCbCr = 2,
        GRAY  = 3,
        BINARY = 4,
    }

    static internal class TransVison
    {
        static public Mat GetHSV(Bitmap source)
        {
           Mat src = source.ToMat();
           Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
           Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2HSV);
           return dst;
        }
        static public Mat GetYCbCr(Bitmap source)
        {
            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2YCrCb);
            return dst;
        }
        static public Mat GetGray(Bitmap source)
        {
            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2GRAY);
            return dst;
        }
        static public Mat GetBinary(Bitmap source, int threshold)
        {
            Mat src = GetGray(source);
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.Threshold(src, dst, threshold, 255, ThresholdTypes.Binary);
            return dst;
        }
    }
}
