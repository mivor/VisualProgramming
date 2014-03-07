1. Label

public class Exercise : System.Windows.Forms.Form
{
    Label lblMessage;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        lblMessage = new Label();
        lblMessage.Text = DateTime.Now.ToString();
        lblMessage.AutoSize = true;
        Controls.Add(lblMessage);
    }
}

2. Link Label

private void linkLabel1_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
{
        System.Diagnostics.Process.Start(
    		@"C:\Program Files\Internet Explorer\iexplore.exe",
        		"http://www.functionx.com/vccli");
}

3. Buttons

public class Exercise : System.Windows.Forms.Form
{
    Button btnResume;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        btnResume = new Button();
        btnResume.Text = "Resume";
        btnResume.Location = new Point(32, 20);
        btnResume.Size = new System.Drawing.Size(120, 48);
        btnResume.TextAlign = ContentAlignment.BottomCenter;

        Controls.Add(btnResume);
    }
}


The Flat Style of a Button

Flat: The button appears flat. When the mouse is over it, it becomes highlighted
Popup: The button appears flat. When the mouse is over it, the borders of the button are raised
Standard: The button appears and behave like all regular buttons you have seen
System: The appearance of the button depends on the operating system

4. Messege Box

MessageBox.Show("Welcome to the World of Visual C#","Visual C# Tutorials");

Buttons of a Message Box:
MessageBoxButtons 	 
OK	
OKCancel	  
YesNo	    
YesNoCancel	    
RetryCancel	  
AbortRetryIgnore	 
   
public class Exercise
{
    static int Main()
    {
        MessageBox.Show("Welcome to the Wonderful World of Visual C#",
                            "Visual C# Tutorials",
                            MessageBoxButtons.OKCancel);
        return 0;
    }
}

public class Exercise
{
    static int Main()
    {
	MessageBox.Show("Your order appears to be correct" +
                        "\nAre you ready to provide your credit card information?",
		        "Customer Order Processing",
                        MessageBoxButtons.YesNoCancel,
			MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
        return 0;
    }
}

5. Text box

public void Paste();
public void Select(int start, int length);
public void SelectAll();
public void Copy();
public void Cut();
public void Clear();
public void Undo();
public void ClearUndo();


6. Check Buttons

CheckBox chkValidate;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        chkValidate = new CheckBox();

        Controls.Add(chkValidate);
    }
	
checkBox1.Checked = true;
checkBox1.Checked = ! checkBox1.Checked; //change checked status :)

private void Form1_Load(object sender, System.EventArgs e)
{
	checkBox1.Checked = true;
	checkBox1.ThreeState = true;
	checkBox1.Appearance = Appearance.Button;
}

7. Radio Buttons

private void InitializeComponent()
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

8. Group Box

private void InitializeComponent()
{
        grpHolder = new GroupBox();
        grpHolder.Left   = 22;
        grpHolder.Top    = 18;
        grpHolder.Width  = 120;
        grpHolder.Height = 58;
        grpHolder.Text = "Cup Holder";

        Button btnDone = new Button();
        btnDone.Left = 22;
        btnDone.Top  = 24;
        grpHolder.Controls.Add(btnDone);

        Controls.Add(grpHolder);
}
The default value of the GroupBox.AutoSize property is false. If you set it to true,
 the group box would resize itself and all of its controls should appear

9. Combo Boxes

Label lblTitle;
ComboBox cbxAcademicDisciplines;

public Exercise()
    {
        InitializeComponent();
    }
private void InitializeComponent()
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

10. List Boxes

public class Exercise : System.Windows.Forms.Form
{
    ListBox lbxBook;
    Label lblTitle;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblTitle.Text = "Book Titles";
        lblTitle.Location = new Point(12, 12);

        lbxBook = new ListBox();
        lbxBook.Location = new Point(12, 36);
        lbxBook.Items.Add("College Algebra");;
        lbxBook.Items.Add("Finite Mathematics");
        lbxBook.Items.Add("Mathematical Structures");
        lbxBook.Items.Add("MCAD 70-316 Training Guide");
        lbxBook.Items.Add("C++ Builder 6 Developer's Guide");
        lbxBook.Items.Add("La Bible de JÃ©rusalem");
        lbxBook.Items.Add("Patterns for a Purpose");
        lbxBook.HorizontalScrollbar = true;

        Controls.Add(lblTitle);
        Controls.Add(lbxBook);
    }
}

an example of two list boxes that allows a user to drag an item from
the source list box and drop it on the target list box:

using System;
using System.Drawing;
using System.Windows.Forms;

public class Exercise : System.Windows.Forms.Form
{
    ListBox lbxSource;
    ListBox lbxTarget;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        lbxSource = new ListBox();
        lbxSource.Location = new Point(12, 12);
        lbxSource.Size = new System.Drawing.Size(100, 100);
        lbxSource.MouseDown += new MouseEventHandler(lbxSourceMouseDown);

        lbxTarget = new ListBox();
        lbxTarget.AllowDrop = true;
        lbxTarget.Location = new Point(120, 12);
        lbxTarget.Size = new System.Drawing.Size(100, 100);
        lbxTarget.DragEnter += new DragEventHandler(lbxTargetDragEnter);
        lbxTarget.DragDrop += new DragEventHandler(lbxTargetDragDrop);

        Text = "Employees Names";
        Controls.Add(lbxSource);
        Controls.Add(lbxTarget);

        lbxSource.Items.Add("James");
        lbxSource.Items.Add("Gertrude");
        lbxSource.Items.Add("Paul");
        lbxSource.Items.Add("Hélène");
    }

    private void lbxSourceMouseDown(object sender, MouseEventArgs e)
    {
        // Find out if the user had clicked (with the left mouse button.
        // If so, prepare to copy the item the user had clicked
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
            lbxSource.DoDragDrop(lbxSource.SelectedItem.ToString(), DragDropEffects.Copy);
    }

    private void lbxTargetDragEnter(object sender, DragEventArgs e)
    {
        // When the user gets to the target list box, specify that you want to copy
        e.Effect = DragDropEffects.Copy;
    }

    private void lbxTargetDragDrop(object sender, DragEventArgs e)
    {
        // Before dropping, get the string that the user is dragging
        string strSelected = e.Data.GetData(DataFormats.Text).ToString();

        // Once you know what string the user is dragging,
        // add it to the target list box
        if (!strSelected.Equals(""))
            ((ListBox)sender).Items.Add(strSelected);
    }
}

public class Program
{
    [STAThread]
    public static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}

11. An Image List

lstImages = new ImageList();
lstImages.ImageSize = new Size(256, 256);

Image img1 = Image.FromFile(@"E:\Programs\image1.jpg");
lstImages.Images.Add(img1);
Image img2 = Image.FromFile(@"E:\Programs\Image2.jpg");
lstImages.Images.Add(img2);

Image[] images =
        {
            Image.FromFile(@"E:\Programs\image3.jpg"),
            Image.FromFile(@"E:\Programs\Image4.jpg"),
            Image.FromFile(@"E:\Programs\Image5.jpg")
        };

