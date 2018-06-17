using System;
using System.Windows.Forms;
using InputManager;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Bot
{
    class Clicker
    {
        public static Clicker getInstance;

        public static void init()
        {
            getInstance = new Clicker();
        }


        List<Keys> keysLog = new List<Keys>();
        List<bool> usingShiftList = new List<bool>();
        List<string> uiKeys = new List<string>();
        List<int> times = new List<int>();
        List<bool> usingAltList = new List<bool>();
        List<bool> usingCtrlList = new List<bool>();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public void focusL2()
        {
            Process[] prs = Process.GetProcessesByName(Utils.getInstance.gameName);

            if (prs.Length > 0)
            {
                if (prs[0].MainWindowHandle != IntPtr.Zero)
                {
                    SetForegroundWindow(prs[0].MainWindowHandle);
                }
            }
        }

        public void unfocusL2()
        {
            emptyList();
            Process prs = Process.GetCurrentProcess();

            SetForegroundWindow(prs.MainWindowHandle);
        }

        public void emptyList()
        {
            keysLog.Clear();
            usingShiftList.Clear();
            uiKeys.Clear();
            times.Clear();
            usingAltList.Clear();
            usingCtrlList.Clear();
            clearHistoryList_UI();
        }

        void clearHistoryList_UI()
        {
            Utils.getInstance.mainForm.getHistoryList().Items.Clear();
            Utils.getInstance.mainForm.getHistoryList().Update();
            Utils.getInstance.mainForm.getHistoryList().Refresh();
        }

        public void addKeyToList(string keyName, Keys key, bool _usingShift, int _times, bool _alt, bool _ctrl)
        {
            uiKeys.Add(keyName);
            keysLog.Add(key);
            usingShiftList.Add(_usingShift);
            times.Add(_times);
            usingCtrlList.Add(_ctrl);
            usingAltList.Add(_alt);
        }

        public void runBot()
        {
            new Thread(() =>
           {
               if (keysLog.Count == usingShiftList.Count)
               {
                   focusL2();
                   updateUI();
                   for (int i = 0; i < keysLog.Count; i++)
                   {
                       if ((keysLog[i] != null) || (usingShiftList[i] != null))
                       {
                           for (int j = 1; j <= times[i]; j++)
                           {
                               sendInput(keysLog[i], usingShiftList[i], false, usingAltList[i], usingCtrlList[i]);
                           }
                       }
                   }
               }
               else
               {
                   Utils.log("Recreate the list, something wrong happened!");
               }

               emptyList();
           }).Start();
        }

        public void updateUI()
        {
            for (int i = 0; i < uiKeys.Count; i++)
            {
                if (uiKeys[i] != null)
                {
                    Utils.getInstance.mainForm.getHistoryList().View = View.Details;
                    Utils.getInstance.mainForm.getHistoryList().Columns.Add("History");
                    ListViewItem item = new ListViewItem();
                    item.Text = uiKeys[i];
                    Utils.getInstance.mainForm.getHistoryList().Items.Add(item);
                }
            }
        }

        public void sendInput(Keys key, bool shift = false, bool capsLock = false, bool alt = false, bool ctrl = false)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                if (!shift && !capsLock && !alt && !ctrl)
                {
                    Keyboard.KeyDown(key);
                    Thread.Sleep(1000); //wait for 1 second
                    Keyboard.KeyUp(key);
                } else if (capsLock && !shift && !alt && !ctrl)
                {
                    Keyboard.KeyDown(Keys.CapsLock);
                    Keyboard.KeyDown(key);
                    Thread.Sleep(1000); //wait for 1 second
                    Keyboard.KeyUp(key);
                    Keyboard.KeyUp(Keys.CapsLock);

                    Keyboard.KeyDown(Keys.CapsLock);
                    Thread.Sleep(1000);
                    Keyboard.KeyUp(Keys.CapsLock);

                } else if (!capsLock && shift && !alt && !ctrl)
                {
                    Keyboard.KeyDown(Keys.LShiftKey);
                    Keyboard.KeyDown(key);
                    Thread.Sleep(1000); //wait for 1 second
                    Keyboard.KeyUp(key);
                    Keyboard.KeyUp(Keys.LShiftKey);
                } else if (!capsLock && !shift && alt && !ctrl)
                {
                    Keyboard.KeyDown(Keys.Alt);
                    Keyboard.KeyDown(key);
                    Thread.Sleep(1000); //wait for 1 second
                    Keyboard.KeyUp(key);
                    Keyboard.KeyUp(Keys.Alt);
                } else if (!capsLock && !shift && !alt && ctrl)
                {
                    Keyboard.KeyDown(Keys.LControlKey);
                    Keyboard.KeyDown(key);
                    Thread.Sleep(1000); //wait for 1 second
                    Keyboard.KeyUp(key);
                    Keyboard.KeyUp(Keys.LControlKey);
                }
            }).Start();
        }

        public void moveMouse(int x, int y)
        {
            Mouse.Move(x, y);
        }

        public void mouseInput(int id, int delay)
        {
            if (id == 1)
            {
                Mouse.PressButton(Mouse.MouseKeys.Left, delay);
            }
            else if (id == 2)
            {
                Mouse.PressButton(Mouse.MouseKeys.Right, delay);
            }
            else if (id == 3)
            {
                Mouse.PressButton(Mouse.MouseKeys.Middle, delay);
            }
            else
            {
                Utils.log("Input id not found!");
            }
        }

        public void mouseScroll(bool up)
        {
            if (up)
            {
                Mouse.Scroll(Mouse.ScrollDirection.Up);
            }
            else
            {
                Mouse.Scroll(Mouse.ScrollDirection.Down);
            }
        }

        public void addKey(string keyName, bool _usingShift, int _times, bool _alt, bool _ctrl)
        {
            Keys key = Keys.A;

            if (keyName == "A")
            {
                key = Keys.A;
            }
            else if (keyName == "S")
            {
                key = Keys.S;
            }
            else if (keyName == "D")
            { key = Keys.D; }
            else if (keyName == "F")
            { key = Keys.F; }
            else if (keyName == "G")
            { key = Keys.G; }
            else if (keyName == "H")
            {
                key = Keys.H;
            }
            else if (keyName == "J")
            { key = Keys.J; }
            else if (keyName == "K")
            { key = Keys.K; }
            else if (keyName == "L")
            { key = Keys.L; }
            else if (keyName == "Q")
                key = Keys.Q;
            else if (keyName == "W")
                key = Keys.W;
            else if (keyName == "E")
                key = Keys.E;
            else if (keyName == "R")
                key = Keys.R;
            else if (keyName == "T")
                key = Keys.T;
            else if (keyName == "Y")
                key = Keys.Y;
            else if (keyName == "U")
                key = Keys.U;
            else if (keyName == "I")
                key = Keys.I;
            else if (keyName == "O")
                key = Keys.O;
            else if (keyName == "P")
                key = Keys.P;
            else if (keyName == "F1")
                key = Keys.F1;
            else if (keyName == "F2")
                key = Keys.F2;
            else if (keyName == "F3")
                key = Keys.F3;
            else if (keyName == "F4")
                key = Keys.F4;
            else if (keyName == "F5")
                key = Keys.F5;
            else if (keyName == "F6")
                key = Keys.F6;
            else if (keyName == "F7")
                key = Keys.F7;
            else if (keyName == "F8")
                key = Keys.F8;
            else if (keyName == "F9")
                key = Keys.F9;
            else if (keyName == "F10")
                key = Keys.F10;
            else if (keyName == "F11")
                key = Keys.F11;
            else if (keyName == "F12")
                key = Keys.F12;
            else if (keyName == "enter")
                key = Keys.Enter;
            else if (keyName == "0")
                key = Keys.D0;
            else if (keyName == "1")
                key = Keys.D1;
            else if (keyName == "2")
                key = Keys.D2;
            else if (keyName == "3")
                key = Keys.D3;
            else if (keyName == "4")
                key = Keys.D4;
            else if (keyName == "5")
                key = Keys.D5;
            else if (keyName == "6")
                key = Keys.D6;
            else if (keyName == "7")
                key = Keys.D7;
            else if (keyName == "8")
                key = Keys.D8;
            else if (keyName == "9")
                key = Keys.D9;
            else if (keyName == "ctr")
                key = Keys.Control;
            else if (keyName == "home")
                key = Keys.Home;
            else if (keyName == "esc")
                key = Keys.Escape;
            else if (keyName == "tab")
                key = Keys.Tab;
            else if (keyName == "space")
                key = Keys.Tab;

                addKeyToList(keyName, key, _usingShift, _times, _alt, _ctrl);
        }
    }
}
