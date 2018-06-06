namespace XwComPortDetector
{
    partial class Guess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guess));
            this.StatusBox = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check1200 = new System.Windows.Forms.CheckBox();
            this.check2400 = new System.Windows.Forms.CheckBox();
            this.check9600 = new System.Windows.Forms.CheckBox();
            this.check19200 = new System.Windows.Forms.CheckBox();
            this.check38400 = new System.Windows.Forms.CheckBox();
            this.check57600 = new System.Windows.Forms.CheckBox();
            this.check115200 = new System.Windows.Forms.CheckBox();
            this.check4800 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkParityNone = new System.Windows.Forms.CheckBox();
            this.checkData8 = new System.Windows.Forms.CheckBox();
            this.checkParityEven = new System.Windows.Forms.CheckBox();
            this.checkParityOdd = new System.Windows.Forms.CheckBox();
            this.checkParityMark = new System.Windows.Forms.CheckBox();
            this.checkParitySpace = new System.Windows.Forms.CheckBox();
            this.checkData7 = new System.Windows.Forms.CheckBox();
            this.checkData6 = new System.Windows.Forms.CheckBox();
            this.checkData5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkStop1 = new System.Windows.Forms.CheckBox();
            this.checkStop15 = new System.Windows.Forms.CheckBox();
            this.checkStop2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusBox.DetectUrls = false;
            this.StatusBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(0, 173);
            this.StatusBox.MaxLength = 0;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(713, 558);
            this.StatusBox.TabIndex = 5;
            this.StatusBox.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(626, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 63);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Baud Rate";
            // 
            // check1200
            // 
            this.check1200.AutoSize = true;
            this.check1200.Location = new System.Drawing.Point(76, 16);
            this.check1200.Name = "check1200";
            this.check1200.Size = new System.Drawing.Size(50, 17);
            this.check1200.TabIndex = 7;
            this.check1200.Text = "1200";
            this.check1200.UseVisualStyleBackColor = true;
            // 
            // check2400
            // 
            this.check2400.AutoSize = true;
            this.check2400.Checked = true;
            this.check2400.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check2400.Location = new System.Drawing.Point(132, 16);
            this.check2400.Name = "check2400";
            this.check2400.Size = new System.Drawing.Size(50, 17);
            this.check2400.TabIndex = 9;
            this.check2400.Text = "2400";
            this.check2400.UseVisualStyleBackColor = true;
            // 
            // check9600
            // 
            this.check9600.AutoSize = true;
            this.check9600.Checked = true;
            this.check9600.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check9600.Location = new System.Drawing.Point(248, 16);
            this.check9600.Name = "check9600";
            this.check9600.Size = new System.Drawing.Size(50, 17);
            this.check9600.TabIndex = 10;
            this.check9600.Text = "9600";
            this.check9600.UseVisualStyleBackColor = true;
            // 
            // check19200
            // 
            this.check19200.AutoSize = true;
            this.check19200.Checked = true;
            this.check19200.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check19200.Location = new System.Drawing.Point(304, 16);
            this.check19200.Name = "check19200";
            this.check19200.Size = new System.Drawing.Size(56, 17);
            this.check19200.TabIndex = 11;
            this.check19200.Text = "19200";
            this.check19200.UseVisualStyleBackColor = true;
            // 
            // check38400
            // 
            this.check38400.AutoSize = true;
            this.check38400.Checked = true;
            this.check38400.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check38400.Location = new System.Drawing.Point(366, 15);
            this.check38400.Name = "check38400";
            this.check38400.Size = new System.Drawing.Size(56, 17);
            this.check38400.TabIndex = 12;
            this.check38400.Text = "38400";
            this.check38400.UseVisualStyleBackColor = true;
            // 
            // check57600
            // 
            this.check57600.AutoSize = true;
            this.check57600.Checked = true;
            this.check57600.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check57600.Location = new System.Drawing.Point(428, 15);
            this.check57600.Name = "check57600";
            this.check57600.Size = new System.Drawing.Size(56, 17);
            this.check57600.TabIndex = 13;
            this.check57600.Text = "57600";
            this.check57600.UseVisualStyleBackColor = true;
            // 
            // check115200
            // 
            this.check115200.AutoSize = true;
            this.check115200.Checked = true;
            this.check115200.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check115200.Location = new System.Drawing.Point(490, 16);
            this.check115200.Name = "check115200";
            this.check115200.Size = new System.Drawing.Size(62, 17);
            this.check115200.TabIndex = 14;
            this.check115200.Text = "115200";
            this.check115200.UseVisualStyleBackColor = true;
            // 
            // check4800
            // 
            this.check4800.AutoSize = true;
            this.check4800.Checked = true;
            this.check4800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check4800.Location = new System.Drawing.Point(188, 15);
            this.check4800.Name = "check4800";
            this.check4800.Size = new System.Drawing.Size(50, 17);
            this.check4800.TabIndex = 15;
            this.check4800.Text = "4800";
            this.check4800.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data Bits";
            // 
            // checkParityNone
            // 
            this.checkParityNone.AutoSize = true;
            this.checkParityNone.Checked = true;
            this.checkParityNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkParityNone.Location = new System.Drawing.Point(76, 50);
            this.checkParityNone.Name = "checkParityNone";
            this.checkParityNone.Size = new System.Drawing.Size(52, 17);
            this.checkParityNone.TabIndex = 18;
            this.checkParityNone.Text = "None";
            this.checkParityNone.UseVisualStyleBackColor = true;
            // 
            // checkData8
            // 
            this.checkData8.AutoSize = true;
            this.checkData8.Checked = true;
            this.checkData8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkData8.Location = new System.Drawing.Point(76, 86);
            this.checkData8.Name = "checkData8";
            this.checkData8.Size = new System.Drawing.Size(32, 17);
            this.checkData8.TabIndex = 19;
            this.checkData8.Text = "8";
            this.checkData8.UseVisualStyleBackColor = true;
            // 
            // checkParityEven
            // 
            this.checkParityEven.AutoSize = true;
            this.checkParityEven.Location = new System.Drawing.Point(130, 50);
            this.checkParityEven.Name = "checkParityEven";
            this.checkParityEven.Size = new System.Drawing.Size(51, 17);
            this.checkParityEven.TabIndex = 20;
            this.checkParityEven.Text = "Even";
            this.checkParityEven.UseVisualStyleBackColor = true;
            // 
            // checkParityOdd
            // 
            this.checkParityOdd.AutoSize = true;
            this.checkParityOdd.Location = new System.Drawing.Point(186, 50);
            this.checkParityOdd.Name = "checkParityOdd";
            this.checkParityOdd.Size = new System.Drawing.Size(46, 17);
            this.checkParityOdd.TabIndex = 21;
            this.checkParityOdd.Text = "Odd";
            this.checkParityOdd.UseVisualStyleBackColor = true;
            // 
            // checkParityMark
            // 
            this.checkParityMark.AutoSize = true;
            this.checkParityMark.Location = new System.Drawing.Point(248, 50);
            this.checkParityMark.Name = "checkParityMark";
            this.checkParityMark.Size = new System.Drawing.Size(50, 17);
            this.checkParityMark.TabIndex = 22;
            this.checkParityMark.Text = "Mark";
            this.checkParityMark.UseVisualStyleBackColor = true;
            // 
            // checkParitySpace
            // 
            this.checkParitySpace.AutoSize = true;
            this.checkParitySpace.Location = new System.Drawing.Point(304, 50);
            this.checkParitySpace.Name = "checkParitySpace";
            this.checkParitySpace.Size = new System.Drawing.Size(52, 17);
            this.checkParitySpace.TabIndex = 23;
            this.checkParitySpace.Text = "None";
            this.checkParitySpace.UseVisualStyleBackColor = true;
            // 
            // checkData7
            // 
            this.checkData7.AutoSize = true;
            this.checkData7.Location = new System.Drawing.Point(130, 86);
            this.checkData7.Name = "checkData7";
            this.checkData7.Size = new System.Drawing.Size(32, 17);
            this.checkData7.TabIndex = 24;
            this.checkData7.Text = "7";
            this.checkData7.UseVisualStyleBackColor = true;
            // 
            // checkData6
            // 
            this.checkData6.AutoSize = true;
            this.checkData6.Location = new System.Drawing.Point(186, 86);
            this.checkData6.Name = "checkData6";
            this.checkData6.Size = new System.Drawing.Size(32, 17);
            this.checkData6.TabIndex = 25;
            this.checkData6.Text = "6";
            this.checkData6.UseVisualStyleBackColor = true;
            // 
            // checkData5
            // 
            this.checkData5.AutoSize = true;
            this.checkData5.Location = new System.Drawing.Point(248, 86);
            this.checkData5.Name = "checkData5";
            this.checkData5.Size = new System.Drawing.Size(32, 17);
            this.checkData5.TabIndex = 26;
            this.checkData5.Text = "5";
            this.checkData5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stop Bits";
            // 
            // checkStop1
            // 
            this.checkStop1.AutoSize = true;
            this.checkStop1.Checked = true;
            this.checkStop1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkStop1.Location = new System.Drawing.Point(76, 119);
            this.checkStop1.Name = "checkStop1";
            this.checkStop1.Size = new System.Drawing.Size(32, 17);
            this.checkStop1.TabIndex = 28;
            this.checkStop1.Text = "1";
            this.checkStop1.UseVisualStyleBackColor = true;
            // 
            // checkStop15
            // 
            this.checkStop15.AutoSize = true;
            this.checkStop15.Location = new System.Drawing.Point(130, 119);
            this.checkStop15.Name = "checkStop15";
            this.checkStop15.Size = new System.Drawing.Size(41, 17);
            this.checkStop15.TabIndex = 29;
            this.checkStop15.Text = "1.5";
            this.checkStop15.UseVisualStyleBackColor = true;
            // 
            // checkStop2
            // 
            this.checkStop2.AutoSize = true;
            this.checkStop2.Location = new System.Drawing.Point(186, 119);
            this.checkStop2.Name = "checkStop2";
            this.checkStop2.Size = new System.Drawing.Size(32, 17);
            this.checkStop2.TabIndex = 30;
            this.checkStop2.Text = "2";
            this.checkStop2.UseVisualStyleBackColor = true;
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 731);
            this.Controls.Add(this.checkStop2);
            this.Controls.Add(this.checkStop15);
            this.Controls.Add(this.checkStop1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkData5);
            this.Controls.Add(this.checkData6);
            this.Controls.Add(this.checkData7);
            this.Controls.Add(this.checkParitySpace);
            this.Controls.Add(this.checkParityMark);
            this.Controls.Add(this.checkParityOdd);
            this.Controls.Add(this.checkParityEven);
            this.Controls.Add(this.checkData8);
            this.Controls.Add(this.checkParityNone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check4800);
            this.Controls.Add(this.check115200);
            this.Controls.Add(this.check57600);
            this.Controls.Add(this.check38400);
            this.Controls.Add(this.check19200);
            this.Controls.Add(this.check9600);
            this.Controls.Add(this.check2400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check1200);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.StatusBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Guess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Work";
            this.Load += new System.EventHandler(this.Guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatusBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check1200;
        private System.Windows.Forms.CheckBox check2400;
        private System.Windows.Forms.CheckBox check9600;
        private System.Windows.Forms.CheckBox check19200;
        private System.Windows.Forms.CheckBox check38400;
        private System.Windows.Forms.CheckBox check57600;
        private System.Windows.Forms.CheckBox check115200;
        private System.Windows.Forms.CheckBox check4800;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkParityNone;
        private System.Windows.Forms.CheckBox checkData8;
        private System.Windows.Forms.CheckBox checkParityEven;
        private System.Windows.Forms.CheckBox checkParityOdd;
        private System.Windows.Forms.CheckBox checkParityMark;
        private System.Windows.Forms.CheckBox checkParitySpace;
        private System.Windows.Forms.CheckBox checkData7;
        private System.Windows.Forms.CheckBox checkData6;
        private System.Windows.Forms.CheckBox checkData5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkStop1;
        private System.Windows.Forms.CheckBox checkStop15;
        private System.Windows.Forms.CheckBox checkStop2;
    }
}