lstImages.Images.AddRange(images);

Under the form, double-click timer1 and change the file as follows:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageViewer1
{
    public partial class Form1 : Form
    {
        static int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < 6)
            {
                lstPictures.Draw(pbxViewer.CreateGraphics(),
                                           pbxViewer.Left,
                          	           pbxViewer.Top,
                          	           index);
                index++;
            }
            else
                index = 0;
        }
    }
}

12. Picure boxes

public class Exercise : Form
{
    private PictureBox pctBox;

    public Exercise()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        pctBox = new PictureBox();
        pctBox.Location = new Point(10, 10);
        pctBox.Size = new Size(200, 150);
        pctBox.Load(@"E:\Programs\person.bmp");
        Controls.Add(pctBox);
    }
}

SizeMode property of the PictureBox:

Normal
CenterImage 
Zoom
AutoSize

13. Panel

using System;
using System.Drawing;
using System.Windows.Forms;

public class Exercise : System.Windows.Forms.Form
{
    Panel pnlContainer;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Text     = "Domain Configuration";
        Width    = 320;
        Height   = 210;
        Location = System.Drawing.Point(140, 100);
        StartPosition = FormStartPosition.CenterScreen;

        pnlContainer = new Panel();
        pnlContainer.Location = new Point(20, 20);
        pnlContainer.Size = System.Drawing.Size(100, 60);
		pnlContainer.BorderStyle = BorderStyle.Fixed3D;
        Controls.Add(pnlContainer);
    }
}

public class Program
{
    static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}
		
14. Timer

using System;
using System.Drawing;
using System.Windows.Forms;

public class Exercise : Form
{
    Timer tmrFlash;
    Label lblFlash;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        tmrFlash = new  Timer();
        tmrFlash.Interval = 500;
        tmrFlash.Enabled = true;
        tmrFlash.Tick += new EventHandler(btnFlashTick);

        lblFlash = new Label();
        lblFlash.AutoSize = true;
        lblFlash.Text = "C# Programming is Fun!!!";
        lblFlash.Font = new System.Drawing.Font("Square721 BT", 24F);
        lblFlash.ForeColor = System.Drawing.Color.Blue;
        lblFlash.Location = new System.Drawing.Point(12, 10);

        Text = "Text Flasher";
        Size = new System.Drawing.Size(435, 88);
        Controls.Add(lblFlash);
    }

    void btnFlashTick(object sender, EventArgs e)
    {
        if (lblFlash.Text == "C# Programming is Fun!!!")
            lblFlash.Text = "";
        else
            lblFlash.Text = "C# Programming is Fun!!!";
    }
}

public class Program
{
    static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}

The Main menu

public class Exercise : System.Windows.Forms.Form
{
    MenuStrip mnuMain;
    
    ToolStripMenuItem mnuFile;
    ToolStripMenuItem mnuNew;
    ToolStripMenuItem mnuOpen;
    ToolStripMenuItem mnuExit;
    ToolStripMenuItem mnuEdit;
    ToolStripMenuItem mnuCopy;
    ToolStripMenuItem mnuPaste;

    ToolStripMenuItem mnuView;

    ToolStripMenuItem mnuHelp;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        mnuMain = new MenuStrip();

        mnuFile = new ToolStripMenuItem("File");
        mnuNew = new ToolStripMenuItem("New");
        mnuOpen = new ToolStripMenuItem("Open");
        mnuExit = new ToolStripMenuItem("Exit");
        ToolStripMenuItem[] mnuFileItems = { mnuNew, mnuOpen, mnuExit };
        mnuFile.DropDownItems.AddRange(mnuFileItems);

        mnuEdit = new ToolStripMenuItem("Edit");
        mnuCopy = new ToolStripMenuItem("Copy");
        mnuEdit.DropDownItems.Add(mnuCopy);
        mnuPaste = (ToolStripMenuItem)mnuEdit.DropDownItems.Add("Paste");

        mnuView = new ToolStripMenuItem("View");
        ToolStripMenuItem[] mnuViewItems =
        {
	    new ToolStripMenuItem("Standard Toolbar"),
	    new ToolStripMenuItem("Formatting Toolbar"),
	    new ToolStripMenuItem("Status Bar")
        };
        mnuView.DropDownItems.AddRange(mnuViewItems);

        mnuHelp = new ToolStripMenuItem("Help");
        ToolStripMenuItem[] mnuHelpItems =
        { 
            new ToolStripMenuItem("Search"),
            new ToolStripMenuItem("Contents"),
            new ToolStripMenuItem("Index"),
            new ToolStripMenuItem("Support Web Site"),
            new ToolStripMenuItem("About this application")
        };
        mnuHelp.DropDownItems.AddRange(mnuHelpItems);

        ToolStripMenuItem[] mnuAccessories = { mnuView, mnuHelp };

        mnuMain.Items.Add(mnuFile);
        mnuMain.Items.AddRange(mnuAccessories);

        Controls.Add(mnuMain);
    }
}

Contextual Menu

void InitializeComponent()
{
        System.Windows.Forms.ContextMenuStrip context =
		new System.Windows.Forms.ContextMenuStrip();

        ToolStripMenuItem mnuCut = new ToolStripMenuItem("Cut");
        ToolStripMenuItem[] mnuEdit =
        {
		new ToolStripMenuItem("Copy"),
	        new ToolStripMenuItem("Paste")
        };

        context.Items.Add(mnuCut);
        context.Items.AddRange(mnuEdit);

        ContextMenuStrip = context;
}

Open File Dialog Box

using System;
using System.Drawing;
using System.Windows.Forms;

public class Exercise : Form
{
    Button btnOpen;
    private OpenFileDialog ofd;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        ofd = new  OpenFileDialog ();
        ofd.Filter = "HTML Files (*.htm)|*.htm|" +
                                      "Active Server Pages (*.asp)|*.asp|" +
                                      "Apache Files (*.php)|*.php|" +
                                      "Perl Script (*.pl)|*.pl|" +
                                      "All Files|";
        btnOpen = new Button();
        btnOpen.Text = "Open";
        btnOpen.Location = new Point(12, 12);
        btnOpen.Click += new EventHandler(btnWriteClick);

        Controls.Add(btnOpen);
    }

    void btnWriteClick(object sender, EventArgs e)
    {
        ofd.ShowDialog();
    }

    [STAThread]
    public static int Main()
    {
        Application.Run(new Exercise());

        return 0;
    }
}

void InitializeComponent()
{
        ofd = new  OpenFileDialog ();
        ofd.Filter = "HTML Files (*.htm)|*.htm|" +
                                      "Active Server Pages (*.asp)|*.asp|" +
                                      "Apache Files (*.php)|*.php|" +
                                      "Perl Script (*.pl)|*.pl|" +
                                      "All Files|";
        ofd.ShowReadOnly = true;
        ofd.ReadOnlyChecked = true;
}


Tab Controls

