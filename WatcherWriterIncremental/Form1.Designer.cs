namespace WatcherWriterIncremental
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.headerLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.readTextBoxBg = new System.Windows.Forms.Button();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.writeTextBoxBg = new System.Windows.Forms.Button();
            this.readTextLabel = new System.Windows.Forms.Label();
            this.writeTextLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.writeIntervalFrom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.writeIntervalTo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.countWriteBlockTo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.countWriteBlockFrom = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeTickValue = new System.Windows.Forms.Label();
            this.TimerTickValueLabel = new System.Windows.Forms.Label();
            this.offsetNumLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.headerLabel.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(133, 10, 133, 10);
            this.headerLabel.Size = new System.Drawing.Size(507, 45);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "WatchWriterIncremental";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerLabel_MouseDown);
            this.headerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerLabel_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox1.Location = new System.Drawing.Point(12, 359);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 162);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(505, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 520);
            this.label1.Size = new System.Drawing.Size(3, 533);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 520);
            this.label2.Size = new System.Drawing.Size(3, 533);
            this.label2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(0, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 505, 0);
            this.label5.Size = new System.Drawing.Size(505, 13);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(9, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 490, 155);
            this.label6.Size = new System.Drawing.Size(490, 168);
            this.label6.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(503, 3);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // readTextBox
            // 
            this.readTextBox.BackColor = System.Drawing.Color.White;
            this.readTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readTextBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.readTextBox.HideSelection = false;
            this.readTextBox.Location = new System.Drawing.Point(119, 63);
            this.readTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 3, 3);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(361, 19);
            this.readTextBox.TabIndex = 1;
            this.readTextBox.Text = "c:\\WORK\\log\\Incremental\\TopologyService.log";
            // 
            // readTextBoxBg
            // 
            this.readTextBoxBg.BackColor = System.Drawing.Color.RoyalBlue;
            this.readTextBoxBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.readTextBoxBg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readTextBoxBg.Location = new System.Drawing.Point(116, 60);
            this.readTextBoxBg.Name = "readTextBoxBg";
            this.readTextBoxBg.Size = new System.Drawing.Size(367, 25);
            this.readTextBoxBg.TabIndex = 25;
            this.readTextBoxBg.UseVisualStyleBackColor = false;
            // 
            // writeTextBox
            // 
            this.writeTextBox.BackColor = System.Drawing.Color.White;
            this.writeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.writeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeTextBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.writeTextBox.Location = new System.Drawing.Point(119, 105);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(361, 19);
            this.writeTextBox.TabIndex = 2;
            this.writeTextBox.Text = "c:\\WORK\\log\\Incremental\\To123.log";
            // 
            // writeTextBoxBg
            // 
            this.writeTextBoxBg.BackColor = System.Drawing.Color.RoyalBlue;
            this.writeTextBoxBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.writeTextBoxBg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeTextBoxBg.Location = new System.Drawing.Point(116, 102);
            this.writeTextBoxBg.Name = "writeTextBoxBg";
            this.writeTextBoxBg.Size = new System.Drawing.Size(367, 25);
            this.writeTextBoxBg.TabIndex = 27;
            this.writeTextBoxBg.UseVisualStyleBackColor = false;
            // 
            // readTextLabel
            // 
            this.readTextLabel.AutoSize = true;
            this.readTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readTextLabel.Location = new System.Drawing.Point(22, 62);
            this.readTextLabel.Name = "readTextLabel";
            this.readTextLabel.Size = new System.Drawing.Size(69, 20);
            this.readTextLabel.TabIndex = 28;
            this.readTextLabel.Text = "Откуда:";
            // 
            // writeTextLabel
            // 
            this.writeTextLabel.AutoSize = true;
            this.writeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeTextLabel.Location = new System.Drawing.Point(22, 105);
            this.writeTextLabel.Name = "writeTextLabel";
            this.writeTextLabel.Size = new System.Drawing.Size(50, 20);
            this.writeTextLabel.TabIndex = 29;
            this.writeTextLabel.Text = "Куда:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(12, 231);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(484, 46);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // writeIntervalFrom
            // 
            this.writeIntervalFrom.BackColor = System.Drawing.Color.White;
            this.writeIntervalFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.writeIntervalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeIntervalFrom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.writeIntervalFrom.Location = new System.Drawing.Point(188, 147);
            this.writeIntervalFrom.Name = "writeIntervalFrom";
            this.writeIntervalFrom.Size = new System.Drawing.Size(31, 19);
            this.writeIntervalFrom.TabIndex = 3;
            this.writeIntervalFrom.Text = "1";
            this.writeIntervalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.writeIntervalFrom.Leave += new System.EventHandler(this.writeInterval_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(185, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 25);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // writeIntervalTo
            // 
            this.writeIntervalTo.BackColor = System.Drawing.Color.White;
            this.writeIntervalTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.writeIntervalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeIntervalTo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.writeIntervalTo.Location = new System.Drawing.Point(280, 147);
            this.writeIntervalTo.Name = "writeIntervalTo";
            this.writeIntervalTo.Size = new System.Drawing.Size(31, 19);
            this.writeIntervalTo.TabIndex = 4;
            this.writeIntervalTo.Text = "10";
            this.writeIntervalTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.writeIntervalTo.Leave += new System.EventHandler(this.writeInterval_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(277, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 25);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // countWriteBlockTo
            // 
            this.countWriteBlockTo.BackColor = System.Drawing.Color.White;
            this.countWriteBlockTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countWriteBlockTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countWriteBlockTo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.countWriteBlockTo.Location = new System.Drawing.Point(280, 186);
            this.countWriteBlockTo.Name = "countWriteBlockTo";
            this.countWriteBlockTo.Size = new System.Drawing.Size(31, 19);
            this.countWriteBlockTo.TabIndex = 6;
            this.countWriteBlockTo.Text = "100";
            this.countWriteBlockTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countWriteBlockTo.Leave += new System.EventHandler(this.countWriteBlock_Leave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(277, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 25);
            this.button4.TabIndex = 38;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // countWriteBlockFrom
            // 
            this.countWriteBlockFrom.BackColor = System.Drawing.Color.White;
            this.countWriteBlockFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countWriteBlockFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countWriteBlockFrom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.countWriteBlockFrom.Location = new System.Drawing.Point(188, 186);
            this.countWriteBlockFrom.Name = "countWriteBlockFrom";
            this.countWriteBlockFrom.Size = new System.Drawing.Size(31, 19);
            this.countWriteBlockFrom.TabIndex = 5;
            this.countWriteBlockFrom.Text = "1";
            this.countWriteBlockFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countWriteBlockFrom.Leave += new System.EventHandler(this.countWriteBlock_Leave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(185, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 25);
            this.button5.TabIndex = 36;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Интервал записи:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Кол-во строк:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(235, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(235, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(332, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "сек.";
            // 
            // TimeTickValue
            // 
            this.TimeTickValue.AutoSize = true;
            this.TimeTickValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTickValue.Location = new System.Drawing.Point(84, 294);
            this.TimeTickValue.Name = "TimeTickValue";
            this.TimeTickValue.Size = new System.Drawing.Size(15, 16);
            this.TimeTickValue.TabIndex = 44;
            this.TimeTickValue.Text = "0";
            // 
            // TimerTickValueLabel
            // 
            this.TimerTickValueLabel.AutoSize = true;
            this.TimerTickValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerTickValueLabel.Location = new System.Drawing.Point(13, 294);
            this.TimerTickValueLabel.Name = "TimerTickValueLabel";
            this.TimerTickValueLabel.Size = new System.Drawing.Size(72, 16);
            this.TimerTickValueLabel.TabIndex = 45;
            this.TimerTickValueLabel.Text = "TimerTick:";
            // 
            // offsetNumLabel
            // 
            this.offsetNumLabel.AutoSize = true;
            this.offsetNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.offsetNumLabel.Location = new System.Drawing.Point(84, 320);
            this.offsetNumLabel.Name = "offsetNumLabel";
            this.offsetNumLabel.Size = new System.Drawing.Size(15, 16);
            this.offsetNumLabel.TabIndex = 46;
            this.offsetNumLabel.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(13, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "OffsetNum:";
            // 
            // closeAppButton
            // 
            this.closeAppButton.AutoEllipsis = true;
            this.closeAppButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeAppButton.ForeColor = System.Drawing.Color.White;
            this.closeAppButton.Location = new System.Drawing.Point(466, 5);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(39, 35);
            this.closeAppButton.TabIndex = 9;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(508, 533);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.offsetNumLabel);
            this.Controls.Add(this.TimerTickValueLabel);
            this.Controls.Add(this.TimeTickValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countWriteBlockTo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.countWriteBlockFrom);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.writeIntervalTo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.writeIntervalFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.writeTextLabel);
            this.Controls.Add(this.readTextLabel);
            this.Controls.Add(this.writeTextBox);
            this.Controls.Add(this.writeTextBoxBg);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.readTextBoxBg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerLabel);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.Button readTextBoxBg;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.Button writeTextBoxBg;
        private System.Windows.Forms.Label readTextLabel;
        private System.Windows.Forms.Label writeTextLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox writeIntervalFrom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox writeIntervalTo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox countWriteBlockTo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox countWriteBlockFrom;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimeTickValue;
        private System.Windows.Forms.Label TimerTickValueLabel;
        private System.Windows.Forms.Label offsetNumLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button closeAppButton;
    }
}

