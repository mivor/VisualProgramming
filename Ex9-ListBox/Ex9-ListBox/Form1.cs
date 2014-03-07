using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9_ListBox
{
    public partial class Form1 : Form
    {
        ListBox lbxBook;
        Label lblTitle;

        public Form1()
        {
            InitializeComponent();
            InitMe();
        }

        private void InitMe()
        {
            lblTitle = new Label();
            lblTitle.Text = "Book Titles";
            lblTitle.Location = new Point(12, 12);

            lbxBook = new ListBox();
            lbxBook.Location = new Point(12, 36);
            lbxBook.Items.Add("College Algebra"); ;
            lbxBook.Items.Add("Finite Mathematics");
            lbxBook.Items.Add("Mathematical Structures");
            lbxBook.Items.Add("MCAD 70-316 Training Guide");
            lbxBook.Items.Add("C++ Builder 6 Developer's Guide");
            lbxBook.Items.Add("La Bible de Jerusalem");
            lbxBook.Items.Add("Patterns for a Purpose");
            lbxBook.HorizontalScrollbar = true;

            Controls.Add(lblTitle);
            Controls.Add(lbxBook);
        }
    }
}