public class Exercise : System.Windows.Forms.Form
{
    TabPage pgeController;
    TabPage pgeAccount;
    TabControl tclPropertySheet;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Text = "Domain Configuration";
        Size = new Size(345, 228);
        StartPosition = FormStartPosition.CenterScreen;

        tclPropertySheet = new TabControl();
        tclPropertySheet.Location = new Point(14, 16);
        tclPropertySheet.Size = new Size(310, 170);
        tclPropertySheet.HotTrack = true;
        tclPropertySheet.Alignment = TabAlignment.Left;

        pgeController = new TabPage();
        pgeController.Text = "Controller";
        tclPropertySheet.Controls.Add(pgeController);

        pgeAccount = new TabPage();
        pgeAccount.Text = "Account";
        tclPropertySheet.TabPages.Add(pgeAccount);

        Controls.Add(tclPropertySheet);
    }
}

public class Exercise : System.Windows.Forms.Form
{
    TabPage pgeController;
    TabPage pgeAccount;
    TabPage pgeSummary;
    TabControl tclPropertySheet;

    public Exercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Text = "Domain Configuration";
        Size = new Size(345, 228);
        StartPosition = FormStartPosition.CenterScreen;

        tclPropertySheet = new TabControl();
        tclPropertySheet.Location = new Point(14, 16);
        tclPropertySheet.Size = new Size(310, 170);
        tclPropertySheet.HotTrack = true;
        tclPropertySheet.Appearance = TabAppearance.FlatButtons;

        pgeController = new TabPage();
        pgeController.Text = "Controller";
        tclPropertySheet.Controls.Add(pgeController);

        pgeAccount = new TabPage();
        pgeAccount.Text = "Account";
        tclPropertySheet.TabPages.Add(pgeAccount);

        pgeSummary = new TabPage();
        pgeSummary.Text = "Summary";
        tclPropertySheet.TabPages.Add(pgeSummary);

        Controls.Add(tclPropertySheet);
    }
}

 Data View
 
 public partial class Exercise : Form
{
    DataView dvwStudents;

    public Exercise()
    {
        InitializeComponent();
    }

    private void Exercise_Load(object sender, EventArgs e)
    {
        // Using the table's index in the data set
        dvwStudents = new DataView(dsStudents.Tables[0]);
        // Using the table object name
        dvwStudents = new DataView(dsStudents.Tables["Student"]);
        // Using the table variable name
        dvwStudents = new DataView(tblStudent);
    }
}

private void rdoStudentNumber_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "StudentNumber";
}

private void rdoFirstName_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "FirstName";
}

private void rdoLastName_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "LastName";
}

private void rdoDateofBirth_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "DateOfBirth";
}

private void rdoGender_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "Gender";
}

private void rdoStudentNumber_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "StudentNumber ASC";
}

private void rdoStudentNumber_CheckedChanged(object sender, EventArgs e)
{
    dvwStudents.Sort = "StudentNumber DESC";
}

private void btnFilter_Click(object sender, EventArgs e)
{
    dvwStudents.RowFilter = "LastName = 'Simms'";
}

private void btnCreateTable_Click(object sender, EventArgs e)
{
    DataTable tblSimms = new DataTable();

    dvwStudents.RowFilter = "LastName = 'Simms'";
    tblSimms = dvwStudents.ToTable("StudentsNamedSimms");

    dgvStudents.DataSource = tblSimms;
}
 
 private void btnCreateTable_Click(object sender, EventArgs e)
{
            DataTable tblTempTable = new DataTable();

            dvwStudents.RowFilter = "LastName = 'Thomas'";
            tblTempTable = dvwStudents.ToTable();

            DataRow Record = null;
            
            Record = tblTempTable.NewRow();
            Record[0] = "959402";
            Record[1] = "Helene";
            Record[2] = "Mukoko";
            Record[3] = "04/08/1996";
            Record[4] = "Female";
            tblTempTable.Rows.Add(Record);

            Record = tblTempTable.NewRow();
            Record[0] = "297462";
            Record[1] = "Camille";
            Record[2] = "Solis";
            Record[3] = "07/12/2000";
            Record[4] = "Unknown";
            tblTempTable.Rows.Add(Record);

            Record = tblTempTable.NewRow();
            Record[0] = "294729";
            Record[1] = "Florence";
            Record[2] = "Jansen";
            Record[3] = "11/10/1994";
            Record[4] = "Female";
            tblTempTable.Rows.Add(Record);

            Record = tblTempTable.NewRow();
            Record[0] = "826358";
            Record[1] = "Carl";
            Record[2] = "Tonie";
            Record[3] = "06/10/1998";
            Record[4] = "Male";
            tblTempTable.Rows.Add(Record);

            dgvStudents.DataSource = tblTempTable;
}

Data Grid View

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

public class Exercise : Form
{
    DataGridView dgvStudents;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Text = "Students Records";

        dgvStudents = new DataGridView();
        dgvStudents.Location = new Point(12, 12);
        Controls.Add(dgvStudents);
    }
}

public class Program
{
    static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(645, 100);

            DataGridViewTextBoxColumn colFullName = new DataGridViewTextBoxColumn();
            dgvStudents.Columns.Add(colFullName);

            DataGridViewComboBoxColumn colGender = new DataGridViewComboBoxColumn();
            dgvStudents.Columns.Add(colGender);

            DataGridViewCheckBoxColumn colShowResume = new DataGridViewCheckBoxColumn();
            dgvStudents.Columns.Add(colShowResume);

            DataGridViewButtonColumn colShowPicture = new DataGridViewButtonColumn();
            dgvStudents.Columns.Add(colShowPicture);

            DataGridViewLinkColumn colEmailAddress = new DataGridViewLinkColumn();
            dgvStudents.Columns.Add(colEmailAddress);

            DataGridViewImageColumn colPicture = new DataGridViewImageColumn();
            dgvStudents.Columns.Add(colPicture);
                 
            Controls.Add(dgvStudents);
}

