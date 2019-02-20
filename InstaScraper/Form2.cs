using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace InstaScraper
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        ProcessStartInfo psi = new ProcessStartInfo(@"C:\ProgramData\BlueStacks\Client\Bluestacks.exe");
        Process p = new Process();

        public Form2()
        {
            InitializeComponent();
          
        }


        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        private void Form2_Load(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);

        static readonly int GWL_STYLE = -16;
        static readonly int WS_VISIBLE = 0x10000000;

        private void button1_Click(object sender, EventArgs e)
        {
            p = Process.Start(psi);
            p.WaitForInputIdle();
            Thread.Sleep(3000); //sleep for 3 seconds
            SetParent(p.MainWindowHandle, panel1.Handle);
            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var coordinates = this.PointToClient(Cursor.Position);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Thread t = new Thread(partOne);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog.FileName;


            }


        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            SetParent(p.MainWindowHandle, panel1.Handle);
            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            MoveWindow(p.MainWindowHandle, 0, -300, panel1.Width, panel1.Height, true);

        }

        private void partOne()
        {
            //C:\Users\JoMa\Documents\Visual Studio 2015\Projects\InstaScraper - new 2017-07-29\InstaScraper\bin\Debug
            Invoke(new Action(() => textBox1.Text = @"C:\Users\JoMa\Documents\Visual Studio 2015\Projects\InstaScraper - new 2017-07-29\InstaScraper\bin\Debug\instagram.apk"));
            Point location = new Point();
            int formLoky = 0;
            int formLokx = 0;
            string username = textBox2.Text;
            string password = textBox3.Text;

            //myapps

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 100);
            formLokx = (formLokx + 100);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Thread.Sleep(2000);

            //load app

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 200);
            formLokx = (formLokx + 295);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(5000);

            ////Folder path
            //  Clipboard.SetText(textBox1.Text);

            //SendKeys.SendWait("^v");

            //Thread.Sleep(1000);

            ////Send path

            //SendKeys.SendWait("{ENTER}");

            Thread.Sleep(10000);

            Thread t = new Thread(partTwo);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }


        private void partTwo()
        {
            Clipboard.Clear();

            Point location = new Point();
            int formLoky = 0;
            int formLokx = 0;
            string username = textBox2.Text;
            Clipboard.SetText(textBox2.Text);
            //bring window to front

            Invoke(new Action(() => SetParent(p.MainWindowHandle, panel1.Handle)));
            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            MoveWindow(p.MainWindowHandle, 0, -300, panel1.Width, panel1.Height, true);

            Thread.Sleep(2000);

            //Click login

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 740);
            //formLokx = (formLokx + 310);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(2000);

            ////Click username

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 220);
            //formLokx = (formLokx + 295);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(2000);

            ////insert username

            //SendKeys.SendWait("^v");


            //Thread.Sleep(1000);

            Thread t = new Thread(partThree);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void partThree()
        {
            Clipboard.Clear();

            Point location = new Point();
            int formLoky = 0;
            int formLokx = 0;
            Clipboard.SetText(textBox3.Text);

            Thread.Sleep(1000);

            //Click password

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 260);
            formLokx = (formLokx + 295);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Clipboard.Clear();


            Thread.Sleep(1000);

            //insert password
            Clipboard.SetText(textBox3.Text);

            SendKeys.SendWait("^v");

            Thread.Sleep(1000);


            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 310);
            formLokx = (formLokx + 295);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Thread.Sleep(2000);

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 740);
            formLokx = (formLokx + 300);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Invoke(new Action(() => SetParent(p.MainWindowHandle, panel1.Handle)));
            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            MoveWindow(p.MainWindowHandle, 0, -300, panel1.Width, panel1.Height, true);

            Thread.Sleep(2000);

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 740);
            formLokx = (formLokx + 150);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(2000);

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 740);
            //formLokx = (formLokx + 300);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(2000);

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 740);
            //formLokx = (formLokx + 150);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 740);
            //formLokx = (formLokx + 150);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Invoke(new Action(() => SetParent(p.MainWindowHandle, panel1.Handle)));
            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);

            Thread.Sleep(5000);

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 100);
            formLokx = (formLokx + 150);

            Thread.Sleep(1000);

            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Thread.Sleep(5000);

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 300);
            formLokx = (formLokx + 150);

            Thread.Sleep(1000);

            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Thread.Sleep(5000);

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 440);
            formLokx = (formLokx + 33);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            Thread.Sleep(5000);

            Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            formLoky = Convert.ToInt32(location.Y.ToString());
            formLokx = Convert.ToInt32(location.X.ToString());

            formLoky = (formLoky + 540);
            formLokx = (formLokx + 40);


            SetCursorPos(formLokx, formLoky);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);


            Thread t = new Thread(partFour);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void partFour()
        {
            Clipboard.Clear();
            string imagePath = @"C:\Users\JoMa\Desktop\images\image1.jpg";

            Point location = new Point();
            int formLoky = 0;
            int formLokx = 0;
            Clipboard.SetText(imagePath);

            Thread.Sleep(2000);

            SendKeys.SendWait("^v");

            Thread.Sleep(2000);

            SendKeys.SendWait("{ENTER}");

            //Thread.Sleep(5000);

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 550);
            //formLokx = (formLokx + 1100);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);


            //Thread.Sleep(5000);

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 53);
            //formLokx = (formLokx + 100);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(2000);

            //Invoke(new Action(() => SetParent(p.MainWindowHandle, panel1.Handle)));
            //SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            //MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);

            //Thread.Sleep(2000);

            ////load app

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 200);
            //formLokx = (formLokx + 295);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);

            //Thread.Sleep(5000);

            //Invoke(new Action(() => SetParent(p.MainWindowHandle, panel1.Handle)));
            //SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            //MoveWindow(p.MainWindowHandle, 0, -300, panel1.Width, panel1.Height, true);

            //Thread.Sleep(2000);

            //Invoke(new Action(() => location = this.PointToScreen(Point.Empty)));
            //formLoky = Convert.ToInt32(location.Y.ToString());
            //formLokx = Convert.ToInt32(location.X.ToString());

            //formLoky = (formLoky + 740);
            //formLokx = (formLokx + 300);


            //SetCursorPos(formLokx, formLoky);
            //mouse_event(MOUSEEVENTF_LEFTDOWN, formLoky, formLokx, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, formLoky, formLokx, 0, 0);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
