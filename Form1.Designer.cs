namespace ToDoListWindowsFormApp
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
            dataGridView1 = new DataGridView();
            TaskName = new DataGridViewTextBoxColumn();
            TaskDescription = new DataGridViewTextBoxColumn();
            TaskDueDate = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewTextBoxColumn();
            TaskId = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtDueDate = new TextBox();
            txtStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAddTask = new Button();
            BtnUpdateTask = new Button();
            BtnDeleteTask = new Button();
            BtnCancel = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TaskName, TaskDescription, TaskDueDate, TaskStatus, TaskId });
            dataGridView1.Location = new Point(80, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(555, 259);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // TaskName
            // 
            TaskName.DataPropertyName = "TaskName";
            TaskName.HeaderText = "Task Name";
            TaskName.MinimumWidth = 6;
            TaskName.Name = "TaskName";
            TaskName.Width = 125;
            // 
            // TaskDescription
            // 
            TaskDescription.DataPropertyName = "TaskDescription";
            TaskDescription.HeaderText = "Task Description";
            TaskDescription.MinimumWidth = 6;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Width = 125;
            // 
            // TaskDueDate
            // 
            TaskDueDate.DataPropertyName = "TaskDueDate";
            TaskDueDate.HeaderText = "Task Due Date";
            TaskDueDate.MinimumWidth = 6;
            TaskDueDate.Name = "TaskDueDate";
            TaskDueDate.Width = 125;
            // 
            // TaskStatus
            // 
            TaskStatus.DataPropertyName = "TaskStatus";
            TaskStatus.HeaderText = "Task Status";
            TaskStatus.MinimumWidth = 6;
            TaskStatus.Name = "TaskStatus";
            TaskStatus.Width = 125;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "TaskId";
            TaskId.HeaderText = "TaskId";
            TaskId.MinimumWidth = 6;
            TaskId.Name = "TaskId";
            TaskId.Visible = false;
            TaskId.Width = 125;
            // 
            // txtName
            // 
            txtName.Location = new Point(255, 370);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(255, 421);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(268, 27);
            txtDescription.TabIndex = 2;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(255, 470);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(268, 27);
            txtDueDate.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(255, 518);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(268, 27);
            txtStatus.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 370);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "Task Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 421);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Task Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(121, 470);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 7;
            label3.Text = "Task Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(121, 518);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Task Status";
            // 
            // BtnAddTask
            // 
            BtnAddTask.BackColor = Color.FromArgb(80, 200, 120);
            BtnAddTask.FlatStyle = FlatStyle.Popup;
            BtnAddTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddTask.ForeColor = Color.White;
            BtnAddTask.Location = new Point(80, 572);
            BtnAddTask.Name = "BtnAddTask";
            BtnAddTask.Size = new Size(116, 42);
            BtnAddTask.TabIndex = 9;
            BtnAddTask.Text = "Add Task";
            BtnAddTask.UseVisualStyleBackColor = false;
            BtnAddTask.Click += BtnAddTask_Click;
            // 
            // BtnUpdateTask
            // 
            BtnUpdateTask.BackColor = Color.LightSkyBlue;
            BtnUpdateTask.FlatStyle = FlatStyle.Popup;
            BtnUpdateTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUpdateTask.ForeColor = Color.White;
            BtnUpdateTask.Location = new Point(226, 573);
            BtnUpdateTask.Name = "BtnUpdateTask";
            BtnUpdateTask.Size = new Size(116, 42);
            BtnUpdateTask.TabIndex = 10;
            BtnUpdateTask.Text = "Update Task";
            BtnUpdateTask.UseVisualStyleBackColor = false;
            BtnUpdateTask.Click += BtnUpdateTask_Click;
            // 
            // BtnDeleteTask
            // 
            BtnDeleteTask.BackColor = Color.IndianRed;
            BtnDeleteTask.FlatStyle = FlatStyle.Popup;
            BtnDeleteTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeleteTask.ForeColor = Color.White;
            BtnDeleteTask.Location = new Point(375, 573);
            BtnDeleteTask.Name = "BtnDeleteTask";
            BtnDeleteTask.Size = new Size(116, 40);
            BtnDeleteTask.TabIndex = 11;
            BtnDeleteTask.Text = "Delete Task";
            BtnDeleteTask.UseVisualStyleBackColor = false;
            BtnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.DarkGray;
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(519, 572);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(116, 40);
            BtnCancel.TabIndex = 12;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(295, 9);
            label5.Name = "label5";
            label5.Size = new Size(165, 31);
            label5.TabIndex = 13;
            label5.Text = "ToDo List App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(272, 323);
            label6.Name = "label6";
            label6.Size = new Size(169, 31);
            label6.TabIndex = 14;
            label6.Text = "Manage Tasks";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 640);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnCancel);
            Controls.Add(BtnDeleteTask);
            Controls.Add(BtnUpdateTask);
            Controls.Add(BtnAddTask);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStatus);
            Controls.Add(txtDueDate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn TaskDescription;
        private DataGridViewTextBoxColumn TaskDueDate;
        private DataGridViewTextBoxColumn TaskStatus;
        private DataGridViewTextBoxColumn TaskId;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtDueDate;
        private TextBox txtStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAddTask;
        private Button BtnUpdateTask;
        private Button BtnDeleteTask;
        private Button BtnCancel;
        private Label label5;
        private Label label6;
    }
}
