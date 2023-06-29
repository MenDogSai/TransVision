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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.connectBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.colorModelBox = new System.Windows.Forms.ComboBox();
            this.channel1Box = new System.Windows.Forms.CheckBox();
            this.channel2Box = new System.Windows.Forms.CheckBox();
            this.channel3Box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(658, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 480);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(12, 526);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(528, 21);
            this.pathBox.TabIndex = 2;
            this.pathBox.Text = "http://192.168.0.3:4747/video?640x480";
            // 
            // connectBox
            // 
            this.connectBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.connectBox.Location = new System.Drawing.Point(548, 524);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "원본";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(959, 508);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(29, 12);
            this.destinationLabel.TabIndex = 6;
            this.destinationLabel.Text = "원본";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorModelBox
            // 
            this.colorModelBox.FormattingEnabled = true;
            this.colorModelBox.Items.AddRange(new object[] {
            "RGB",
            "HSV",
            "YCrCb",
            "Gray"});
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
            this.channel1Box.Size = new System.Drawing.Size(55, 20);
            this.channel1Box.TabIndex = 8;
            this.channel1Box.Text = "R";
            this.channel1Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel1Box.UseVisualStyleBackColor = true;
            // 
            // channel2Box
            // 
            this.channel2Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.channel2Box.Location = new System.Drawing.Point(214, 554);
            this.channel2Box.Name = "channel2Box";
            this.channel2Box.Size = new System.Drawing.Size(55, 20);
            this.channel2Box.TabIndex = 9;
            this.channel2Box.Text = "G";
            this.channel2Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel2Box.UseVisualStyleBackColor = true;
            // 
            // channel3Box
            // 
            this.channel3Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.channel3Box.Location = new System.Drawing.Point(275, 553);
            this.channel3Box.Name = "channel3Box";
            this.channel3Box.Size = new System.Drawing.Size(55, 20);
            this.channel3Box.TabIndex = 10;
            this.channel3Box.Text = "B";
            this.channel3Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel3Box.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 638);
            this.Controls.Add(this.channel3Box);
            this.Controls.Add(this.channel2Box);
            this.Controls.Add(this.channel1Box);
            this.Controls.Add(this.colorModelBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectBox);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.originalBox);
            this.Name = "MainForm";
            this.Text = "TransVison";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.CheckBox connectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.ComboBox colorModelBox;
        private System.Windows.Forms.CheckBox channel1Box;
        private System.Windows.Forms.CheckBox channel2Box;
        private System.Windows.Forms.CheckBox channel3Box;
    }
}

