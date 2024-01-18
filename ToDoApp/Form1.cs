using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ToDoApp

{
    public partial class Form1 : Form
    {

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        Color backgroundPageColor = Color.White;
        Color backgroundTextBoxColor = Color.FromArgb(192, 192, 192);
        Color textColor = Color.FromArgb(55, 48, 107);

        List<string> Tasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
            SetDesign();
            SetMovement();
            ShowData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetRoundCorners()
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90); // Bottom-left corner

            this.Region = new Region(path);
        }

        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void YourForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - startPoint.X;
                int deltaY = e.Y - startPoint.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void YourForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void SetTittle()
        {
            Title.ForeColor = textColor;

        }

        private void SetBackground()
        {
            this.BackColor = backgroundPageColor;
        }

        private void SetTaskTextBox()
        {
            TaskTextBox.BackColor = backgroundTextBoxColor;
            SetTextBoxCorners();
        }

        private void SetTextBoxCorners()
        {
            int radius = 5;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Top-left corner
            path.AddArc(TaskTextBox.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); // Top-right corner
            path.AddArc(TaskTextBox.Width - radius * 2, TaskTextBox.Height - radius * 2, radius * 2, radius * 2, 0, 90); // Bottom-right corner
            path.AddArc(0, TaskTextBox.Height - radius * 2, radius * 2, radius * 2, 90, 90); // Bottom-left corner

            TaskTextBox.Region = new Region(path);
        }

        private void SetAddButton()
        {
            AddButton.ForeColor = Color.White;
            AddButton.BackColor = textColor;
            SetAddButtonCorners();
        }

        private void SetAddButtonCorners()
        {
            int radius = 10;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Top-left corner
            path.AddArc(AddButton.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); // Top-right corner
            path.AddArc(AddButton.Width - radius * 2, AddButton.Height - radius * 2, radius * 2, radius * 2, 0, 90); // Bottom-right corner
            path.AddArc(0, AddButton.Height - radius * 2, radius * 2, radius * 2, 90, 90); // Bottom-left corner

            AddButton.Region = new Region(path);
        }


        private void SetDesign()
        {
            SetBackground();
            SetTaskTextBox();
            SetAddButton();
            SetTittle();
            SetRoundCorners();
            TasksCheckedListBox.SelectedIndexChanged += TasksCheckedListBox_SelectedIndexChanged;
        }

        private void SetMovement()
        {
            this.MouseDown += YourForm_MouseDown;
            this.MouseMove += YourForm_MouseMove;
            this.MouseUp += YourForm_MouseUp;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string text = TaskTextBox.Text.ToString();
            if(text != "")
            {
                Tasks.Add(text);
                TaskTextBox.Text = "";
                CleanGroupBox();
            }
        }

        private void CleanGroupBox()
        {
            TasksCheckedListBox.Items.Clear();
            ShowData();
        }

        private void ShowData()
        {
            TasksCheckedListBox.ForeColor = textColor;
            for (int i = 0; i < Tasks.Count; i++)
            {
                TasksCheckedListBox.Items.Add(Tasks[i]);
            }
        }

        private void TasksCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TasksCheckedListBox.SelectedIndex = -1;
        }

        private void CloseButtonImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
