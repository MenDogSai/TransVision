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
    static internal class TransVison
    {
        static public Bitmap GetHSV(Bitmap source)
        {
           Mat src = OpenCvSharp.Extensions.BitmapConverter.ToMat(source);
           Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
           Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2HSV);
           return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);
        }
        static public Bitmap GetYCBCR(Bitmap source)
        {
            Mat src = OpenCvSharp.Extensions.BitmapConverter.ToMat(source);
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2YCrCb);
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);
        }
    }
}
