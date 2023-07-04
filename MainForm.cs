using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using AForge.Video;
using System.Web;
using OpenCvSharp.Extensions;

namespace TransVison
{
    public partial class MainForm : Form
    {
        private MJPEGStream stream = null;
        private ColorModel currentModel = ColorModel.RGB;
        private BlurFilter currentBlur = BlurFilter.NONE;
        private EdgeFilter currentEdge = EdgeFilter.NONE;

        private bool checkBoxHide = false;
        private bool thresholdHide = true;

        private int threshold = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            stream = new MJPEGStream();
            stream.NewFrame += new NewFrameEventHandler(Video_Stream);
            stream.Login = "admin0101";
            stream.Password = "kkmd1234";
            colorModelBox.SelectedIndex = 0;
            thresholdLabel.Hide();
            thresholdBar.Hide();
            threshold = 125;
            thresholdBar.Value = threshold;

        }
        private void ConnectBox_CheckedChanged(object sender, EventArgs e)
        {
            if (connectBox.Checked)
            {
                stream.Source = pathBox.Text;

                if (stream.IsRunning)
                {
                    MessageBox.Show("IP 캠을 연결할 수 없습니다");
                    stream.Stop();
                }
                stream.Start();
                connectBox.Text = "연결 끊음";
            }
            else
            {
                connectBox.Text = "연결 시작";
                stream.Stop();
                originalBox.Image?.Dispose();
            }
        }
        private void Video_Stream(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap colorSrc = (Bitmap)eventArgs.Frame.Clone();
            originalBox.Image = GetColorModel(colorSrc);
   
            Bitmap blurSrc = (Bitmap)originalBox.Image.Clone();
            Bitmap edgeSrc =  GetBlurFilter(blurSrc);
            filterBox.Image = GetEdgeFilter(edgeSrc);
            colorSrc.Clone();
            blurSrc.Clone();
            edgeSrc.Clone();
        }
        /// <summary>
        /// Mat 이미지를  컬러 모델 의 3채널로 분리 해서 
        /// 각각 비트맵 이미지를 반환
        /// </summary>
        private Bitmap GetVideo(Mat src)
        {
            Mat[] rgb = Cv2.Split(src);

            if (channel1Box.Checked)
                return rgb[0].ToBitmap();
            else
            if (channel2Box.Checked)
                return rgb[1].ToBitmap();
            else
            if (channel3Box.Checked)
                return rgb[2].ToBitmap();

            return src.ToBitmap();
        }
        private Bitmap GetColorModel(Bitmap src)
        {
            switch (currentModel)
            {
                case ColorModel.RGB:
                    return GetVideo(src.ToMat());
                case ColorModel.HSV:
                    return GetVideo(TransVison.GetHSV(src));
                case ColorModel.YCbCr:
                    return GetVideo(TransVison.GetYCbCr(src));
                case ColorModel.GRAY:
                    return TransVison.GetGray(src).ToBitmap();
                case ColorModel.BINARY:
                    return TransVison.GetBinary(src, threshold).ToBitmap();
            }
            return src;
        }
        private Bitmap GetBlurFilter(Bitmap src)
        {
            switch (currentBlur)
            {
                case BlurFilter.MEDIAN:
                    return TransVison.GetMedian(src, (int)filterSizeNumeric.Value).ToBitmap();
                case BlurFilter.MEAN:
                    return TransVison.GetMean(src, (int)filterSizeNumeric.Value).ToBitmap();
                case BlurFilter.GAUSSIAN:
                    return TransVison.GetGaussian(src, (int)filterSizeNumeric.Value).ToBitmap();
                case BlurFilter.BILATERAL:
                    return TransVison.GetBilateral(src, (int)filterSizeNumeric.Value).ToBitmap();
            }
            return src;
        }
        private Bitmap GetEdgeFilter(Bitmap src)
        {
            switch (currentEdge)
            {
                case EdgeFilter.SOBEL:
                    return TransVison.GetSobel(src).ToBitmap();
                case EdgeFilter.CANNY:
                    return TransVison.GetCanny(src).ToBitmap();
                case EdgeFilter.PREWITT:
                    return TransVison.GetPrewitt(src).ToBitmap();
                case EdgeFilter.ROBERTS:
                    return TransVison.GetRoberts(src).ToBitmap();
                case EdgeFilter.LAPLACIAN:
                    return TransVison.GetLaplacian(src).ToBitmap();
            }
            return src;
        }
        #region GUI 제어에 필요한 코드 영역
        private void ColorModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorModelChanged((ColorModel)colorModelBox.SelectedIndex);
        }

        private void ColorModelChanged(ColorModel model)
        {
            currentModel = model;
            switch (model)
            {
                case ColorModel.RGB:
                    channel1Box.Text = "Blue";
                    channel2Box.Text = "Green";
                    channel3Box.Text = "Red";
                    SetCheckBoxHide(false);
                    SetThresholdCtrlHide(true);
                    break;
                case ColorModel.HSV:
                    channel1Box.Text = "Hue";
                    channel2Box.Text = "Saturation";
                    channel3Box.Text = "Value";
                    SetCheckBoxHide(false);
                    SetThresholdCtrlHide(true);
                    break;
                case ColorModel.YCbCr:
                    channel1Box.Text = "Y";
                    channel2Box.Text = "Cb";
                    channel3Box.Text = "Cr";
                    SetCheckBoxHide(false);
                    SetThresholdCtrlHide(true);
                    break;
                case ColorModel.GRAY:
                    SetCheckBoxHide(true);
                    SetThresholdCtrlHide(true);
                    break;
                case ColorModel.BINARY:
                    SetCheckBoxHide(true);
                    SetThresholdCtrlHide(false);
                    break;
            }
        }
        private void Channel1Box_CheckedChanged(object sender, EventArgs e)
        {
            if (channel2Box.Checked) { channel2Box.Checked = false; }
            if (channel3Box.Checked) { channel3Box.Checked = false; }
        }

        private void Channel2Box_CheckedChanged(object sender, EventArgs e)
        {
            if (channel1Box.Checked) { channel1Box.Checked = false; }
            if (channel3Box.Checked) { channel3Box.Checked = false; }
        }

        private void Channel3Box_CheckedChanged(object sender, EventArgs e)
        {
            if (channel1Box.Checked) { channel1Box.Checked = false; }
            if (channel2Box.Checked) { channel2Box.Checked = false; }
        }
        private void SetCheckBoxHide(bool flag)
        {
            if (checkBoxHide == false && flag == true)
            { 
                channel1Box.Hide();
                channel2Box.Hide();
                channel3Box.Hide();
                checkBoxHide = true;
            }
            else
            if(checkBoxHide == true && flag == false)
            {
                channel1Box.Show();
                channel2Box.Show();
                channel3Box.Show();
                checkBoxHide = false;
            }
        }
        private void SetThresholdCtrlHide(bool flag)
        {
            if (thresholdHide == false && flag == true)
            {
                thresholdLabel.Hide();
                thresholdBar.Hide();
                thresholdHide = true;
            }
            else
            if (thresholdHide == true && flag == false)
            {
                thresholdLabel.Show();
                thresholdBar.Show();
                thresholdHide = false;
            }
        }
        private void ThresholdBar_Scroll(object sender, EventArgs e)
        {
            threshold = thresholdBar.Value;
            thresholdLabel.Text = $"임계값:{threshold}";
        }
        private void BlurNoneButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBlur = BlurFilter.NONE;
        }

        private void BlurMedianButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBlur = BlurFilter.MEDIAN;
        }

        private void BlurMeanButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBlur = BlurFilter.MEAN;
        }

        private void BlurGaussianButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBlur = BlurFilter.GAUSSIAN;
        }

        private void BlurBilateralButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBlur = BlurFilter.BILATERAL;
        }

        private void EdgeNoneButton_CheckedChanged(object sender, EventArgs e)
        {
            currentEdge = EdgeFilter.NONE;
        }

        private void EdgeSobelButton_CheckedChanged(object sender, EventArgs e)
        {
            currentEdge = EdgeFilter.SOBEL;
        }

        private void EdgeCannyButton_CheckedChanged(object sender, EventArgs e)
        {
            currentEdge = EdgeFilter.CANNY;
        }

        private void EdgePrewittButton_CheckedChanged(object sender, EventArgs e)
        {
            currentEdge = EdgeFilter.PREWITT;
        }

        private void EdgeRobertsButton_CheckedChanged(object sender, EventArgs e)
        {
            currentEdge = EdgeFilter.ROBERTS;
        }

        private void EdgeLaplacianButton_CheckedChanged(object sender, EventArgs e)
        {
            currentEdge = EdgeFilter.LAPLACIAN;
        }
        #endregion
    }
}
