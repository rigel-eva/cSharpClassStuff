using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hello_Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static String generateRandomQuote()
        {
            var returner = "";//Alright that's interesting, C# has type inferance, neat!
            var rngesus = new System.Random((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);//Well this is kinda dumb... essentally we are using the current Epoch time as a Seed
            switch (rngesus.Next(3))
                {
                    case 0:
                        returner = "It's High Noon";
                        break;
                    case 1:
                        returner = "Heros never die";
                        break;
                    case 2:
                        returner = "I've got you in my sights";
                        break;
                }
            return returner;
        }
    }
}
