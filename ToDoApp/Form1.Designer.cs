namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Title = new Label();
            TaskTextBox = new TextBox();
            AddButton = new Button();
            TasksCheckedListBox = new CheckedListBox();
            CloseButtonImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CloseButtonImage).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(50, 30);
            Title.Name = "Title";
            Title.Size = new Size(300, 40);
            Title.TabIndex = 0;
            Title.Text = "To-Do List";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskTextBox
            // 
            TaskTextBox.BackColor = SystemColors.ScrollBar;
            TaskTextBox.BorderStyle = BorderStyle.None;
            TaskTextBox.Cursor = Cursors.IBeam;
            TaskTextBox.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskTextBox.Location = new Point(50, 100);
            TaskTextBox.Margin = new Padding(0);
            TaskTextBox.MaxLength = 20;
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.Size = new Size(255, 40);
            TaskTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.BackgroundImageLayout = ImageLayout.None;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(295, 99);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(50, 42);
            AddButton.TabIndex = 2;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TasksCheckedListBox
            // 
            TasksCheckedListBox.BorderStyle = BorderStyle.None;
            TasksCheckedListBox.CheckOnClick = true;
            TasksCheckedListBox.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksCheckedListBox.FormattingEnabled = true;
            TasksCheckedListBox.Location = new Point(50, 166);
            TasksCheckedListBox.Margin = new Padding(10);
            TasksCheckedListBox.Name = "TasksCheckedListBox";
            TasksCheckedListBox.Size = new Size(295, 375);
            TasksCheckedListBox.TabIndex = 3;
            // 
            // CloseButtonImage
            // 
            CloseButtonImage.Image = (Image)resources.GetObject("CloseButtonImage.Image");
            CloseButtonImage.Location = new Point(360, 10);
            CloseButtonImage.Margin = new Padding(0);
            CloseButtonImage.Name = "CloseButtonImage";
            CloseButtonImage.Size = new Size(30, 30);
            CloseButtonImage.TabIndex = 5;
            CloseButtonImage.TabStop = false;
            CloseButtonImage.Click += CloseButtonImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 600);
            Controls.Add(CloseButtonImage);
            Controls.Add(TasksCheckedListBox);
            Controls.Add(AddButton);
            Controls.Add(TaskTextBox);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CloseButtonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox TaskTextBox;
        private Button AddButton;
        private CheckedListBox TasksCheckedListBox;
        private PictureBox CloseButtonImage;
    }
}