private void Exercise_Load(object sender, EventArgs e)
{
    dgvStudents = new DataGridView();
    dgvStudents.Location = new Point(10, 10);
    dgvStudents.Size = new Size(150, 100);

    DataGridViewColumn colFullName = new DataGridViewColumn();
    colFullName.Name = "FullName";
    colFullName.HeaderText = "Full Name";

    DataGridViewCell celFullName = new DataGridViewTextBoxCell();
    colFullName.CellTemplate = celFullName;
    dgvStudents.Columns.Add(colFullName);

    Controls.Add(dgvStudents);
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(350, 100);

            dgvStudents.Columns.Add("FirsName", "First Name");
            dgvStudents.Columns.Add("LasName", "Last Name");
            dgvStudents.Columns.Add("Gender", "Gender");

            Controls.Add(dgvStudents);
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(350, 100);

            dgvStudents.Columns.Add("FirsName", "First Name");
            dgvStudents.Columns.Add("LasName", "Last Name");
            dgvStudents.Columns.Add("Gender", "Gender");

            Controls.Add(dgvStudents);

            // First Record
            dgvStudents.Rows[0] . . .
            // Second Record
            dgvStudents.Rows[1] . . .
            // Intersection of: First Record - First Column
            dgvStudents.Rows[0].Cells[0] . . .
            // Intersection of: First Record - Second Column
            dgvStudents.Rows[0].Cells[1] . . .
            // Intersection of: Second Record - First Column
            dgvStudents.Rows[1].Cells[0] . . .
            // Intersection of: Second Record - Second Column
            dgvStudents.Rows[1].Cells[1] . . .
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(350, 100);

            dgvStudents.Columns.Add("FirsName", "First Name");
            dgvStudents.Columns.Add("LasName", "Last Name");
            dgvStudents.Columns.Add("Gender", "Gender");

            Controls.Add(dgvStudents);

            dgvStudents.Rows[0].Cells[0]
            dgvStudents.Rows[0].Cells[1]

            dgvStudents.Rows[0].Cells["Gender"] . . .
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(320, 80);

            DataGridViewTextBoxColumn colFirstName = 
            		new DataGridViewTextBoxColumn();
            colFirstName.Name = "FirstName";
            colFirstName.HeaderText = "First Name";
            dgvStudents.Columns.Add(colFirstName);

            DataGridViewTextBoxColumn colLastName = 
            		new DataGridViewTextBoxColumn();
            colLastName.Name = "LastName";
            colLastName.HeaderText = "Last Name";
            dgvStudents.Columns.Add(colLastName);

            DataGridViewCheckBoxColumn colFullTime = 
            		new DataGridViewCheckBoxColumn();
            colFullTime.Name = "FullTime";
            colFullTime.HeaderText = "Full Time?";
            colFullTime.Width = 70;
            dgvStudents.Columns.Add(colFullTime);

            Controls.Add(dgvStudents);

            dgvStudents.Rows[0].Cells[0].Value = "Ernestine";
            dgvStudents.Rows[0].Cells[1].Value = "Cavier";
            dgvStudents.Rows[0].Cells[2].Value = true;
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(350, 200);

            dgvStudents.Columns.Add("FirstName", "First Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("Gender", "Gender");

            Controls.Add(dgvStudents);

            dgvStudents.Rows.Add(4);

            dgvStudents.Rows[0].Cells[0].Value = "Joyce";
            dgvStudents.Rows[0].Cells[1].Value = "Simms";
            dgvStudents.Rows[0].Cells["Gender"].Value = "Female";

            dgvStudents.Rows[1].Cells["FirstName"].Value = "Peter";
            dgvStudents.Rows[1].Cells[1].Value = "Mukoko";
            dgvStudents.Rows[1].Cells[2].Value = "Male";
}

private void Exercise_Load(object sender, EventArgs e)
{
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 10);
            dgvStudents.Size = new Size(350, 200);

            dgvStudents.Columns.Add("FirstName", "First Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("Gender", "Gender");

            Controls.Add(dgvStudents);

            string[] AHRecord = { "Adrian", "Hewitt", "Male" };
            dgvStudents.Rows.Add(AHRecord);
}

Data Sets:

namespace VideoCollection1
{
    public partial class Exercise : Form
    {
        DataSet dsVideoCollection;

        public Exercise()
        {
            InitializeComponent();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            dsVideoCollection = new DataSet();
        }
    }
}

The Tables of a Data Set:

    public partial class Exercise : Form
    {
        DataTable tblActors;
        DataTable tblFormats;
        DataTable tblRatings;
        DataTable tblDirectors;
        DataTable tblVideoCategories;
        DataSet dsVideoCollection;

        public Exercise()
        {
            InitializeComponent();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            dsVideoCollection = new DataSet("Videos");

            tblDirectors = new DataTable();
            tblDirectors.TableName = "Directors";
            dsVideoCollection.Tables.Add(tblDirectors);

            tblVideoCategories = new DataTable("Categories");
            dsVideoCollection.Tables.Add(tblVideoCategories);

            tblRatings = dsVideoCollection.Tables.Add("Ratings");

            tblActors = dsVideoCollection.Tables.Add("Actors");
            tblFormats = dsVideoCollection.Tables.Add("Formats");

            foreach (DataTable tbl in dsVideoCollection.Tables)
                lbxVideos.Items.Add(tbl.TableName);
        }
    }

private void btnDocument_Click(object sender, EventArgs e)
{
    dsVideoCollection = new DataSet("Videos");

    tblDirectors = new DataTable();
    tblDirectors.TableName = "Directors";
    dsVideoCollection.Tables.Add(tblDirectors);

    tblVideoCategories = new DataTable("Categories");
    dsVideoCollection.Tables.Add(tblVideoCategories);

    tblRatings = dsVideoCollection.Tables.Add();

    tblActors = dsVideoCollection.Tables.Add("Actors");
    tblFormats = dsVideoCollection.Tables.Add("Formats");

    if (dsVideoCollection.Tables.Contains("Actors"))
        MessageBox.Show("The Actors table exists");
    else
        MessageBox.Show("The Actors table does not exist");

    if (dsVideoCollection.Tables.Contains("VideoTypes"))
        MessageBox.Show("The VideoTypes table exists");
    else
        MessageBox.Show("The VideoTypes table does not exist");
}

The column of a table

public partial class Exercise : Form
    {
        DataTable dtVideos;
        DataColumn[] colVideos;
        DataSet dsVideoCollection;

        public Exercise()
        {
            InitializeComponent();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            colVideos = new DataColumn[7];

            colVideos[0] = new DataColumn("Title");
            colVideos[1] = new DataColumn("Director");
            colVideos[2] = new DataColumn("YearReleased");
            colVideos[3] = new DataColumn("Length");
            colVideos[4] = new DataColumn("Rating");
            colVideos[5] = new DataColumn("Format");
            colVideos[6] = new DataColumn("Category");

            dtVideos = new DataTable("Videos");
            dtVideos.Columns.AddRange(colVideos);

            dsVideoCollection = new DataSet("VideoCollection");
            dsVideoCollection.Tables.Add(dtVideos);

            for (int i = 0; i < dtVideos.Columns.Count; i++)
                lbxVideos.Items.Add(dtVideos.Columns[i].ColumnName);
        }
    }
	
	public partial class Exercise : Form
    {
        DataColumn colTitle;
        DataColumn colDirector;
        DataColumn colLength;
        DataColumn colFormat;
        DataColumn colRating;
        DataTable tblVideos;

        public Exercise()
        {
            InitializeComponent();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            tblVideos = new DataTable("Video");

            colTitle = new DataColumn("Title");
            tblVideos.Columns.Add(colTitle);

            colDirector = new DataColumn("Director");
            tblVideos.Columns.Add(colDirector);

            colLength = new DataColumn("Length");
            tblVideos.Columns.Add(colLength);

            colFormat = new DataColumn("Format");
            tblVideos.Columns.Add(colFormat);

            colRating = new DataColumn("Rating");
            tblVideos.Columns.Add(colRating);

            lbxVideos.Items.Clear();
            lbxNewVideos.Items.Clear();

            foreach (DataColumn col in tblVideos.Columns)
                lbxVideos.Items.Add(col.ColumnName);

            tblVideos.Columns.Remove("Format");

            foreach (DataColumn col in tblVideos.Columns)
                lbxNewVideos.Items.Add(col.ColumnName);
        }
    }
	
	Records of a Data Set
	
	public class Exercise : Form
{
    DataGridView dgvStudents;

    DataSet dsRedOakHighSchool;
    DataTable tblRegistration;
    DataColumn colFirstName;
    DataColumn colLastName;
    DataColumn colGender;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Text = "Students Records";
        dgvStudents = new DataGridView();
        dgvStudents.Location = new Point(12, 12);
        Controls.Add(dgvStudents);

        colFirstName = new DataColumn("First Name");
        colLastName = new DataColumn("Last Name");
        colGender = new DataColumn("Gender");

        tblRegistration = new DataTable("Student Registration");
        tblRegistration.Columns.Add(colFirstName);
        tblRegistration.Columns.Add(colLastName);
        tblRegistration.Columns.Add(colGender);

        dsRedOakHighSchool = new DataSet("Red Oak High School");
        dsRedOakHighSchool.Tables.Add(tblRegistration);

        DataRow rowStudent = tblRegistration.NewRow();
        rowStudent["First Name"] = "Pauline";
        rowStudent["Last Name"] = "Simms";
        rowStudent["Gender"] = "Female";

        tblRegistration.Rows.Add(rowStudent);

        dgvStudents.DataSource = dsRedOakHighSchool;
        dgvStudents.DataMember = "Student Registration";
    }
}

