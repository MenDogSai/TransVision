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
        private FilterType type = FilterType.NONE;

        private bool checkBoxHide = false;
        private bool thresholdHide = true;
        private bool filterSizeHide = false;

        private int threshold = 0;
        private int filterValue = 0;

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
            filterSizeBox.SelectedIndex = 1;
            filterValue = Convert.ToInt32(filterSizeBox.SelectedItem.ToString());
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
                connectBox.Text = "연결 됨";
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
            Bitmap source = (Bitmap)eventArgs.Frame.Clone();
            Bitmap colorModelBMP = source;

            switch (currentModel)
            {
                case ColorModel.RGB:
                    colorModelBMP = GetVideo(source.ToMat());
                    break;
                case ColorModel.HSV:
                    colorModelBMP = GetVideo(TransVison.GetHSV(source));
                    break;
                case ColorModel.YCbCr:
                    colorModelBMP = GetVideo(TransVison.GetYCbCr(source));
                    break;
                case ColorModel.GRAY:
                    colorModelBMP = TransVison.GetGray(source).ToBitmap();
                    break;
                case ColorModel.BINARY:
                    colorModelBMP = TransVison.GetBinary(source, threshold).ToBitmap();
                    break;
            }
            originalBox.Image?.Dispose();
            originalBox.Image = colorModelBMP;
   
            if(type == FilterType.NONE)
                return;

            Bitmap filterSource = (Bitmap)colorModelBMP.Clone();
            Bitmap filterBMP = colorModelBMP;

            switch (type) {
                case FilterType.MEDIAN:
                    filterBMP = TransVison.GetMedian(filterSource, filterValue).ToBitmap();
                    break;
                case FilterType.MEAN:
                    filterBMP = TransVison.GetMean(filterSource, filterValue).ToBitmap();
                    break;
                case FilterType.GAUSSIAN:
                    filterBMP = TransVison.GetGaussian(filterSource, filterValue).ToBitmap();
                    break;
                case FilterType.SOBEL:
                    filterBMP = TransVison.GetSobel(filterSource, filterValue).ToBitmap();
                    break;
                case FilterType.CANNY:
                    filterBMP = TransVison.GetCanny(filterSource, filterValue).ToBitmap();
                    break;
                case FilterType.PREWITT:
                    filterBMP = TransVison.GetPrewitt(filterSource).ToBitmap();
                    break;
                case FilterType.ROBERTS:
                    filterBMP = TransVison.GetRoberts(filterSource).ToBitmap();
                    break;
                case FilterType.LAPLACIAN:
                    filterBMP = TransVison.GetLaplacian(filterSource).ToBitmap();
                    break;
            }

            filterBox.Image?.Dispose();
            filterBox.Image = filterBMP;
        }

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
        private void FilterScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            type = (FilterType)filterScrollBar.Value;
            filterLabel.Text = type.ToString();
            if ((int)type < (int)FilterType.SOBEL)
            {
                if (filterSizeHide == true) return;
                filterSizeHide = true;
                filterSizeBox.Show();
                filterSizeLabel.Show();
            }
            else
            {
                if (filterSizeHide == false) return;
                filterSizeHide = false;
                filterSizeBox.Hide();
                filterSizeLabel.Hide();
            }
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

        private void FilterSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterValue = Convert.ToInt32(filterSizeBox.SelectedItem.ToString()) ;
        }
    }
}
