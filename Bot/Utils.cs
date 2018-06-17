using System;
namespace Bot
{
    class Utils
    {
        public static void log(string text)
        {
            System.Windows.Forms.MessageBox.Show(text);
        }

        public static void exit()
        {
            Environment.Exit(0);
        }

        public static Utils getInstance;

        public static void init() { getInstance = new Utils(); }

        public Form2 mainForm;

        public bool isInLaptop = false;

        public string gameName = "l2";

        private static Random random = new Random();

        public static string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
    }
}