void InitializeComponent()
{
    . . . 

    DataRow rowStudent = tblRegistration.NewRow();
    rowStudent["First Name"] = "Pauline";
    rowStudent["Last Name"] = "Simms";
    rowStudent["Gender"] = "Female";
    tblRegistration.Rows.Add(rowStudent);

    object[] arrRecord = { "Edward", "Zaks", "Male" };
    tblRegistration.Rows.Add(arrRecord);

    dgvStudents.DataSource = dsRedOakHighSchool;
    dgvStudents.DataMember = "Student Registration";
}

void InitializeComponent()
{
    Text = "Students Records";
    dgvStudents = new DataGridView();
    dgvStudents.Location = new Point(12, 12);
    Controls.Add(dgvStudents);

    colFirstName = new DataColumn("First Name");
    colLastName = new DataColumn("Last Name");
    colGender = new DataColumn("Gender");

    tblRegistration = new DataTable("Student Registration");
    tblRegistration.Columns.Add(colFirstName);
    tblRegistration.Columns.Add(colLastName);
    tblRegistration.Columns.Add(colGender);

    dsRedOakHighSchool = new DataSet("Red Oak High School");
    dsRedOakHighSchool.Tables.Add(tblRegistration);

    DataRow rowStudent = tblRegistration.NewRow();
    rowStudent["First Name"] = "Pauline";
    rowStudent["Last Name"] = "Simms";
    rowStudent["Gender"] = "Female";
    tblRegistration.Rows.Add(rowStudent);

    object[] arrRecord = { "Edward", "Zaks", "Male" };
    tblRegistration.Rows.Add(arrRecord);

    object[] arrStudent = { "Geraldine", "Rodetsky", "Unknown" };

    rowStudent = tblRegistration.NewRow();
    rowStudent.ItemArray = arrStudent;

    tblRegistration.Rows.Add(rowStudent);

    dgvStudents.DataSource = dsRedOakHighSchool;
    dgvStudents.DataMember = "Student Registration";
}

using System;
using System.IO;
using System.Xml;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

public class Exercise : Form
{
    DataGridView dgvStudents;

    DataSet dsRedOakHighSchool;
    DataTable tblRegistration;
    DataColumn colFirstName;
    DataColumn colLastName;
    DataColumn colGender;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Text = "Students Records";

        dgvStudents = new DataGridView();
        dgvStudents.Location = new Point(12, 12);
        Controls.Add(dgvStudents);

        colFirstName = new DataColumn("First Name");
        colLastName = new DataColumn("Last Name");
        colGender = new DataColumn("Gender");

        tblRegistration = new DataTable("Student Registration");
        tblRegistration.Columns.Add(colFirstName);
        tblRegistration.Columns.Add(colLastName);
        tblRegistration.Columns.Add(colGender);

        dsRedOakHighSchool = new DataSet("Red Oak High School");
        dsRedOakHighSchool.Tables.Add(tblRegistration);

        DataRow rowStudent = tblRegistration.NewRow();
        rowStudent["First Name"] = "Pauline";
        rowStudent["Last Name"] = "Simms";
        rowStudent["Gender"] = "Female";
        tblRegistration.Rows.Add(rowStudent);

        object[] arrRecord = { "Edward", "Zaks", "Male" };
        tblRegistration.Rows.Add(arrRecord);

        object[] arrStudent = { "Geraldine", "Rodetsky", "Unknown" };

        rowStudent = tblRegistration.NewRow();
        rowStudent.ItemArray = arrStudent;

        tblRegistration.Rows.Add(rowStudent);

        FileStream stmStudents = new FileStream("registration.xml",
                                                 FileMode.Create,
                                                 FileAccess.Write);
        dsRedOakHighSchool.WriteXml(stmStudents);
    }
}

public class Program
{
    static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}

using System;
using System.IO;
using System.Xml;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

public class Exercise : Form
{
    DataGridView dgvStudents;

    DataSet dsRedOakHighSchool;
    DataTable tblRegistration;
    DataColumn colFirstName;
    DataColumn colLastName;
    DataColumn colGender;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Text = "Students Records";

        dgvStudents = new DataGridView();
        dgvStudents.Location = new Point(12, 12);
        Controls.Add(dgvStudents);

        colFirstName = new DataColumn("First Name");
        colLastName = new DataColumn("Last Name");
        colGender = new DataColumn("Gender");

        tblRegistration = new DataTable("Student Registration");
        tblRegistration.Columns.Add(colFirstName);
        tblRegistration.Columns.Add(colLastName);
        tblRegistration.Columns.Add(colGender);

        dsRedOakHighSchool = new DataSet("Red Oak High School");
        dsRedOakHighSchool.Tables.Add(tblRegistration);

        if( File.Exists("students.xml") )
        {
            dsRedOakHighSchool.ReadXml("students.xml");
            dgvStudents.DataSource = dsRedOakHighSchool;
            dgvStudents.DataMember = "Student Registration";
        }
    }
}

public class Program
{
    static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}

using System;
using System.IO;
using System.Xml;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

public class Exercise : Form
{
    ListView lvwStudents;

    DataSet dsRedOakHighSchool;
    DataTable tblRegistration;
    DataColumn colStudentNumber;
    DataColumn colFirstName;
    DataColumn colLastName;
    DataColumn colGender;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Text = "Students Records";

