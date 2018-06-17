using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using InputManager;

namespace Test_Version
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string gameName = "l2";

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public void focusL2()
        {
            Process[] prs = Process.GetProcessesByName(gameName);

            if (prs.Length > 0)
            {
                if (prs[0].MainWindowHandle != IntPtr.Zero)
                {
                    SetForegroundWindow(prs[0].MainWindowHandle);
                }
            }
        }
        public void sendInput(Keys key)
        {
            Process[] pname = Process.GetProcessesByName("l2");
            if (pname.Length == 0)
            {
                MessageBox.Show("L2 is not running!");
                return;
            }

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Keyboard.KeyDown(key);
                Thread.Sleep(1000); //wait for 1 second
                Keyboard.KeyUp(key);

            }).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == null)
            {
                MessageBox.Show("Invalid game name!");
                return;
            }
            
            gameName = textBox1.Text;
            gameName = gameName.Trim();

            Process[] pname = Process.GetProcessesByName(gameName);
            string name = "";
            bool found = false;
            foreach (Process p in pname)
            {
                if (p.ProcessName.Contains(gameName))
                {
                    found = true;
                    name = p.ProcessName;
                    gameName = name;
                    label3.Text = name;
                }
            }


            if (pname.Length == 0)
            {
                MessageBox.Show("L2 is not running!");
                return;
            }

            focusL2();
            sendInput(Keys.Enter);
            sendInput(Keys.T);
            sendInput(Keys.E);
            sendInput(Keys.S);
            sendInput(Keys.T);
            sendInput(Keys.Enter);
        }
    }
}
