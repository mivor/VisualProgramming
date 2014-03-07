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
        LottoNumbers numbers;

        public Form1()
        {
            //InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            this.AutoSize = true;
            this.Text = "LOTTO";

            Point numbersLocation = new Point(20, 20);
            numbers = new LottoNumbers(numbersLocation);

            numbers.CreateUI(this);

            Point btnLocation = new Point(numbers.Location.X, numbers.EndLocation.Y);

            Button btnStart = new Button();
            btnStart.Location = new Point(btnLocation.X, btnLocation.Y);
            btnStart.Size = new Size(70, 40);
            btnStart.Margin = new Padding(0, 0, 0, 40);

            btnStart.Text = "Win!";
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.TextAlign = ContentAlignment.MiddleCenter;
            btnStart.Click += btnStart_Click;

            Controls.Add(btnStart);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Point winnerLocation = new Point(numbers.EndLocation.X, numbers.EndLocation.Y);
            numbers.CreateWinnerUI(winnerLocation, this);
        }
    }
}
