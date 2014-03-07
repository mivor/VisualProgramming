using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_ComboBox
{
    public partial class Form1 : Form
    {
        Label lblTitle;
        ComboBox cbxAcademicDisciplines;

        public Form1()
        {
            InitializeComponent();
            InitMe();
        }

        private void InitMe()
        {
            lblTitle = new Label();
            lblTitle.Text = "Academic Disciplines";
            lblTitle.Location = new Point(12, 12);
            lblTitle.AutoSize = true;
            Controls.Add(lblTitle);

            cbxAcademicDisciplines = new ComboBox();
            cbxAcademicDisciplines.Location = new Point(12, 32);
            cbxAcademicDisciplines.Items.Add("Natural Sciences");
            cbxAcademicDisciplines.Items.Add("Mathematics and Computer Sciences");
            cbxAcademicDisciplines.Items.Add("Social Sciences");
            cbxAcademicDisciplines.Items.Add("Humanities");
            cbxAcademicDisciplines.Items.Add("Professions and Applied Sciences");

            cbxAcademicDisciplines.DropDownStyle = ComboBoxStyle.DropDown;

            cbxAcademicDisciplines.Text = "Arts & Sciences";

            Controls.Add(cbxAcademicDisciplines);
        }
    }
}
