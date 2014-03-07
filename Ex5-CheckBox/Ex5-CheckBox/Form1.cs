using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5_CheckBox
{
    public partial class Form1 : Form
    {
        CheckBox chkValidate;

        public Form1()
        {
            InitializeComponent();
            InitComp();
        }

        private void InitComp()
        {
            chkValidate = new CheckBox();

            this.Load += Form1_Load;

            Controls.Add(chkValidate);
        }

        //chkValidate.Checked = ! chkValidate.Checked;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            chkValidate.Checked = true;
            chkValidate.ThreeState = true;
            chkValidate.Appearance = Appearance.Button;
        }
    }
}
