using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WatcherWriterIncremental
{
    public partial class Form1 : Form
    {
        string[] tag = { "ERROR", "DEBUG", "INFO", "WARNING" };
        int offset = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(writeTextBox.Text) && File.Exists(readTextBox.Text))
            {
                if (timer1.Enabled == true)
                {
                    startButton.Text = "Начать";
                    timer1.Stop();
                }
                else
                {
                    timer1.Interval = 1000; // by default
                    TimeTickValue.Text = timer1.Interval.ToString();
                    timer1.Tick += Timer1_Tick;
                    startButton.Text = "Остановить";
                    timer1.Start();
                }
            }
            else
            {
                toLog("Не заполнен один из путей к файлу!");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                var countWriteBlock = getCountWriteBlockTo();

                List<string> writeBlock = File.ReadAllLines(readTextBox.Text).Skip(offset).Take(countWriteBlock).ToList();

                if (writeBlock.Count > 0)
                {
                    offset += writeBlock.Count;

                    offsetNumLabel.Text = offset.ToString();

                    //if (string.IsNullOrEmpty(writeBlock.First()) || writeBlock.First() == "\t")
                    //writeBlock.Insert(0, "\r\n");

                    toLog(string.Format("{0} Попытка записать {1} строк с интервалом в {2}", DateTime.Now, countWriteBlock, timer1.Interval));

                    File.AppendAllLines(writeTextBox.Text, writeBlock);

                    toLog("Данные записаны!");

                    timer1.Interval = getRndWriteInterval() * 1000;
                    TimeTickValue.Text = timer1.Interval.ToString();
                } else
                {
                    startButton_Click(null, new EventArgs());
                    var s = Path.GetFileName(readTextBox.Text);
                    toLog(string.Format("Чтение файла {0} закончилось!", s));
                }
            }
            catch (Exception ex)
            {
                toLog(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Header Content

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Point mouseLocation;
        private void headerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void headerLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        #endregion

        private void writeInterval_Leave(object sender, EventArgs e)
        {
            TextBox writeInterval = (TextBox)sender;
            try
            {
                var min = Convert.ToInt32(writeIntervalFrom.Text);
                var max = Convert.ToInt32(writeIntervalTo.Text);
                if (min > max)
                    writeIntervalTo.Text = min.ToString();
                else if (max < min)
                    writeIntervalFrom.Text = max.ToString();
            }
            catch
            {
                // drop to default value
                if (writeInterval.Name == "writeIntervalFrom")
                    writeIntervalFrom.Text = writeIntervalTo.Text;
                else
                    writeIntervalTo.Text = writeIntervalFrom.Text;
            }
            
            //writeInterval.Text = checkRange(writeInterval.Text, 1, 60);
        }

        private void countWriteBlock_Leave(object sender, EventArgs e)
        {
            TextBox countWrite = (TextBox)sender;
            try
            {
                var min = Convert.ToInt32(countWriteBlockFrom.Text);
                var max = Convert.ToInt32(countWriteBlockTo.Text);
                if (min > max)
                    countWriteBlockTo.Text = min.ToString();
                else if (max < min)
                    countWriteBlockFrom.Text = max.ToString();
            }
            catch
            {
                // drop to default value
                if (countWrite.Name == "writeIntervalFrom")
                    countWriteBlockFrom.Text = countWriteBlockTo.Text;
                else
                    countWriteBlockTo.Text = countWriteBlockFrom.Text;
            }
        }

        private void writeIntervalToUp_Click(object sender, EventArgs e)
        {
            var value = incrementValue(writeIntervalFrom.Text);
            writeIntervalFrom.Text = value;
        }

        private void writeIntervalToDown_Click(object sender, EventArgs e)
        {
            var value = writeIntervalFrom.Text;
            writeIntervalFrom.Text = decrementValue(value);
        }

        /// <summary>
        /// Check range
        /// </summary>
        /// <param name="input"></param>
        /// <param name="minV"></param>
        /// <param name="maxV"></param>
        /// <returns></returns>
        private string checkRange(string input, int minV, int maxV)
        {
            var output = ""; // by default
            try
            {
                var i = Convert.ToInt32(input);
                output = i.ToString();
                if (i > maxV)
                {
                    output = maxV.ToString();
                }
                else if (i < minV)
                {
                    output = minV.ToString();
                }
            }
            catch
            {
                output = minV.ToString();
            }

            return output;
        }

        /// <summary>
        /// Return integet write interval
        /// </summary>
        /// <returns></returns>
        private int getRndWriteInterval()
        {
            var rnd = new Random();
            var rndMinValue = Convert.ToInt32(writeIntervalFrom.Text);
            var rndMaxValue = Convert.ToInt32(writeIntervalTo.Text);
            var output = 0;

            if (rndMinValue == rndMaxValue)
                output = rndMaxValue;
            else
                output = rnd.Next(rndMinValue, rndMaxValue);

            return output;
        }
        /// <summary>
        /// Return number of line from application form
        /// </summary>
        /// <returns></returns>
        private int getCountWriteBlockTo()
        {
            var rnd = new Random();
            var rndMinValue = Convert.ToInt32(countWriteBlockFrom.Text);
            var rndMaxValue = Convert.ToInt32(countWriteBlockTo.Text);

            if (rndMinValue == rndMaxValue)
                return rndMaxValue;
            else
                return rnd.Next(rndMinValue, rndMaxValue);
        }

        private string incrementValue(string value)
        {
            try {
                var vInt = Convert.ToInt32(value);
                vInt++;
                return vInt.ToString();
            } catch {
                return "0";
            }
        }

        private string decrementValue(string value)
        {
            try
            {
                var vInt = Convert.ToInt32(value);
                vInt--;
                return vInt.ToString();
            }
            catch
            {
                return "0";
            }
        }
        private void toLog(string s)
        {
            richTextBox1.AppendText("#############################\n");
            richTextBox1.AppendText(s + ";\n");
            richTextBox1.ScrollToCaret();
        }
    }
}
