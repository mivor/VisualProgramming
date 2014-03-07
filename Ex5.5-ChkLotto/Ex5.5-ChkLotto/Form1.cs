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
            //InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            int n = 1;
            int startX = 20;
            int paddingX = 40;
            int paddingY = 40;
            int posX = startX;
            int posY = 20;

            this.AutoSize = true;
            this.Text = "LOTTO";

            do
            {
                CheckBox chkLotto = new CheckBox();
                chkLotto.Name = "chkLotto" + n;
                chkLotto.Location = new Point(posX, posY);
                chkLotto.Size = new Size(30, 30);
                chkLotto.Margin = new Padding(0,0,startX,paddingY);

                chkLotto.Appearance = Appearance.Button;
                chkLotto.BackColor = Color.BlanchedAlmond;
                chkLotto.FlatStyle = FlatStyle.Flat;
                chkLotto.FlatAppearance.CheckedBackColor = Color.Yellow;
                chkLotto.FlatAppearance.MouseOverBackColor = Color.White;
                chkLotto.FlatAppearance.MouseDownBackColor = Color.White;
                chkLotto.FlatAppearance.BorderColor = Color.Black;

                chkLotto.Text = n.ToString();
                chkLotto.TextAlign = ContentAlignment.MiddleCenter;

                chkLotto.Click += chkLotto_Click;

                Controls.Add(chkLotto);

                if (n % 10 == 0)
                {
                    posY += paddingY;
                    posX = startX;
                }
                else posX += paddingX;
                
                ++n;

            } while (n < 50);

            posY += paddingY * 2;

            Button btnStart = new Button();
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(startX, posY);
            btnStart.Size = new Size(70, 40);
            btnStart.Margin = new Padding(0, 0, 0, paddingY);

            btnStart.Text = "Win!";
            btnStart.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(btnStart);

        }

        private void chkLotto_Click(object sender, EventArgs e)
        {
            CheckBox origin = sender as CheckBox;

            origin.Text = "C!";
        }
    }
}
