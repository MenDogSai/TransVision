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
    /// <summary>
    /// 주요 컬러 모델
    /// </summary>
    public enum ColorModel
    {
        RGB   = 0, 
        HSV   = 1,
        YCbCr = 2,
        GRAY  = 3,
        BINARY = 4,
    }
    /// <summary>
    /// 필터 종류 0~3까지는 블러 필터 4~8까지는 가장 자리 검출 필터
    /// </summary>
    public enum FilterType
    {
        NONE = 0,
        MEDIAN = 1,
        MEAN = 2,
        GAUSSIAN = 3,
        SOBEL = 4,
        CANNY = 5,
        PREWITT = 6,
        ROBERTS = 7,
        LAPLACIAN = 8,
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
        static public Mat GetMedian(Bitmap source , int filterSize)
        {
            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.MedianBlur(src, dst, filterSize);
            return dst;
        }
        static public Mat GetMean(Bitmap source, int filterSize)
        {
            OpenCvSharp.Size ksize;
            ksize.Width = filterSize;
            ksize.Height = filterSize;

            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.Blur(src, dst, ksize);
            return dst;
        }
        static public Mat GetSobel(Bitmap source, int filterSize)
        {
            Mat src = source.ToMat();

            Mat dx = new Mat(source.Height, source.Height, MatType.CV_32FC1);
            Mat dy = new Mat(source.Height, source.Height, MatType.CV_32FC1);
            Cv2.Sobel(src, dx, MatType.CV_32FC1, 1, 0, filterSize, 1.0, 0, BorderTypes.Default);
            Cv2.Sobel(src, dy, MatType.CV_32FC1, 0, 1, filterSize, 1.0, 0, BorderTypes.Default);

            Mat dst = Cv2.Abs(dx) + Cv2.Abs(dy);
            dst.ConvertTo(dst, MatType.CV_8UC3);
            return dst;
        }
        static public Mat GetGaussian(Bitmap source, int filterSize)
        {
            OpenCvSharp.Size ksize;
            ksize.Width = filterSize;
            ksize.Height = filterSize;

            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.GaussianBlur(src, dst, ksize, 1, 1, BorderTypes.Default);

            return dst;
        }
        static public Mat GetCanny(Bitmap source, int filterSize)
        {
            OpenCvSharp.Size ksize;
            ksize.Width = filterSize;
            ksize.Height = filterSize;

            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.Canny(src, dst, 100, 200);

            return dst;
        }
        static public Mat GetPrewitt(Bitmap source)
        {
            float[] maskX = { -1, 0, 1, -1, 0, 1, -1, 0, 1 };
            float[] maskY = { -1, -1, -1, 0, 0, 0, 1, 1, 1 };

            Mat src = source.ToMat();
            Mat matMarkX = new Mat(3, 3, MatType.CV_32FC1, maskX);
            Mat matMarkY = new Mat(3, 3, MatType.CV_32FC1, maskY);

            Mat dx = new Mat();
            Mat dy = new Mat();

            Cv2.Filter2D(src, dx, -1, matMarkX);
            Cv2.Filter2D(src, dy, -1, matMarkY);

            Mat dst = Cv2.Abs(dx) + Cv2.Abs(dy);
            dst.ConvertTo(dst, MatType.CV_8U);
            return dst;
        }
        static public Mat GetRoberts(Bitmap source)
        {
            float[] maskX = { -1, 0,  0,  0, 1, 0,  0, 0, 0 };
            float[] maskY = {  0, 0, -1,  0, 1, 0,  0, 0, 0 };

            Mat src = source.ToMat();
            Mat matMarkX = new Mat(3, 3, MatType.CV_32FC1, maskX);
            Mat matMarkY = new Mat(3, 3, MatType.CV_32FC1, maskY);

            Mat dx = new Mat();
            Mat dy = new Mat();

            Cv2.Filter2D(src, dx, -1, matMarkX);
            Cv2.Filter2D(src, dy, -1, matMarkY);

            Mat dst = Cv2.Abs(dx) + Cv2.Abs(dy);
            dst.ConvertTo(dst, MatType.CV_8U);
            return dst;
        }
        static public Mat GetLaplacian(Bitmap source)
        {
            Mat src = source.ToMat();
            Mat dst = new Mat(source.Height, source.Height, MatType.CV_8UC3);
            Cv2.Laplacian(src, dst, MatType.CV_8U);
            return dst;
        }
    }
}