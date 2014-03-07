using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_RadioBtn
{
    public partial class Form1 : Form
    {
        GroupBox grpPizzaSize;
        RadioButton radSmall;
        RadioButton radMedium;
        RadioButton radLarge;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            grpPizzaSize = new GroupBox();
            grpPizzaSize.Text = "Pizza Size";
            grpPizzaSize.Size = new Size(150, 120);
            grpPizzaSize.Location = new Point(20, 10);

            radSmall = new RadioButton();
            radSmall.Text = "Small";
            radSmall.Appearance = Appearance.Button;
            radSmall.TextAlign = ContentAlignment.MiddleCenter;
            radSmall.CheckAlign = ContentAlignment.MiddleCenter;
            radSmall.Location = new Point(20, 20);

            radMedium = new RadioButton();
            radMedium.Text = "Medium";
            radMedium.Appearance = Appearance.Button;
            radMedium.TextAlign = ContentAlignment.MiddleCenter;
            radMedium.CheckAlign = ContentAlignment.MiddleCenter;
            radMedium.Location = new Point(20, 50);

            radLarge = new RadioButton();
            radLarge.Text = "Large";
            radLarge.Appearance = Appearance.Button;
            radLarge.TextAlign = ContentAlignment.MiddleCenter;
            radLarge.CheckAlign = ContentAlignment.MiddleCenter;
            radLarge.Location = new Point(20, 80);

            grpPizzaSize.Controls.Add(radSmall);
            grpPizzaSize.Controls.Add(radMedium);
            grpPizzaSize.Controls.Add(radLarge);

            Controls.Add(grpPizzaSize);
        }
    }
}
