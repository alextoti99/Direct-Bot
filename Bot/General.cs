using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bot
{
    class General
    {
        public static General getInstance;

        public static void init()
        {
            getInstance = new General();
        }

        public void startL2(string l2Path)
        {
            if (l2Path == null || l2Path == "" || l2Path == " ")
            {
                Utils.log("Game Path is empty!");
                l2Path = "";
                return;
            }

            if (!File.Exists(l2Path))
            {
                Utils.log("Game Path is wrong or Game Launcher not found!");
                l2Path = "";
                return;
            }

            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = @"" + l2Path;
            pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            pProcess.Start();
        }

        public void closeL2()
        {
            Process[] processes = Process.GetProcessesByName(Utils.getInstance.gameName);

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        public void fastLogin(string username, string password)
        {
            if (username == "" || username == " " || username == null || password == "" || password == " " || password == null)
            {
                Utils.log("Username or password is empty, please retry!");
                return;
            }

            int nameLength = username.Length;
            int passLength = password.Length;

            username = username.Trim();
            password = password.Trim();

            Clicker.getInstance.focusL2();
            string l = "";

            for (int i = 0; i < nameLength; i++)
            {
                l = username[i].ToString();

                if (l == "a") { Clicker.getInstance.sendInput(Keys.A, false, false); }
                else if (l == "s") { Clicker.getInstance.sendInput(Keys.S, false, false); }
                else if (l == "d") { Clicker.getInstance.sendInput(Keys.D, false, false); }
                else if (l == "f") { Clicker.getInstance.sendInput(Keys.F, false, false); }
                else if (l == "g") { Clicker.getInstance.sendInput(Keys.G, false, false); }
                else if (l == "h") { Clicker.getInstance.sendInput(Keys.H, false, false); }
                else if (l == "j") { Clicker.getInstance.sendInput(Keys.J, false, false); }
                else if (l == "k") { Clicker.getInstance.sendInput(Keys.K, false, false); }
                else if (l == "l") { Clicker.getInstance.sendInput(Keys.L, false, false); }
                else if (l == "q") { Clicker.getInstance.sendInput(Keys.Q, false, false); }
                else if (l == "w") { Clicker.getInstance.sendInput(Keys.W, false, false); }
                else if (l == "e") { Clicker.getInstance.sendInput(Keys.E, false, false); }
                else if (l == "r") { Clicker.getInstance.sendInput(Keys.R, false, false); }
                else if (l == "t") { Clicker.getInstance.sendInput(Keys.T, false, false); }
                else if (l == "y") { Clicker.getInstance.sendInput(Keys.Y, false, false); }
                else if (l == "u") { Clicker.getInstance.sendInput(Keys.U, false, false); }
                else if (l == "i") { Clicker.getInstance.sendInput(Keys.I, false, false); }
                else if (l == "o") { Clicker.getInstance.sendInput(Keys.O, false, false); }
                else if (l == "p") { Clicker.getInstance.sendInput(Keys.P, false, false); }
                else if (l == "z") { Clicker.getInstance.sendInput(Keys.Z, false, false); }
                else if (l == "x") { Clicker.getInstance.sendInput(Keys.X, false, false); }
                else if (l == "c") { Clicker.getInstance.sendInput(Keys.C, false, false); }
                else if (l == "v") { Clicker.getInstance.sendInput(Keys.V, false, false); }
                else if (l == "b") { Clicker.getInstance.sendInput(Keys.B, false, false); }
                else if (l == "n") { Clicker.getInstance.sendInput(Keys.N, false, false); }
                else if (l == "m") { Clicker.getInstance.sendInput(Keys.M, false, false); }
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
                else if (l == "1") { Clicker.getInstance.sendInput(Keys.D1, false, false); }
                else if (l == "2") { Clicker.getInstance.sendInput(Keys.D2, false, false); }
                else if (l == "3") { Clicker.getInstance.sendInput(Keys.D3, false, false); }
                else if (l == "4") { Clicker.getInstance.sendInput(Keys.D4, false, false); }
                else if (l == "5") { Clicker.getInstance.sendInput(Keys.D5, false, false); }
                else if (l == "6") { Clicker.getInstance.sendInput(Keys.D6, false, false); }
                else if (l == "7") { Clicker.getInstance.sendInput(Keys.D7, false, false); }
                else if (l == "8") { Clicker.getInstance.sendInput(Keys.D8, false, false); }
                else if (l == "9") { Clicker.getInstance.sendInput(Keys.D9, false, false); }
                else if (l == "0") { Clicker.getInstance.sendInput(Keys.D0, false, false); }
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
                else if (l == " ") { Clicker.getInstance.sendInput(Keys.Space, false, false); }
                else { Utils.log("Letter not found!"); }

            }

            l = "";

            Clicker.getInstance.sendInput(Keys.Tab);

            for (int i = 0; i < passLength; i++)
            {
                l = password[i].ToString();

                if (l == " " || l == null)
                    break;

                if (l == "a") { Clicker.getInstance.sendInput(Keys.A, false, false); }
                else if (l == "s") { Clicker.getInstance.sendInput(Keys.S, false, false); }
                else if (l == "d") { Clicker.getInstance.sendInput(Keys.D, false, false); }
                else if (l == "f") { Clicker.getInstance.sendInput(Keys.F, false, false); }
                else if (l == "g") { Clicker.getInstance.sendInput(Keys.G, false, false); }
                else if (l == "h") { Clicker.getInstance.sendInput(Keys.H, false, false); }
                else if (l == "j") { Clicker.getInstance.sendInput(Keys.J, false, false); }
                else if (l == "k") { Clicker.getInstance.sendInput(Keys.K, false, false); }
                else if (l == "l") { Clicker.getInstance.sendInput(Keys.L, false, false); }
                else if (l == "q") { Clicker.getInstance.sendInput(Keys.Q, false, false); }
                else if (l == "w") { Clicker.getInstance.sendInput(Keys.W, false, false); }
                else if (l == "e") { Clicker.getInstance.sendInput(Keys.E, false, false); }
                else if (l == "r") { Clicker.getInstance.sendInput(Keys.R, false, false); }
                else if (l == "t") { Clicker.getInstance.sendInput(Keys.T, false, false); }
                else if (l == "y") { Clicker.getInstance.sendInput(Keys.Y, false, false); }
                else if (l == "u") { Clicker.getInstance.sendInput(Keys.U, false, false); }
                else if (l == "i") { Clicker.getInstance.sendInput(Keys.I, false, false); }
                else if (l == "o") { Clicker.getInstance.sendInput(Keys.O, false, false); }
                else if (l == "p") { Clicker.getInstance.sendInput(Keys.P, false, false); }
                else if (l == "z") { Clicker.getInstance.sendInput(Keys.Z, false, false); }
                else if (l == "x") { Clicker.getInstance.sendInput(Keys.X, false, false); }
                else if (l == "c") { Clicker.getInstance.sendInput(Keys.C, false, false); }
                else if (l == "v") { Clicker.getInstance.sendInput(Keys.V, false, false); }
                else if (l == "b") { Clicker.getInstance.sendInput(Keys.B, false, false); }
                else if (l == "n") { Clicker.getInstance.sendInput(Keys.N, false, false); }
                else if (l == "m") { Clicker.getInstance.sendInput(Keys.M, false, false); }
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
                else if (l == "1") { Clicker.getInstance.sendInput(Keys.D1, false, false); }
                else if (l == "2") { Clicker.getInstance.sendInput(Keys.D2, false, false); }
                else if (l == "3") { Clicker.getInstance.sendInput(Keys.D3, false, false); }
                else if (l == "4") { Clicker.getInstance.sendInput(Keys.D4, false, false); }
                else if (l == "5") { Clicker.getInstance.sendInput(Keys.D5, false, false); }
                else if (l == "6") { Clicker.getInstance.sendInput(Keys.D6, false, false); }
                else if (l == "7") { Clicker.getInstance.sendInput(Keys.D7, false, false); }
                else if (l == "8") { Clicker.getInstance.sendInput(Keys.D8, false, false); }
                else if (l == "9") { Clicker.getInstance.sendInput(Keys.D9, false, false); }
                else if (l == "0") { Clicker.getInstance.sendInput(Keys.D0, false, false); }
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
                else { Utils.log("Letter not found!"); }
            }

            Clicker.getInstance.sendInput(Keys.Enter);
            Clicker.getInstance.sendInput(Keys.Enter);
        }

        public void sendMessage(string msg)
        {
            if (msg == null || msg == "" || msg == " ")
            {
                Utils.log("Empty message!");
                return;
            }

            Clicker.getInstance.focusL2();

            int c = msg.Length;
            string l = "";

            msg = msg.Trim();

            Clicker.getInstance.sendInput(Keys.Enter);

            for (int i = 0; i < c; i++)
            {
                l = msg[i].ToString();

                if (l == null)
                    break;

                if (l == "a") { Clicker.getInstance.sendInput(Keys.A, false, false); }
                else if (l == "s") { Clicker.getInstance.sendInput(Keys.S, false, false); }
                else if (l == "d") { Clicker.getInstance.sendInput(Keys.D, false, false); }
                else if (l == "f") { Clicker.getInstance.sendInput(Keys.F, false, false); }
                else if (l == "g") { Clicker.getInstance.sendInput(Keys.G, false, false); }
                else if (l == "h") { Clicker.getInstance.sendInput(Keys.H, false, false); }
                else if (l == "j") { Clicker.getInstance.sendInput(Keys.J, false, false); }
                else if (l == "k") { Clicker.getInstance.sendInput(Keys.K, false, false); }
                else if (l == "l") { Clicker.getInstance.sendInput(Keys.L, false, false); }
                else if (l == "q") { Clicker.getInstance.sendInput(Keys.Q, false, false); }
                else if (l == "w") { Clicker.getInstance.sendInput(Keys.W, false, false); }
                else if (l == "e") { Clicker.getInstance.sendInput(Keys.E, false, false); }
                else if (l == "r") { Clicker.getInstance.sendInput(Keys.R, false, false); }
                else if (l == "t") { Clicker.getInstance.sendInput(Keys.T, false, false); }
                else if (l == "y") { Clicker.getInstance.sendInput(Keys.Y, false, false); }
                else if (l == "u") { Clicker.getInstance.sendInput(Keys.U, false, false); }
                else if (l == "i") { Clicker.getInstance.sendInput(Keys.I, false, false); }
                else if (l == "o") { Clicker.getInstance.sendInput(Keys.O, false, false); }
                else if (l == "p") { Clicker.getInstance.sendInput(Keys.P, false, false); }
                else if (l == "z") { Clicker.getInstance.sendInput(Keys.Z, false, false); }
                else if (l == "x") { Clicker.getInstance.sendInput(Keys.X, false, false); }
                else if (l == "c") { Clicker.getInstance.sendInput(Keys.C, false, false); }
                else if (l == "v") { Clicker.getInstance.sendInput(Keys.V, false, false); }
                else if (l == "b") { Clicker.getInstance.sendInput(Keys.B, false, false); }
                else if (l == "n") { Clicker.getInstance.sendInput(Keys.N, false, false); }
                else if (l == "m") { Clicker.getInstance.sendInput(Keys.M, false, false); }
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
                else if (l == "1") { Clicker.getInstance.sendInput(Keys.D1, false, false); }
                else if (l == "2") { Clicker.getInstance.sendInput(Keys.D2, false, false); }
                else if (l == "3") { Clicker.getInstance.sendInput(Keys.D3, false, false); }
                else if (l == "4") { Clicker.getInstance.sendInput(Keys.D4, false, false); }
                else if (l == "5") { Clicker.getInstance.sendInput(Keys.D5, false, false); }
                else if (l == "6") { Clicker.getInstance.sendInput(Keys.D6, false, false); }
                else if (l == "7") { Clicker.getInstance.sendInput(Keys.D7, false, false); }
                else if (l == "8") { Clicker.getInstance.sendInput(Keys.D8, false, false); }
                else if (l == "9") { Clicker.getInstance.sendInput(Keys.D9, false, false); }
                else if (l == "0") { Clicker.getInstance.sendInput(Keys.D0, false, false); }
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
                else if (l == " ") { Clicker.getInstance.sendInput(Keys.Space, false, false); }
            }

            Clicker.getInstance.sendInput(Keys.Enter);
        }
    }

}
