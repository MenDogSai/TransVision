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
            this.label1 = new System.Windows.Forms.Label();
            this.colorModelBox = new System.Windows.Forms.ComboBox();
            this.channel1Box = new System.Windows.Forms.CheckBox();
            this.channel2Box = new System.Windows.Forms.CheckBox();
            this.channel3Box = new System.Windows.Forms.CheckBox();
            this.filterScrollBar = new System.Windows.Forms.HScrollBar();
            this.filterLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            this.filterSizeLabel = new System.Windows.Forms.Label();
            this.filterSizeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "경로";
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
            // filterScrollBar
            // 
            this.filterScrollBar.LargeChange = 1;
            this.filterScrollBar.Location = new System.Drawing.Point(894, 526);
            this.filterScrollBar.Maximum = 8;
            this.filterScrollBar.Name = "filterScrollBar";
            this.filterScrollBar.Size = new System.Drawing.Size(121, 22);
            this.filterScrollBar.TabIndex = 13;
            this.filterScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FilterScrollBar_Scroll);
            // 
            // filterLabel
            // 
            this.filterLabel.Location = new System.Drawing.Point(892, 505);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(123, 23);
            this.filterLabel.TabIndex = 14;
            this.filterLabel.Text = "NONE";
            this.filterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.filterSizeLabel.Location = new System.Drawing.Point(1039, 526);
            this.filterSizeLabel.Name = "filterSizeLabel";
            this.filterSizeLabel.Size = new System.Drawing.Size(73, 12);
            this.filterSizeLabel.TabIndex = 16;
            this.filterSizeLabel.Text = "필터 사이즈:";
            // 
            // filterSizeBox
            // 
            this.filterSizeBox.FormattingEnabled = true;
            this.filterSizeBox.Items.AddRange(new object[] {
            "1",
            "3",
            "9"});
            this.filterSizeBox.Location = new System.Drawing.Point(1116, 523);
            this.filterSizeBox.Name = "filterSizeBox";
            this.filterSizeBox.Size = new System.Drawing.Size(36, 20);
            this.filterSizeBox.TabIndex = 18;
            this.filterSizeBox.SelectedIndexChanged += new System.EventHandler(this.FilterSizeBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 604);
            this.Controls.Add(this.filterSizeBox);
            this.Controls.Add(this.filterSizeLabel);
            this.Controls.Add(this.thresholdBar);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterScrollBar);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.channel3Box);
            this.Controls.Add(this.channel2Box);
            this.Controls.Add(this.channel1Box);
            this.Controls.Add(this.colorModelBox);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalBox;
        private System.Windows.Forms.PictureBox filterBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.CheckBox connectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colorModelBox;
        private System.Windows.Forms.CheckBox channel1Box;
        private System.Windows.Forms.CheckBox channel2Box;
        private System.Windows.Forms.CheckBox channel3Box;
        private System.Windows.Forms.HScrollBar filterScrollBar;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TrackBar thresholdBar;
        private System.Windows.Forms.Label filterSizeLabel;
        private System.Windows.Forms.ComboBox filterSizeBox;
    }
}

