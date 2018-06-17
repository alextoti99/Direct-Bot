using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputManager;

namespace Bot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public ListView getHistoryList() { return listView1; }

        private void Form2_Load(object sender, EventArgs e)
        {
            General.init();
            Clicker.init();
            ddoser.init();
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utils.exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General.getInstance.startL2(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General.getInstance.closeL2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General.getInstance.fastLogin(usernameTextBox.Text, passwordTextBox.Text);
        }

        void addToList(string key)
        {
            int times = 1;
            bool tempTimes = Int32.TryParse(textBox2.Text, out times);

            if (!tempTimes)
            {
                times = 1;
                Utils.log("Times text could not be recognised!, set default times = 1!");
            }

            Clicker.getInstance.addKey(key, checkBox1.Checked, times, checkBox3.Checked, checkBox2.Checked);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            addToList("Q");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            addToList("W");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addToList("E");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addToList("R");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addToList("T");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addToList("Y");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addToList("U");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addToList("I");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addToList("O");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addToList("P");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addToList("A");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addToList("S");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            addToList("D");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            addToList("F");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            addToList("G");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            addToList("H");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            addToList("J");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            addToList("K");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            addToList("L");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            addToList("Z");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            addToList("X");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            addToList("C");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            addToList("V");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            addToList("B");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            addToList("N");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            addToList("M");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            addToList("1");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            addToList("2");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            addToList("3");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            addToList("4");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            addToList("5");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            addToList("6");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            addToList("7");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            addToList("8");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            addToList("9");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            addToList("0");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            addToList("tab");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            addToList("esc");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            addToList("ctr");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            addToList("enter");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            addToList("home");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            addToList("F1");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            addToList("F2");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            addToList("F3");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            addToList("F4");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            addToList("F5");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            addToList("F6");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            addToList("F7");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            addToList("F8");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            addToList("F9");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            addToList("F10");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            addToList("F11");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            addToList("F12");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Clicker.getInstance.focusL2();
            Clicker.getInstance.runBot();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Clicker.getInstance.unfocusL2();
        }

        bool generalmsgstop = false;
        bool generalmsgunning = false;
        void stopGeneralMsg()
        {
            generalmsgstop = false;
            generalmsgunning = false;
        }
        void initGeneralMsg()
        {
            generalmsgstop = false;
            generalmsgunning = true;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (generalmsgunning)
                return;

            initGeneralMsg();
            int times, min, max;
            bool timeResult, minResult, maxResult;
            times = min = max = 1;
            int secToMin = 1000;

            timeResult = Int32.TryParse(timestxtsend.Text.Trim(), out times);
            minResult = Int32.TryParse(mindelaytxt.Text.Trim(), out min);
            maxResult = Int32.TryParse(maxdelaytxt.Text.Trim(), out max);

            if (!timeResult || !minResult || !maxResult)
            {
                Utils.log("Invalid times or min or max value!");
                stopGeneralMsg();
                return;
            }

            Random rnd = new Random();
            int delay = rnd.Next(min, max);

            new System.Threading.Thread(() =>
            {
                for (int i = 0; i < times; i++)
                {
                    if (generalmsgstop)
                    {
                        stopGeneralMsg();
                        return;
                    }

                    General.getInstance.sendMessage(textBox3.Text);

                    System.Threading.Thread.Sleep(secToMin * delay);
                }
            }).Start();
            stopGeneralMsg();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Clicker.getInstance.focusL2();
            VirtualKeyboard.KeyDown(Keys.F1);
            VirtualKeyboard.KeyUp(Keys.F1);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            addToList("space");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            if (textBotx.Text == " " || textBotx.Text == "" || textBotx.Text == null || textBoxy.Text == "" || textBoxy.Text == " " || textBoxy.Text == null)
                return;

            bool resultX = false;
            bool resultY = false;

            resultX = Int32.TryParse(textBotx.Text, out x);
            resultY = Int32.TryParse(textBoxy.Text, out y);

            if (resultX && resultY)
            {
                Clicker.getInstance.focusL2();
                Clicker.getInstance.moveMouse(x, y);
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Clicker.getInstance.focusL2();
            Clicker.getInstance.mouseInput(1, 1);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Clicker.getInstance.focusL2();
            Clicker.getInstance.mouseInput(3, 1);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Clicker.getInstance.focusL2();
            Clicker.getInstance.mouseInput(1, 1);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                Clicker.getInstance.focusL2();
                VirtualKeyboard.KeyDown(Keys.LShiftKey);
                VirtualKeyboard.KeyDown(Keys.OemQuotes);
                System.Threading.Thread.Sleep(1000);
                VirtualKeyboard.KeyUp(Keys.OemQuotes);
                VirtualKeyboard.KeyUp(Keys.LShiftKey);
            }).Start();
        }

        bool running = false;
        bool stop = false;
        void initPm()
        {
            running = true;
            stop = false;
        }
        void stopPm()
        {
            running = false;
            stop = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (running)
                return;

            initPm();
            running = true;
            bool first = true;
            string msg = textBox4.Text;
            msg = msg.Trim();
            string users = textBox5.Text;
            users = users.Trim();
            int msgLength = msg.Length;
            int usersLength = users.Length;
            bool send = false;
            int min, max;
            min = max = 1;
            bool resultMin, resultMax;

            resultMin = Int32.TryParse(textBox6.Text.Trim(), out min);
            resultMax = Int32.TryParse(textBox7.Text.Trim(), out max);

            string rndTxt = Utils.RandomString();

            if (!resultMax || !resultMin)
            {
                stopPm();
                Utils.log("Invalid min or max value!");
                return;
            }

            if (msgLength < 1 || usersLength < 1)
            {
                stopPm();
                Utils.log("Invalid message of users");
                return;
            }

            Clicker.getInstance.focusL2();
            Random rnd = new Random();

            new System.Threading.Thread(() =>
            {
                rndtxts.Text = rndTxt;
                General.getInstance.sendMessage("123");
                System.Threading.Thread.Sleep(1000 * 2);
                General.getInstance.sendMessage(rndTxt);
                string currentUser = "";
                string l = "";
                int currentUserLength = 0;
                int delay = rnd.Next(min, max);
                int prevUserLength = 0;

                for (int i = 0; i < usersLength; i++)
                {
                    if (stop)
                    {
                        stopPm();
                        return;
                    }

                    l = users[i].ToString();

                    if (l == "" || l == " " || l == null || l.Length <= 0)
                        continue;

                    if (l == "|")
                    {
                        l = "";
                        send = true;
                        if (currentUser == "stop")
                        {
                            stopPm();
                            return;
                        }
                    }

                    if (!send)
                    {
                        currentUser += l;
                        currentUserLength = currentUser.Length;
                        cuser.Text = currentUser;
                    }
                    else
                    {
                        if (currentUser == "" || currentUser == " " || currentUser == null || currentUser.Length <= 0)
                        {
                            continue;
                        }
                        _sendMsg(currentUser, msg, prevUserLength, first);
                        prevUserLength = currentUserLength;
                        System.Threading.Thread.Sleep(1000 * delay);
                        if (first)
                            first = false;
                        int randomSend = rnd.Next(1, 5);
                        send = false;
                        currentUser = "";
                    }
                }
            }).Start();
            stopPm();
        }

        void _sendMsg(string _user, string _msg, int length, bool first)
        {
            string user = _user.Trim();
            string msg = _msg.Trim();
            int userLength = user.Length;
            int msgLength = msg.Length;

            if (user == "" || user == " " || user == null || msg == "" || msg == " " || msg == null)
            {
                return;
            }

            Clicker.getInstance.sendInput(Keys.Enter);

            Clicker.getInstance.sendInput(Keys.OemQuotes, true);

            if (!first)
            {
                for (int i = 0; i < length; i++)
                    Clicker.getInstance.sendInput(Keys.Back);
            }

            //type name
            string l = "";

            for (int i = 0; i < userLength; i++)
            {
                l = user[i].ToString();

                if (l == "a") { Clicker.getInstance.sendInput(Keys.A); }
                else if (l == "s") { Clicker.getInstance.sendInput(Keys.S); }
                else if (l == "d") { Clicker.getInstance.sendInput(Keys.D); }
                else if (l == "f") { Clicker.getInstance.sendInput(Keys.F); }
                else if (l == "g") { Clicker.getInstance.sendInput(Keys.G); }
                else if (l == "h") { Clicker.getInstance.sendInput(Keys.H); }
                else if (l == "j") { Clicker.getInstance.sendInput(Keys.J); }
                else if (l == "k") { Clicker.getInstance.sendInput(Keys.K); }
                else if (l == "l") { Clicker.getInstance.sendInput(Keys.L); }
                else if (l == "q") { Clicker.getInstance.sendInput(Keys.Q); }
                else if (l == "w") { Clicker.getInstance.sendInput(Keys.W); }
                else if (l == "e") { Clicker.getInstance.sendInput(Keys.E); }
                else if (l == "r") { Clicker.getInstance.sendInput(Keys.R); }
                else if (l == "t") { Clicker.getInstance.sendInput(Keys.T); }
                else if (l == "y") { Clicker.getInstance.sendInput(Keys.Y); }
                else if (l == "u") { Clicker.getInstance.sendInput(Keys.U); }
                else if (l == "i") { Clicker.getInstance.sendInput(Keys.I); }
                else if (l == "o") { Clicker.getInstance.sendInput(Keys.O); }
                else if (l == "p") { Clicker.getInstance.sendInput(Keys.P); }
                else if (l == "z") { Clicker.getInstance.sendInput(Keys.Z); }
                else if (l == "x") { Clicker.getInstance.sendInput(Keys.X); }
                else if (l == "c") { Clicker.getInstance.sendInput(Keys.C); }
                else if (l == "v") { Clicker.getInstance.sendInput(Keys.V); }
                else if (l == "b") { Clicker.getInstance.sendInput(Keys.B); }
                else if (l == "n") { Clicker.getInstance.sendInput(Keys.N); }
                else if (l == "m") { Clicker.getInstance.sendInput(Keys.M); }
                else if (l == "A") { Clicker.getInstance.sendInput(Keys.A, false, true); }
                else if (l == "S") { Clicker.getInstance.sendInput(Keys.S, false, true); }
                else if (l == "D") { Clicker.getInstance.sendInput(Keys.D, false, true); }
                else if (l == "F") { Clicker.getInstance.sendInput(Keys.F, false, true); }
                else if (l == "G") { Clicker.getInstance.sendInput(Keys.G, false, true); }
                else if (l == "H") { Clicker.getInstance.sendInput(Keys.H, false, true); }
                else if (l == "J") { Clicker.getInstance.sendInput(Keys.J, false, true); }
                else if (l == "K") { Clicker.getInstance.sendInput(Keys.K, false, true); }
                else if (l == "L") { Clicker.getInstance.sendInput(Keys.L, false, true); }
                else if (l == "Q") { Clicker.getInstance.sendInput(Keys.Q, false, true); }
                else if (l == "W") { Clicker.getInstance.sendInput(Keys.W, false, true); }
                else if (l == "E") { Clicker.getInstance.sendInput(Keys.E, false, true); }
                else if (l == "R") { Clicker.getInstance.sendInput(Keys.R, false, true); }
                else if (l == "T") { Clicker.getInstance.sendInput(Keys.T, false, true); }
                else if (l == "Y") { Clicker.getInstance.sendInput(Keys.Y, false, true); }
                else if (l == "U") { Clicker.getInstance.sendInput(Keys.U, false, true); }
                else if (l == "I") { Clicker.getInstance.sendInput(Keys.I, false, true); }
                else if (l == "O") { Clicker.getInstance.sendInput(Keys.O, false, true); }
                else if (l == "P") { Clicker.getInstance.sendInput(Keys.P, false, true); }
                else if (l == "Z") { Clicker.getInstance.sendInput(Keys.Z, false, true); }
                else if (l == "X") { Clicker.getInstance.sendInput(Keys.X, false, true); }
                else if (l == "C") { Clicker.getInstance.sendInput(Keys.C, false, true); }
                else if (l == "V") { Clicker.getInstance.sendInput(Keys.V, false, true); }
                else if (l == "B") { Clicker.getInstance.sendInput(Keys.B, false, true); }
                else if (l == "N") { Clicker.getInstance.sendInput(Keys.N, false, true); }
                else if (l == "M") { Clicker.getInstance.sendInput(Keys.M, false, true); }
                else if (l == "1") { Clicker.getInstance.sendInput(Keys.D1); }
                else if (l == "2") { Clicker.getInstance.sendInput(Keys.D2); }
                else if (l == "3") { Clicker.getInstance.sendInput(Keys.D3); }
                else if (l == "4") { Clicker.getInstance.sendInput(Keys.D4); }
                else if (l == "5") { Clicker.getInstance.sendInput(Keys.D5); }
                else if (l == "6") { Clicker.getInstance.sendInput(Keys.D6); }
                else if (l == "7") { Clicker.getInstance.sendInput(Keys.D7); }
                else if (l == "8") { Clicker.getInstance.sendInput(Keys.D8); }
                else if (l == "9") { Clicker.getInstance.sendInput(Keys.D9); }
                else if (l == "0") { Clicker.getInstance.sendInput(Keys.D0); }
                else if (l == "!") { Clicker.getInstance.sendInput(Keys.D1, true, false); }
                else if (l == "@") { Clicker.getInstance.sendInput(Keys.D2, true, false); }
                else if (l == "#") { Clicker.getInstance.sendInput(Keys.D3, true, false); }
                else if (l == "$") { Clicker.getInstance.sendInput(Keys.D4, true, false); }
                else if (l == "%") { Clicker.getInstance.sendInput(Keys.D5, true, false); }
                else if (l == "^") { Clicker.getInstance.sendInput(Keys.D6, true, false); }
                else if (l == "&") { Clicker.getInstance.sendInput(Keys.D7, true, false); }
                else if (l == "*") { Clicker.getInstance.sendInput(Keys.D8, true, false); }
                else if (l == "(") { Clicker.getInstance.sendInput(Keys.D9, true, false); }
                else if (l == ")") { Clicker.getInstance.sendInput(Keys.D0, true, false); }
                else if (l == " ") { Clicker.getInstance.sendInput(Keys.Space); }
                else { Clicker.getInstance.sendInput(Keys.Space); }

            }

            l = "";

            Clicker.getInstance.sendInput(Keys.Space);

            //type msg
            for (int i = 0; i < msgLength; i++)
            {
                l = msg[i].ToString();

                if (l == "a") { Clicker.getInstance.sendInput(Keys.A); }
                else if (l == "s") { Clicker.getInstance.sendInput(Keys.S); }
                else if (l == "d") { Clicker.getInstance.sendInput(Keys.D); }
                else if (l == "f") { Clicker.getInstance.sendInput(Keys.F); }
                else if (l == "g") { Clicker.getInstance.sendInput(Keys.G); }
                else if (l == "h") { Clicker.getInstance.sendInput(Keys.H); }
                else if (l == "j") { Clicker.getInstance.sendInput(Keys.J); }
                else if (l == "k") { Clicker.getInstance.sendInput(Keys.K); }
                else if (l == "l") { Clicker.getInstance.sendInput(Keys.L); }
                else if (l == "q") { Clicker.getInstance.sendInput(Keys.Q); }
                else if (l == "w") { Clicker.getInstance.sendInput(Keys.W); }
                else if (l == "e") { Clicker.getInstance.sendInput(Keys.E); }
                else if (l == "r") { Clicker.getInstance.sendInput(Keys.R); }
                else if (l == "t") { Clicker.getInstance.sendInput(Keys.T); }
                else if (l == "y") { Clicker.getInstance.sendInput(Keys.Y); }
                else if (l == "u") { Clicker.getInstance.sendInput(Keys.U); }
                else if (l == "i") { Clicker.getInstance.sendInput(Keys.I); }
                else if (l == "o") { Clicker.getInstance.sendInput(Keys.O); }
                else if (l == "p") { Clicker.getInstance.sendInput(Keys.P); }
                else if (l == "z") { Clicker.getInstance.sendInput(Keys.Z); }
                else if (l == "x") { Clicker.getInstance.sendInput(Keys.X); }
                else if (l == "c") { Clicker.getInstance.sendInput(Keys.C); }
                else if (l == "v") { Clicker.getInstance.sendInput(Keys.V); }
                else if (l == "b") { Clicker.getInstance.sendInput(Keys.B); }
                else if (l == "n") { Clicker.getInstance.sendInput(Keys.N); }
                else if (l == "m") { Clicker.getInstance.sendInput(Keys.M); }
                else if (l == "A") { Clicker.getInstance.sendInput(Keys.A, false, true); }
                else if (l == "S") { Clicker.getInstance.sendInput(Keys.S, false, true); }
                else if (l == "D") { Clicker.getInstance.sendInput(Keys.D, false, true); }
                else if (l == "F") { Clicker.getInstance.sendInput(Keys.F, false, true); }
                else if (l == "G") { Clicker.getInstance.sendInput(Keys.G, false, true); }
                else if (l == "H") { Clicker.getInstance.sendInput(Keys.H, false, true); }
                else if (l == "J") { Clicker.getInstance.sendInput(Keys.J, false, true); }
                else if (l == "K") { Clicker.getInstance.sendInput(Keys.K, false, true); }
                else if (l == "L") { Clicker.getInstance.sendInput(Keys.L, false, true); }
                else if (l == "Q") { Clicker.getInstance.sendInput(Keys.Q, false, true); }
                else if (l == "W") { Clicker.getInstance.sendInput(Keys.W, false, true); }
                else if (l == "E") { Clicker.getInstance.sendInput(Keys.E, false, true); }
                else if (l == "R") { Clicker.getInstance.sendInput(Keys.R, false, true); }
                else if (l == "T") { Clicker.getInstance.sendInput(Keys.T, false, true); }
                else if (l == "Y") { Clicker.getInstance.sendInput(Keys.Y, false, true); }
                else if (l == "U") { Clicker.getInstance.sendInput(Keys.U, false, true); }
                else if (l == "I") { Clicker.getInstance.sendInput(Keys.I, false, true); }
                else if (l == "O") { Clicker.getInstance.sendInput(Keys.O, false, true); }
                else if (l == "P") { Clicker.getInstance.sendInput(Keys.P, false, true); }
                else if (l == "Z") { Clicker.getInstance.sendInput(Keys.Z, false, true); }
                else if (l == "X") { Clicker.getInstance.sendInput(Keys.X, false, true); }
                else if (l == "C") { Clicker.getInstance.sendInput(Keys.C, false, true); }
                else if (l == "V") { Clicker.getInstance.sendInput(Keys.V, false, true); }
                else if (l == "B") { Clicker.getInstance.sendInput(Keys.B, false, true); }
                else if (l == "N") { Clicker.getInstance.sendInput(Keys.N, false, true); }
                else if (l == "M") { Clicker.getInstance.sendInput(Keys.M, false, true); }
                else if (l == "1") { Clicker.getInstance.sendInput(Keys.D1); }
                else if (l == "2") { Clicker.getInstance.sendInput(Keys.D2); }
                else if (l == "3") { Clicker.getInstance.sendInput(Keys.D3); }
                else if (l == "4") { Clicker.getInstance.sendInput(Keys.D4); }
                else if (l == "5") { Clicker.getInstance.sendInput(Keys.D5); }
                else if (l == "6") { Clicker.getInstance.sendInput(Keys.D6); }
                else if (l == "7") { Clicker.getInstance.sendInput(Keys.D7); }
                else if (l == "8") { Clicker.getInstance.sendInput(Keys.D8); }
                else if (l == "9") { Clicker.getInstance.sendInput(Keys.D9); }
                else if (l == "0") { Clicker.getInstance.sendInput(Keys.D0); }
                else if (l == "!") { Clicker.getInstance.sendInput(Keys.D1, true, false); }
                else if (l == "@") { Clicker.getInstance.sendInput(Keys.D2, true, false); }
                else if (l == "#") { Clicker.getInstance.sendInput(Keys.D3, true, false); }
                else if (l == "$") { Clicker.getInstance.sendInput(Keys.D4, true, false); }
                else if (l == "%") { Clicker.getInstance.sendInput(Keys.D5, true, false); }
                else if (l == "^") { Clicker.getInstance.sendInput(Keys.D6, true, false); }
                else if (l == "&") { Clicker.getInstance.sendInput(Keys.D7, true, false); }
                else if (l == "*") { Clicker.getInstance.sendInput(Keys.D8, true, false); }
                else if (l == "(") { Clicker.getInstance.sendInput(Keys.D9, true, false); }
                else if (l == ")") { Clicker.getInstance.sendInput(Keys.D0, true, false); }
                else if (l == " ") { Clicker.getInstance.sendInput(Keys.Space); }
                else { Clicker.getInstance.sendInput(Keys.Space); }

            }

            Clicker.getInstance.sendInput(Keys.Enter);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Utils.exit();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Utils.exit();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            int timesToSend = 0;
            bool timesToSendParseResult = Int32.TryParse(timestxt.Text, out timesToSend);

            int serverPort = 0;
            bool portParseResult = Int32.TryParse(porttxt.Text, out serverPort);

            string serverIp = iptxt.Text;
            string msg = msgtxt.Text;

            if (timesToSendParseResult && portParseResult)
            {
                ddoser.getInstance.ddos(serverIp, serverPort, msg, timesToSend);
            }
            else
            {
                Utils.log("Invalied times to send or port value, must be a number!");
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            generalmsgstop = true;
        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