        lvwStudents = new ListView();
        lvwStudents.Location = new Point(12, 12);
        Controls.Add(lvwStudents);

        colStudentNumber = new DataColumn("StudentNumber");
        colFirstName = new DataColumn("FirstName");
        colLastName = new DataColumn("LastName");
        colGender = new DataColumn("Gender");

        tblRegistration = new DataTable("Student");
        tblRegistration.Columns.Add(colStudentNumber);
        tblRegistration.Columns.Add(colFirstName);
        tblRegistration.Columns.Add(colLastName);
        tblRegistration.Columns.Add(colGender);

        dsRedOakHighSchool = new DataSet("SchoolRecords");
        dsRedOakHighSchool.Tables.Add(tblRegistration);

        object[] objStudents1 = { "920759", "Pauline", "Simms", "Female" };
        tblRegistration.Rows.Add(objStudents1);
        object[] objStudents2 = { "281174", "Geraldine", "Rodetsky", "Unknown" };
        tblRegistration.Rows.Add(objStudents2);
        object[] objStudents3 = { "400795", "Edward", "Zaks", "Male" };
        tblRegistration.Rows.Add(objStudents3);
        object[] objStudents4 = { "931579", "Jeannete", "Palau", "Female" };
        tblRegistration.Rows.Add(objStudents4);
        object[] objStudents5 = { "315825", "Kate", "Hooks", "Unknown" };
        tblRegistration.Rows.Add(objStudents5);
        dsRedOakHighSchool.WriteXml("students.xml");
    }
}

public class Program
{
    static int Main()
    {
        System.Windows.Forms.Application.Run(new Exercise());
        return 0;
    }
}

<?xml version="1.0" standalone="yes"?>
<SchoolRecords>
  <Student>
    <StudentNumber>920759</StudentNumber>
    <FirstName>Pauline</FirstName>
    <LastName>Simms</LastName>
    <Gender>Female</Gender>
  </Student>
  <Student>
    <StudentNumber>281174</StudentNumber>
    <FirstName>Geraldine</FirstName>
    <LastName>Rodetsky</LastName>
    <Gender>Unknown</Gender>
  </Student>
  <Student>
    <StudentNumber>400795</StudentNumber>
    <FirstName>Edward</FirstName>
    <LastName>Zaks</LastName>
    <Gender>Male</Gender>
  </Student>
  <Student>
    <StudentNumber>931579</StudentNumber>
    <FirstName>Jeannete</FirstName>
    <LastName>Palau</LastName>
    <Gender>Female</Gender>
  </Student>
  <Student>
    <StudentNumber>315825</StudentNumber>
    <FirstName>Kate</FirstName>
    <LastName>Hooks</LastName>
    <Gender>Unknown</Gender>
  </Student>
</SchoolRecords>

void InitializeComponent()
{
    Text = "Students Records";
    Size = new Size(320, 160);

    lvwStudents = new ListView();
    lvwStudents.Location = new Point(12, 12);
    lvwStudents.Size = new Size(290, 110);
    lvwStudents.View = View.Details;
    lvwStudents.GridLines = true;
    lvwStudents.FullRowSelect = true;

    Controls.Add(lvwStudents);

    colStudentNumber = new DataColumn("StudentNumber");
    colFirstName = new DataColumn("FirstName");
    colLastName = new DataColumn("LastName");
    colGender = new DataColumn("Gender");

    tblRegistration = new DataTable("Student");
    tblRegistration.Columns.Add(colStudentNumber);
    tblRegistration.Columns.Add(colFirstName);
    tblRegistration.Columns.Add(colLastName);
    tblRegistration.Columns.Add(colGender);

    dsRedOakHighSchool = new DataSet("SchoolRecords");
    dsRedOakHighSchool.Tables.Add(tblRegistration);

    dsRedOakHighSchool.ReadXml("students.xml");

    lvwStudents.Columns.Add("Student #");
    lvwStudents.Columns.Add("First Name", 75);
    lvwStudents.Columns.Add("Last Name", 75);
    lvwStudents.Columns.Add("Gender");

    for (int i = 0; i < tblRegistration.Rows.Count; i++)
    {
        DataRow rowStudent = tblRegistration.Rows[i];
    }
}

Locating:

for (int i = 0; i < tblRegistration.Rows.Count; i++)
    {
        DataRow rowStudent = tblRegistration.Rows[i];

        ListViewItem lviStudent =
		new ListViewItem(rowStudent[0].ToString());
        lviStudent.SubItems.Add(rowStudent[1].ToString());
        lviStudent.SubItems.Add(rowStudent[2].ToString());
        lviStudent.SubItems.Add(rowStudent[3].ToString());

        lvwStudents.Items.Add(lviStudent);
    }
	
for (int i = 0; i < tblRegistration.Rows.Count; i++)
    {
        ListViewItem lviStudent =
		new ListViewItem(tblRegistration.Rows[i][0].ToString());
        lviStudent.SubItems.Add(tblRegistration.Rows[i][1].ToString());
        lviStudent.SubItems.Add(tblRegistration.Rows[i][2].ToString());
        lviStudent.SubItems.Add(tblRegistration.Rows[i][3].ToString());

        lvwStudents.Items.Add(lviStudent);
	}

	foreach(DataRow rowStudent in tblRegistration.Rows)
    {
        ListViewItem lviStudent =
        	new ListViewItem(rowStudent[0].ToString());
        lviStudent.SubItems.Add(rowStudent[1].ToString());
        lviStudent.SubItems.Add(rowStudent[2].ToString());
        lviStudent.SubItems.Add(rowStudent[3].ToString());

        lvwStudents.Items.Add(lviStudent);
    }

for (int i = 0; i < tblRegistration.Rows.Count; i++)
    {
        DataRow rowStudent = tblRegistration.Rows[i];

        ListViewItem lviStudent =
	    new ListViewItem(rowStudent["StudentNumber"].ToString());
        lviStudent.SubItems.Add(rowStudent["FirstName"].ToString());
        lviStudent.SubItems.Add(rowStudent["LastName"].ToString());
        lviStudent.SubItems.Add(rowStudent["Gender"].ToString());

        lvwStudents.Items.Add(lviStudent);
    }

	for (int i = 0; i < tblRegistration.Rows.Count; i++)
    {
        DataRow rowStudent = tblRegistration.Rows[i];

        ListViewItem lviStudent =
		new ListViewItem(rowStudent[colStudentNumber].ToString());
        lviStudent.SubItems.Add(rowStudent[colFirstName].ToString());
        lviStudent.SubItems.Add(rowStudent[colLastName].ToString());
        lviStudent.SubItems.Add(rowStudent[colGender].ToString());

        lvwStudents.Items.Add(lviStudent);
    }

foreach(DataRow rowStudent in tblRegistration.Rows)
    {
        foreach (DataColumn col in tblRegistration.Columns)
        {
            MessageBox.Show(rowStudent[col].ToString());
        }
        break;
    }

