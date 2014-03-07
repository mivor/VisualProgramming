using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_GroupBox
{
    public partial class Form1 : Form
    {
        GroupBox grpHolder;

        public Form1()
        {
            InitializeComponent();
            InitMe();
        }

        private void InitMe()
        {
            grpHolder = new GroupBox();
            grpHolder.Left = 22;
            grpHolder.Top = 18;
            grpHolder.Width = 120;
            grpHolder.Height = 58;
            grpHolder.Text = "Cup Holder";

            //default is FALSE!!!
            //grpHolder.AutoSize = true;

            Button btnDone = new Button();
            btnDone.Left = 22;
            btnDone.Top = 24;
            grpHolder.Controls.Add(btnDone);

            Controls.Add(grpHolder);
        }
    }
}
