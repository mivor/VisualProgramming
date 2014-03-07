using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Ex5._5_ChkLotto
{
    class LottoNumbers
    {
        public List<CheckBox> Selected;
        public Point EndLocation { get; private set; }
        public Point Location { get; private set; }
        private List<int> winners;

        public LottoNumbers(Point location)
        {
            Selected = new List<CheckBox>();
            this.Location = location;
        }

        public void CreateUI(Control parent)
        {
            Point pos = Location;
            Size size = new Size(35, 35);
            Size padding = new Size(50, 50);
            int n = 1;

            do
            {
                CheckBox chkLotto = new CheckBox();
                chkLotto.Name = "chkLotto" + n;
                chkLotto.Location = pos;
                chkLotto.Margin = new Padding(0, 0, Location.X, padding.Height);
                chkLotto.Size = size;
                chkLotto.Text = n.ToString();
                chkLotto.Click += chkLotto_Click;

                styleNumber(ref chkLotto);

                parent.Controls.Add(chkLotto);

                if (n % 10 == 0)
                {
                    pos.Y += padding.Height;
                    pos.X = Location.X;
                }
                else pos.X += padding.Width;

                ++n;

            } while (n < 50);

            EndLocation = new Point(pos.X + padding.Width, pos.Y + padding.Height);
        }

        public void CreateSelectedUI(Point location, Control parent)
        {

        }

        public void CreateWinnerUI(Point location, Control parent)
        {
            GenerateWinners();

            for (int i = 0; i < winners.Count; i++)
            {
                Label lblWinner = new Label();
                lblWinner.Location = new Point(location.X - (i+1) * 50, location.Y);
                lblWinner.Size = new Size(40, 40);
                lblWinner.BackColor = Color.GreenYellow;

                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, lblWinner.Width, lblWinner.Height);
                lblWinner.Region = new Region(gp);
                //lblWinner.Invalidate();

                lblWinner.Text = winners[i].ToString();
                lblWinner.TextAlign = ContentAlignment.MiddleCenter;

                parent.Controls.Add(lblWinner);
            }

            highlightWinners();
        }

        private void highlightWinners()
        {
            foreach (CheckBox cb in Selected)
	        {
                if (winners.Contains(int.Parse(cb.Text)))
                    cb.FlatAppearance.CheckedBackColor = Style.win;
                else 
                    cb.FlatAppearance.CheckedBackColor = Style.lose;
	        }
        }

        private void GenerateWinners()
        {
            Random rnd = new Random();
            winners = new List<int>();

            for (int i = winners.Count; i < 6; i++)
            {
                int num = rnd.Next(1, 50);
                while (winners.Contains(num))
                {
                    num = rnd.Next(1, 50);
                }
                winners.Add(num);
            }

            winners.Sort((x, y) => -1 * x.CompareTo(y));
        }

        private void styleNumber(ref CheckBox number)
        {
            number.BackColor = Style.background;
            number.TextAlign = ContentAlignment.MiddleCenter;

            number.Appearance = Appearance.Button;
            number.FlatStyle = FlatStyle.Flat;
            number.FlatAppearance.CheckedBackColor = Style.active;
            number.FlatAppearance.MouseOverBackColor = Style.hover;
            number.FlatAppearance.MouseDownBackColor = Style.hover;
            number.FlatAppearance.BorderColor = Style.border;
        }

        private void chkLotto_Click(object sender, EventArgs e)
        {
            CheckBox s = sender as CheckBox;
    
            if (s.Checked)
            {
                if (Selected.Count < 6)
                {
                    s.Font = new Font(s.Font, FontStyle.Bold);
                    Selected.Add(s);
                }
                else
                    s.Checked = !s.Checked;
            }
            else
            { 
                s.Font = new Font(s.Font, FontStyle.Regular);
                Selected.Remove(s);
            }
        }
    }
}
