using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_MessageBox
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

        public static void SimpleBox()
        {
            MessageBox.Show("Welcome to the Wonderful World of Visual C#",
                            "Visual C# Tutorials",
                            MessageBoxButtons.OKCancel);
        }

        public static void AdvancedBox()
        {
            MessageBox.Show("Your order appears to be correct" +
                        "\nAre you ready to provide your credit card information?",
                        "Customer Order Processing",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
        }
    }
}