foreach (DataRow rowStudent in tblRegistration.Rows)
    {
        foreach (DataColumn col in tblRegistration.Columns)
        {
            ListViewItem lviStudent =
                new ListViewItem(rowStudent["StudentNumber"].ToString());
            lviStudent.SubItems.Add(rowStudent["FirstName"].ToString());
            lviStudent.SubItems.Add(rowStudent["LastName"].ToString());
            lviStudent.SubItems.Add(rowStudent["Gender"].ToString());

            lvwStudents.Items.Add(lviStudent);
            break;
        }
    }

	
Data Entry
	
	public class Exercise : Form
{
    DataSet dsRedOakHighSchool;
    DataTable tblRegistration;
    DataColumn colFirstName;
    DataColumn colLastName;
    DataColumn colFullName;

    DataGridView dgvStudents;

    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Text = "Students Records";
        Size = new Size(550, 160);

        colFirstName = new DataColumn("FirstName");
        colFirstName.DataType = Type.GetType("System.String");

        colLastName = new DataColumn("LastName");
        colLastName.DataType = Type.GetType("System.String");

        colFullName = new DataColumn("FullName");
        colFullName.DataType = Type.GetType("System.String");
        colFullName.Expression = "FirstName + ' ' + LastName";

        tblRegistration = new DataTable("Student");
        tblRegistration.Columns.Add(colFirstName);
        tblRegistration.Columns.Add(colLastName);
        tblRegistration.Columns.Add(colFullName);

        dsRedOakHighSchool = new DataSet("StudentsRecords");
        dsRedOakHighSchool.Tables.Add(tblRegistration);

        dgvStudents = new DataGridView();
        dgvStudents.Location = new Point(12, 12);
        dgvStudents.Size = new Size(400, 100);
        dgvStudents.DataSource = dsRedOakHighSchool;
        dgvStudents.DataMember = "Student";

        Controls.Add(dgvStudents);
    }
}

Using the Data Set of a Table Adapter

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunDepartmentStore1
{
    public partial class CurrentStoreInventory : Form
    {
        List<string> NumericOperators;
        List<string> StringOperators;
        
        public CurrentStoreInventory()
        {
            InitializeComponent();
        }

        private void btnShowCurrentInventory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < taStoreItems.GetData().Rows.Count; i++)
            {
                DataRow rcdStoreItem = taStoreItems.GetData().Rows[i];

                ListViewItem lviStoreItem = new ListViewItem((i + 1).ToString());
                lviStoreItem.SubItems.Add(rcdStoreItem["ItemNumber"].ToString());
                lviStoreItem.SubItems.Add(rcdStoreItem["Manufacturer"].ToString());
                lviStoreItem.SubItems.Add(rcdStoreItem["Category"].ToString());
                lviStoreItem.SubItems.Add(rcdStoreItem["SubCategory"].ToString());
                lviStoreItem.SubItems.Add(rcdStoreItem["ItemName"].ToString());
                lviStoreItem.SubItems.Add(rcdStoreItem["ItemSize"].ToString());
                lviStoreItem.SubItems.Add(
                    double.Parse(rcdStoreItem["UnitPrice"].ToString()).ToString("F"));
                lviStoreItem.SubItems.Add(rcdStoreItem["SaleStatus"].ToString());
                lvwStoreItems.Items.Add(lviStoreItem);
            }

            foreach (DataColumn col in taStoreItems.GetData().Columns)
                cbxColumns.Items.Add(col.ColumnName);

            NumericOperators = new List<String>();
            NumericOperators.Add("Equal To");
            NumericOperators.Add("Is Not Equal To");
            NumericOperators.Add("Less Than");
            NumericOperators.Add("Less Than Or Equal To");
            NumericOperators.Add("Greater Than");
            NumericOperators.Add("Greater Than Or Equal To");

            StringOperators = new List<String>();

            StringOperators.Add("Equal To");
            StringOperators.Add("Different From");
            StringOperators.Add("Starts With");
            StringOperators.Add("Doesn't Start With");
            StringOperators.Add("Contains");
            StringOperators.Add("Doesn't Contain");
            StringOperators.Add("Ends With");
            StringOperators.Add("Doesn't End With");
        }
    }
}

private void cbxColumns_SelectedIndexChanged(object sender, EventArgs e)
{
    foreach (DataColumn col in taStoreItems.GetData().Columns)
    {
        if (col.ColumnName.Equals(cbxColumns.Text))
        {
            cbxOperators.Items.Clear();

            if (col.DataType == Type.GetType("System.Int32"))
            {
                foreach (string strOperator in NumericOperators)
                    cbxOperators.Items.Add(strOperator);

                cbxOperators.SelectedIndex = 0;
            }
            else if (col.DataType == Type.GetType("System.Decimal"))
            {
                foreach (string strOperator in NumericOperators)
                    cbxOperators.Items.Add(strOperator);

                cbxOperators.SelectedIndex = 0;
            }
            else if (col.DataType == Type.GetType("System.String"))
            {
                foreach (string strOperator in StringOperators)
                    cbxOperators.Items.Add(strOperator);
                        
                cbxOperators.SelectedIndex = 0;
            }
            else
            {
                cbxOperators.Items.Clear();
                cbxOperators.Text = "";
            }
        }
    }
}
		
