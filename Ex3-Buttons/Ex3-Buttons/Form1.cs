using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_Buttons
{
    public partial class Form1 : Form
    {
        Button btnResume;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btnResume = new Button();
            btnResume.Text = "Resume";
            btnResume.Location = new Point(32, 20);
            btnResume.Size = new System.Drawing.Size(120, 48);
            btnResume.TextAlign = ContentAlignment.BottomCenter;

            Controls.Add(btnResume);
        }
    }
}
