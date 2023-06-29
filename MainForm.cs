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
using AForge.Video;

namespace TransVison
{
    public partial class MainForm : Form
    {
        private MJPEGStream stream = null;
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
            Bitmap currentBitmap = (Bitmap)eventArgs.Frame.Clone();
            originalBox.Image?.Dispose();
            originalBox.Image = currentBitmap;
        }

        private void ColorModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorModelChanged((ColorModel)colorModelBox.SelectedItem);
        }

        private void ColorModelChanged(ColorModel model)
        {
            switch (model)
            {
                case ColorModel.RGB:
                    channel1Box.Text = "R";
                    channel2Box.Text = "G";
                    channel3Box.Text = "B";
                    break;
                case ColorModel.HSV:
                    break;
                case ColorModel.YCrCb:
                    break;
                case ColorModel.GRAY:
                    break;
            }
        }
    }
}