Common Table Expressions 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement1
{
    public partial class HotelManagement : Form
    {
        public HotelManagement()
        {
            InitializeComponent();
        }

        void CreateHotelRooms()
        {
            using (SqlConnection conHotelManagement =
                new SqlConnection("Data Source=(local);" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdHotelManagement =
            new SqlCommand("IF  EXISTS(SELECT name " +
                           "    FROM sys.databases " +
                           "    WHERE name = N'HotelManagement1') " +
                           "DROP DATABASE HotelManagement1;" +
                           "CREATE DATABASE HotelManagement1;",
                           conHotelManagement);
                conHotelManagement.Open();

                cmdHotelManagement.ExecuteNonQuery();
                MessageBox.Show("The HotelManagement1 database has been created.",
                                "Ceil Inn - Hotel Management", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            using (SqlConnection conHotelManagement =
                new SqlConnection("Data Source=(local);" +
                                  "Database=HotelManagement1;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdHotelManagement =
                    new SqlCommand("CREATE TABLE Bedrooms(" +
                                  "RoomNumber nchar(10) not null," +
                                  "RoomType nvarchar(20) default N'Bedroom'," +
                                  "BedType nvarchar(40) default N'Queen'," +
                                  "Rate money default 75.85, Available bit default 0);",
                                   conHotelManagement);
                conHotelManagement.Open();

                cmdHotelManagement.ExecuteNonQuery();
                MessageBox.Show("A table named Bedrooms has been created.",
                                "Ceil Inn - Hotel Management", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            using (SqlConnection conHotelManagement =
                new SqlConnection("Data Source=(local);" +
                                  "Database=HotelManagement1;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdHotelManagement =
                    new SqlCommand("INSERT INTO Bedrooms(RoomNumber, BedType, Rate, Available)" +
                                  "VALUES(N'104', N'Queen', 80.25, 0)," +
                                  "      (N'105', N'King', 95.50, 1)," +
                                  "      (N'106', N'Queen', 65.95, 1)," +
                                  "      (N'107', N'Queen', 65.95, 1)," +
                                  "      (N'108', N'King', 92.50, 1)," +
                                  "      (N'109', N'Queen', 68.95, 0)," +
                                  "      (N'110', N'Queen', 74.95, 1);",
                                   conHotelManagement);
                conHotelManagement.Open();

                cmdHotelManagement.ExecuteNonQuery();
                MessageBox.Show("Records have been added to the Bedrooms table.",
                                "Ceil Inn - Hotel Management", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            using (SqlConnection cnnHotelManagement =
                new SqlConnection("Data Source=(local);" +
                                  "Database=HotelManagement1;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdHotelManagement =
                    new SqlCommand("CREATE TABLE ConferenceRooms(" +
                                  "RoomNumber nchar(10) not null," +
                                  "RoomType nvarchar(20) default N'Conference'," +
                                  "BedType nvarchar(40), Rate money default 75.85," +
                                  "Available bit default 0);", cnnHotelManagement);
                cnnHotelManagement.Open();

                cmdHotelManagement.ExecuteNonQuery();
                MessageBox.Show("A table named ConferenceRooms has been created.",
                                "Ceil Inn - Hotel Management", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            using (SqlConnection conHotelManagement =
                new SqlConnection("Data Source=(local);" +
                                  "Database=HotelManagement1;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdHotelManagement =
                    new SqlCommand("INSERT INTO ConferenceRooms(RoomNumber, Rate, Available)" +
                                   "VALUES(N'C-120', 525.00, 1);" +
                                   "INSERT INTO Bedrooms(RoomNumber, RoomType, BedType, Rate, Available)" +
                                   "VALUES(N'116', N'Studio', N'King', 112.95, 0);" +
                                   "INSERT INTO ConferenceRooms(RoomNumber, Rate, Available)" +
                                   "VALUES(N'C-122', 450.00, 1);" +
                                   "INSERT INTO Bedrooms(RoomNumber, RoomType, BedType, Rate, Available)" +
                                   "VALUES(N'202', N'Studio', N'King', 105.95, 1)," +
                                   "      (N'203', N'Studio', N'Queen', 102.50, 1);" +
                                   "INSERT INTO Bedrooms(RoomNumber, BedType, Rate, Available)" +
                                   "VALUES(N'204', N'Double', 115.95, 1)," +
                                   "      (N'205', N'Queen', 82.95, 0)," +
                                   "      (N'206', N'King', 98.50, 1)" +
                                   "INSERT INTO ConferenceRooms(RoomNumber, Rate, Available)" +
                                   "VALUES(N'C-302', 650.00, 1);",
                                   conHotelManagement);
                conHotelManagement.Open();

                cmdHotelManagement.ExecuteNonQuery();
                MessageBox.Show("Records have been added to the ConferenceRooms table.",
                                "Ceil Inn - Hotel Management", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void HotelManagement_Load(object sender, EventArgs e)
        {
            CreateHotelRooms();
        }
    }
}
		
	
The Binding Source

	private void btnBindingSource_Click(object sender, EventArgs e)
{
    BindingSource bsNames = new BindingSource();
    List<string> strNames = new List<string>();

    strNames.Add("Vicky Bisso");
    strNames.Add("Amy Warren");
    strNames.Add("Chrissie Childs");
    strNames.Add("Martial Otto");

    bsNames.DataSource = strNames;
}

Display the Records of a Table in a Data Grid View:


using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

public class DatabaseExercise : Form
{
    Button btnShow;
    DataGridView dgvProperties;

    public DatabaseExercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        btnShow = new Button();
        btnShow.Text = "Show";
        btnShow.Location = new System.Drawing.Point(12, 12);
        btnShow.Click += new EventHandler(btnShowClicked);
        dgvProperties = new DataGridView();
        dgvProperties.Location = new System.Drawing.Point(12, 44);
        dgvProperties.Anchor = AnchorStyles.Left | AnchorStyles.Top |
                               AnchorStyles.Right | AnchorStyles.Bottom;

        Text = "Database Exercise";
        StartPosition = FormStartPosition.CenterScreen;
        Size = new System.Drawing.Size(275, 235);

        Controls.Add(btnShow);
        Controls.Add(dgvProperties);
    }

    private void btnShowClicked(object sender, EventArgs e)
    {
        using (SqlConnection scnDepartmentStore =
                new SqlConnection("Data Source=(local);" +
                                  "Database='AltairRealtors1';" +
                                  "Integrated Security=yes;"))
        {
            SqlCommand cmdProperties =
                        new SqlCommand("SELECT * FROM dbo.Properties; ",
                                       scnDepartmentStore);
            SqlDataAdapter sdaProperties = new SqlDataAdapter();
            DataSet dsProperties = new DataSet("StoreItems");

            scnDepartmentStore.Open();

            sdaProperties.SelectCommand = cmdProperties;
            sdaProperties.Fill(dsProperties);

            dgvProperties.DataSource = dsProperties.Tables[0];
        }
    }
}

public class Exercise
{
    public static int Main()
    {
        Application.Run(new DatabaseExercise());
        return 0;
    }
}


using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

public class DatabaseExercise : Form
{
    Button btnShow;
    DataGridView dgvProperties;

    public DatabaseExercise()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        btnShow = new Button();
        btnShow.Text = "Show";
        btnShow.Location = new System.Drawing.Point(12, 12);
        btnShow.Click += new EventHandler(btnShowClicked);
        dgvProperties = new DataGridView();
        dgvProperties.Location = new System.Drawing.Point(12, 44);
        dgvProperties.Anchor = AnchorStyles.Left | AnchorStyles.Top |
                               AnchorStyles.Right | AnchorStyles.Bottom;

        Text = "Database Exercise";
        StartPosition = FormStartPosition.CenterScreen;
        Size = new System.Drawing.Size(275, 235);

        Controls.Add(btnShow);
        Controls.Add(dgvProperties);
    }

    private void btnShowClicked(object sender, EventArgs e)
    {
        using (SqlConnection scnDepartmentStore =
                new SqlConnection("Data Source=(local);" +
                                  "Database='AltairRealtors1';" +
                                  "Integrated Security=yes;"))
        {
            SqlCommand cmdProperties =
                        new SqlCommand("SELECT * FROM dbo.Properties; ",
                                       scnDepartmentStore);
            SqlDataAdapter sdaProperties = new SqlDataAdapter(cmdProperties);
            DataSet dsProperties = new DataSet("StoreItems");

            scnDepartmentStore.Open();

            sdaProperties.Fill(dsProperties);

            dgvProperties.DataSource = dsProperties.Tables[0];
        }
    }
}

public class Exercise
{
    public static int Main()
    {
        Application.Run(new DatabaseExercise());
        return 0;
    }
}


