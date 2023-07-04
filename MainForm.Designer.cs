namespace TransVison
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalBox = new System.Windows.Forms.PictureBox();
            this.filterBox = new System.Windows.Forms.PictureBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.connectBox = new System.Windows.Forms.CheckBox();
            this.colorModelBox = new System.Windows.Forms.ComboBox();
            this.channel1Box = new System.Windows.Forms.CheckBox();
            this.channel2Box = new System.Windows.Forms.CheckBox();
            this.channel3Box = new System.Windows.Forms.CheckBox();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            this.filterSizeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.blurBilateralButton = new System.Windows.Forms.RadioButton();
            this.blurGaussianButton = new System.Windows.Forms.RadioButton();
            this.blurMeanButton = new System.Windows.Forms.RadioButton();
            this.blurMedianButton = new System.Windows.Forms.RadioButton();
            this.blurNoneButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edgeLaplacianButton = new System.Windows.Forms.RadioButton();
            this.edgeRobertsButton = new System.Windows.Forms.RadioButton();
            this.edgePrewittButton = new System.Windows.Forms.RadioButton();
            this.edgeCannyButton = new System.Windows.Forms.RadioButton();
            this.edgeSobelButton = new System.Windows.Forms.RadioButton();
            this.edgeNoneButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalBox
            // 
            this.originalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalBox.Location = new System.Drawing.Point(12, 12);
            this.originalBox.Name = "originalBox";
            this.originalBox.Size = new System.Drawing.Size(640, 480);
            this.originalBox.TabIndex = 0;
            this.originalBox.TabStop = false;
            // 
            // filterBox
            // 
            this.filterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterBox.Location = new System.Drawing.Point(658, 12);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(640, 480);
            this.filterBox.TabIndex = 1;
            this.filterBox.TabStop = false;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(12, 526);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(465, 21);
            this.pathBox.TabIndex = 2;
            this.pathBox.Text = "http://192.168.0.76:4747/video?640x480";
            // 
            // connectBox
            // 
            this.connectBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.connectBox.Location = new System.Drawing.Point(483, 526);
            this.connectBox.Name = "connectBox";
            this.connectBox.Size = new System.Drawing.Size(104, 24);
            this.connectBox.TabIndex = 3;
            this.connectBox.Text = "연결 시작";
            this.connectBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectBox.UseVisualStyleBackColor = true;
            this.connectBox.CheckedChanged += new System.EventHandler(this.ConnectBox_CheckedChanged);
            // 
            // colorModelBox
            // 
            this.colorModelBox.FormattingEnabled = true;
            this.colorModelBox.Items.AddRange(new object[] {
            "RGB",
            "HSV",
            "YCrCb",
            "Gray",
            "Binary"});
            this.colorModelBox.Location = new System.Drawing.Point(15, 554);
            this.colorModelBox.Name = "colorModelBox";
            this.colorModelBox.Size = new System.Drawing.Size(121, 20);
            this.colorModelBox.TabIndex = 7;
            this.colorModelBox.SelectedIndexChanged += new System.EventHandler(this.ColorModelBox_SelectedIndexChanged);
            // 
            // channel1Box
            // 
            this.channel1Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.channel1Box.Location = new System.Drawing.Point(153, 554);
            this.channel1Box.Name = "channel1Box";
            this.channel1Box.Size = new System.Drawing.Size(70, 20);
            this.channel1Box.TabIndex = 8;
            this.channel1Box.Text = "CH1";
            this.channel1Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel1Box.UseVisualStyleBackColor = true;
            this.channel1Box.CheckedChanged += new System.EventHandler(this.Channel1Box_CheckedChanged);
            // 
            // channel2Box
            // 
            this.channel2Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.channel2Box.Location = new System.Drawing.Point(229, 554);
            this.channel2Box.Name = "channel2Box";
            this.channel2Box.Size = new System.Drawing.Size(70, 20);
            this.channel2Box.TabIndex = 9;
            this.channel2Box.Text = "CH2";
            this.channel2Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel2Box.UseVisualStyleBackColor = true;
            this.channel2Box.CheckedChanged += new System.EventHandler(this.Channel2Box_CheckedChanged);
            // 
            // channel3Box
            // 
            this.channel3Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.channel3Box.Location = new System.Drawing.Point(305, 554);
            this.channel3Box.Name = "channel3Box";
            this.channel3Box.Size = new System.Drawing.Size(70, 20);
            this.channel3Box.TabIndex = 10;
            this.channel3Box.Text = "CH3";
            this.channel3Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel3Box.UseVisualStyleBackColor = true;
            this.channel3Box.CheckedChanged += new System.EventHandler(this.Channel3Box_CheckedChanged);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(153, 558);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(63, 12);
            this.thresholdLabel.TabIndex = 11;
            this.thresholdLabel.Text = "임계값:125";
            // 
            // thresholdBar
            // 
            this.thresholdBar.Location = new System.Drawing.Point(251, 554);
            this.thresholdBar.Maximum = 254;
            this.thresholdBar.Minimum = 1;
            this.thresholdBar.Name = "thresholdBar";
            this.thresholdBar.Size = new System.Drawing.Size(336, 45);
            this.thresholdBar.TabIndex = 15;
            this.thresholdBar.Value = 1;
            this.thresholdBar.Scroll += new System.EventHandler(this.ThresholdBar_Scroll);
            // 
            // filterSizeLabel
            // 
            this.filterSizeLabel.AutoSize = true;
            this.filterSizeLabel.Location = new System.Drawing.Point(441, 10);
            this.filterSizeLabel.Name = "filterSizeLabel";
            this.filterSizeLabel.Size = new System.Drawing.Size(73, 12);
            this.filterSizeLabel.TabIndex = 16;
            this.filterSizeLabel.Text = "필터 사이즈:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.filterSizeNumeric);
            this.panel1.Controls.Add(this.blurBilateralButton);
            this.panel1.Controls.Add(this.blurGaussianButton);
            this.panel1.Controls.Add(this.blurMeanButton);
            this.panel1.Controls.Add(this.filterSizeLabel);
            this.panel1.Controls.Add(this.blurMedianButton);
            this.panel1.Controls.Add(this.blurNoneButton);
            this.panel1.Location = new System.Drawing.Point(658, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 33);
            this.panel1.TabIndex = 19;
            // 
            // filterSizeNumeric
            // 
            this.filterSizeNumeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.filterSizeNumeric.Location = new System.Drawing.Point(520, 8);
            this.filterSizeNumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.filterSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filterSizeNumeric.Name = "filterSizeNumeric";
            this.filterSizeNumeric.Size = new System.Drawing.Size(44, 21);
            this.filterSizeNumeric.TabIndex = 21;
            this.filterSizeNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // blurBilateralButton
            // 
            this.blurBilateralButton.Location = new System.Drawing.Point(355, 4);
            this.blurBilateralButton.Name = "blurBilateralButton";
            this.blurBilateralButton.Size = new System.Drawing.Size(82, 24);
            this.blurBilateralButton.TabIndex = 20;
            this.blurBilateralButton.TabStop = true;
            this.blurBilateralButton.Text = "Bilateral";
            this.blurBilateralButton.UseVisualStyleBackColor = true;
            this.blurBilateralButton.CheckedChanged += new System.EventHandler(this.BlurBilateralButton_CheckedChanged);
            // 
            // blurGaussianButton
            // 
            this.blurGaussianButton.Location = new System.Drawing.Point(267, 4);
            this.blurGaussianButton.Name = "blurGaussianButton";
            this.blurGaussianButton.Size = new System.Drawing.Size(82, 24);
            this.blurGaussianButton.TabIndex = 20;
            this.blurGaussianButton.TabStop = true;
            this.blurGaussianButton.Text = "Gaussian";
            this.blurGaussianButton.UseVisualStyleBackColor = true;
            this.blurGaussianButton.CheckedChanged += new System.EventHandler(this.BlurGaussianButton_CheckedChanged);
            // 
            // blurMeanButton
            // 
            this.blurMeanButton.Location = new System.Drawing.Point(179, 4);
            this.blurMeanButton.Name = "blurMeanButton";
            this.blurMeanButton.Size = new System.Drawing.Size(82, 24);
            this.blurMeanButton.TabIndex = 20;
            this.blurMeanButton.TabStop = true;
            this.blurMeanButton.Text = "Mean";
            this.blurMeanButton.UseVisualStyleBackColor = true;
            this.blurMeanButton.CheckedChanged += new System.EventHandler(this.BlurMeanButton_CheckedChanged);
            // 
            // blurMedianButton
            // 
            this.blurMedianButton.Location = new System.Drawing.Point(91, 4);
            this.blurMedianButton.Name = "blurMedianButton";
            this.blurMedianButton.Size = new System.Drawing.Size(82, 24);
            this.blurMedianButton.TabIndex = 2;
            this.blurMedianButton.TabStop = true;
            this.blurMedianButton.Text = "Median";
            this.blurMedianButton.UseVisualStyleBackColor = true;
            this.blurMedianButton.CheckedChanged += new System.EventHandler(this.BlurMedianButton_CheckedChanged);
            // 
            // blurNoneButton
            // 
            this.blurNoneButton.Checked = true;
            this.blurNoneButton.Location = new System.Drawing.Point(3, 4);
            this.blurNoneButton.Name = "blurNoneButton";
            this.blurNoneButton.Size = new System.Drawing.Size(82, 24);
            this.blurNoneButton.TabIndex = 1;
            this.blurNoneButton.TabStop = true;
            this.blurNoneButton.Text = "None";
            this.blurNoneButton.UseVisualStyleBackColor = true;
            this.blurNoneButton.CheckedChanged += new System.EventHandler(this.BlurNoneButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.edgeLaplacianButton);
            this.panel2.Controls.Add(this.edgeRobertsButton);
            this.panel2.Controls.Add(this.edgePrewittButton);
            this.panel2.Controls.Add(this.edgeCannyButton);
            this.panel2.Controls.Add(this.edgeSobelButton);
            this.panel2.Controls.Add(this.edgeNoneButton);
            this.panel2.Location = new System.Drawing.Point(659, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 33);
            this.panel2.TabIndex = 20;
            // 
            // edgeLaplacianButton
            // 
            this.edgeLaplacianButton.Location = new System.Drawing.Point(443, 3);
            this.edgeLaplacianButton.Name = "edgeLaplacianButton";
            this.edgeLaplacianButton.Size = new System.Drawing.Size(82, 24);
            this.edgeLaplacianButton.TabIndex = 21;
            this.edgeLaplacianButton.TabStop = true;
            this.edgeLaplacianButton.Text = "Laplacian";
            this.edgeLaplacianButton.UseVisualStyleBackColor = true;
            this.edgeLaplacianButton.CheckedChanged += new System.EventHandler(this.EdgeLaplacianButton_CheckedChanged);
            // 
            // edgeRobertsButton
            // 
            this.edgeRobertsButton.Location = new System.Drawing.Point(355, 4);
            this.edgeRobertsButton.Name = "edgeRobertsButton";
            this.edgeRobertsButton.Size = new System.Drawing.Size(82, 24);
            this.edgeRobertsButton.TabIndex = 20;
            this.edgeRobertsButton.TabStop = true;
            this.edgeRobertsButton.Text = "Roberts";
            this.edgeRobertsButton.UseVisualStyleBackColor = true;
            this.edgeRobertsButton.CheckedChanged += new System.EventHandler(this.EdgeRobertsButton_CheckedChanged);
            // 
            // edgePrewittButton
            // 
            this.edgePrewittButton.Location = new System.Drawing.Point(267, 4);
            this.edgePrewittButton.Name = "edgePrewittButton";
            this.edgePrewittButton.Size = new System.Drawing.Size(82, 24);
            this.edgePrewittButton.TabIndex = 20;
            this.edgePrewittButton.TabStop = true;
            this.edgePrewittButton.Text = "Prewitt";
            this.edgePrewittButton.UseVisualStyleBackColor = true;
            this.edgePrewittButton.CheckedChanged += new System.EventHandler(this.EdgePrewittButton_CheckedChanged);
            // 
            // edgeCannyButton
            // 
            this.edgeCannyButton.Location = new System.Drawing.Point(179, 4);
            this.edgeCannyButton.Name = "edgeCannyButton";
            this.edgeCannyButton.Size = new System.Drawing.Size(82, 24);
            this.edgeCannyButton.TabIndex = 20;
            this.edgeCannyButton.TabStop = true;
            this.edgeCannyButton.Text = "Canny";
            this.edgeCannyButton.UseVisualStyleBackColor = true;
            this.edgeCannyButton.CheckedChanged += new System.EventHandler(this.EdgeCannyButton_CheckedChanged);
            // 
            // edgeSobelButton
            // 
            this.edgeSobelButton.Location = new System.Drawing.Point(91, 4);
            this.edgeSobelButton.Name = "edgeSobelButton";
            this.edgeSobelButton.Size = new System.Drawing.Size(82, 24);
            this.edgeSobelButton.TabIndex = 2;
            this.edgeSobelButton.TabStop = true;
            this.edgeSobelButton.Text = "Sobel";
            this.edgeSobelButton.UseVisualStyleBackColor = true;
            this.edgeSobelButton.CheckedChanged += new System.EventHandler(this.EdgeSobelButton_CheckedChanged);
            // 
            // edgeNoneButton
            // 
            this.edgeNoneButton.Checked = true;
            this.edgeNoneButton.Location = new System.Drawing.Point(3, 4);
            this.edgeNoneButton.Name = "edgeNoneButton";
            this.edgeNoneButton.Size = new System.Drawing.Size(82, 24);
            this.edgeNoneButton.TabIndex = 1;
            this.edgeNoneButton.TabStop = true;
            this.edgeNoneButton.Text = "None";
            this.edgeNoneButton.UseVisualStyleBackColor = true;
            this.edgeNoneButton.CheckedChanged += new System.EventHandler(this.EdgeNoneButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thresholdBar);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.channel3Box);
            this.Controls.Add(this.channel2Box);
            this.Controls.Add(this.channel1Box);
            this.Controls.Add(this.colorModelBox);
            this.Controls.Add(this.connectBox);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.originalBox);
            this.Name = "MainForm";
            this.Text = "TransVison";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalBox;
        private System.Windows.Forms.PictureBox filterBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.CheckBox connectBox;
        private System.Windows.Forms.ComboBox colorModelBox;
        private System.Windows.Forms.CheckBox channel1Box;
        private System.Windows.Forms.CheckBox channel2Box;
        private System.Windows.Forms.CheckBox channel3Box;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TrackBar thresholdBar;
        private System.Windows.Forms.Label filterSizeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton blurNoneButton;
        private System.Windows.Forms.RadioButton blurBilateralButton;
        private System.Windows.Forms.RadioButton blurGaussianButton;
        private System.Windows.Forms.RadioButton blurMeanButton;
        private System.Windows.Forms.RadioButton blurMedianButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton edgeRobertsButton;
        private System.Windows.Forms.RadioButton edgePrewittButton;
        private System.Windows.Forms.RadioButton edgeCannyButton;
        private System.Windows.Forms.RadioButton edgeSobelButton;
        private System.Windows.Forms.RadioButton edgeNoneButton;
        private System.Windows.Forms.RadioButton edgeLaplacianButton;
        private System.Windows.Forms.NumericUpDown filterSizeNumeric;
    }
}

