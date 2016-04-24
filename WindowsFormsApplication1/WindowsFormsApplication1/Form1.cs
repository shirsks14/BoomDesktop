using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr FindWindow(string sClass, string sWindow);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr MoveWindow(IntPtr hWndChild, int X, int Y, int nWidth, int nHeight);
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        //[System.Runtime.InteropServices.DllImport("user32.dll")]

        private const int GWL_STYLE = -16;              //hex constant for style changing
        private const int WS_BORDER = 0x00800000;       //window with border
        private const int WS_CAPTION = 0x00C00000;      //window with a title bar
        private const int WS_SYSMENU = 0x00080000;      //window with no borders etc.
        private const int WS_MINIMIZEBOX = 0x00020000;  //window with minimizebox

        //BoomMain boomdata;
        static soundPlotter.PlotSound plotSound;

        string fileSelected;
        public Form1()
        {
            InitializeComponent();
            this.tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
            //boomdata = new BoomMain();

        }
        void graph(string fileName)
        {
            //chart1.Series["Data"].Points.AddXY(;
            //chart1.Series["Data"].ChartType =
            //            SeriesChartType.FastLine;
            //chart1.Series["Data"].Color = Color.Red;

            label5.Visible = true;
            try
            {
                plotSound = new soundPlotter.PlotSound();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
            try
            {
                MWCharArray input = new MWCharArray(fileName);
                fileSelected = fileName;
                MWArray[] result = new MWArray[2];
                
                result = plotSound.plotSound(2, input);
                textBox3.Text = result[0].ToString();

                //double tempo = Convert.ToDouble(result[1].ToString());
                textBox4.Text = Convert.ToDouble(result[1].ToString()).ToString();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
            string[] temp = fileName.Split('\\');
            label6.Text = temp[temp.Length - 1];
            label5.Visible = false;
            IntPtr foundwindow = FindWindow("sunawtframe", "figure 2");
            SetParent(foundwindow, panel1.Handle);
            MoveWindow(foundwindow, -5, -80, panel1.Width+10, panel1.Height+90);

            foundwindow = FindWindow("sunawtframe", "figure 1");
            SetParent(foundwindow, panel2.Handle);
            MoveWindow(foundwindow, -5, -80, panel2.Width + 10, panel2.Height + 90);
            //SetWindowPos(foundwindow, -2, 0, 0, 800, 600, 0x0040);
            //SetWindowLong(foundwindow, GWL_STYLE, WS_SYSMENU);

        }

        void GetdBwithDistance(double distance)
        {
            MWArray[] result = new MWArray[1];
            MWCharArray file = new MWCharArray(fileSelected);
            MWNumericArray dist = new MWNumericArray(distance);

            result = plotSound.dBAtDistance(1, file, dist);
            textBox1.Text = result[0].ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //graph();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            graph("C:\\Users\\Sujan\\Desktop\\Data\\f1.wav");
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            try
            {
                IntPtr foundwindow = FindWindow("panel1", "figure 1");
                MoveWindow(foundwindow, -5, -80, panel1.Width + 10, panel1.Height + 90);
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graph("C:\\Users\\Sujan\\Desktop\\Data\\d1.wav");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graph("C:\\Users\\Sujan\\Desktop\\Data\\n1.wav");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graph("C:\\Users\\Sujan\\Desktop\\Data\\n2.wav");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph("C:\\Users\\Sujan\\Desktop\\Data\\n3.wav");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetdBwithDistance(Convert.ToDouble(textBox2.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "wav files (*.wav)|*.wav";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                graph(dialog.FileName);
            }
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
        }
    }

}
