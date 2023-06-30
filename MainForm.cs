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
        private bool checkBoxHide = false;
        private bool thresholdHide = true;
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
            thresholdNumeric.Hide();
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
            Bitmap destination;
            if (currentModel == ColorModel.RGB)
            {
                destination = GetVideo(source.ToMat());
                originalBox.Image?.Dispose();
                originalBox.Image = destination;
            }
            else
            if (currentModel == ColorModel.HSV)
            {
                destination = GetVideo(TransVison.GetHSV(source));
                originalBox.Image?.Dispose();
                originalBox.Image = destination;
            }
            else
            if (currentModel == ColorModel.YCbCr)
            {
                destination = GetVideo(TransVison.GetYCbCr(source));
                originalBox.Image?.Dispose();
                originalBox.Image = destination;
            }
            else
            if (currentModel == ColorModel.GRAY)
            {
                destination = TransVison.GetGray(source).ToBitmap();
                originalBox.Image?.Dispose();
                originalBox.Image = destination;
            }
            else
            if (currentModel == ColorModel.BINARY)
            {
                destination = TransVison.GetBinary(source, (int)thresholdNumeric.Value).ToBitmap();
                originalBox.Image?.Dispose();
                originalBox.Image = destination;
            }
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
                    channel1Box.Text = "Red";
                    channel2Box.Text = "Green";
                    channel3Box.Text = "Blue";
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
            Mat dst = new Mat();
            Mat[] channel = Cv2.Split(src);

            if (channel1Box.Checked)
                channel[0] = Mat.Zeros(channel[0].Size(), MatType.CV_8UC1);
            else
            if (channel2Box.Checked)
                channel[1] = Mat.Zeros(channel[1].Size(), MatType.CV_8UC1);
            else
            if (channel3Box.Checked)
                channel[2] = Mat.Zeros(channel[2].Size(), MatType.CV_8UC1);
            else
                return src.ToBitmap();
            Cv2.Merge(channel, dst);

            return dst.ToBitmap();
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
            FilterType type = (FilterType)filterScrollBar.Value;
            filterLabel.Text = type.ToString();
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
                thresholdNumeric.Hide();
                thresholdHide = true;
            }
            else
            if (thresholdHide == true && flag == false)
            {
                thresholdLabel.Show();
                thresholdNumeric.Show();
                thresholdHide = false;
            }
        }
    }
}
