using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5._5_ChkLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            int n = 1;
            int paddingX = 40;
            int paddingY = 40;
            int posX = 30;
            int posY = 30;

            this.AutoSize = true;

            do
            {
                CheckBox chkLotto = new CheckBox();
                chkLotto.Name = "chkLotto" + n;
                chkLotto.Location = new Point(posX, posY);
                chkLotto.Width = 40;

                chkLotto.Appearance = Appearance.Button;
                chkLotto.Text = n.ToString();
                chkLotto.TextAlign = ContentAlignment.MiddleCenter;

                if (n % 10 == 0)
                {
                    posY += paddingY;
                    posX = 0;
                }

                Controls.Add(chkLotto);

                posX += paddingX;
                ++n;

            } while (n < 50);
        }
    }
}
