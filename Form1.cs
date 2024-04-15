using ToDoListWindowsFormApp.Context;
using ToDoListWindowsFormApp.Entities;

namespace ToDoListWindowsFormApp
{
    public partial class Form1 : Form
    {
        ToDoListContext context = new ToDoListContext();
        ToDoTask task = new ToDoTask();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = context.ToDoTasks.ToList();
        }

        /// <summary>
        /// This method is basically the "GET/READ OPERATION" of the ToDoTasks. When the user clicks any row of the
        /// DataGridView, the text boxes are populated with the data of the selected row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Getting the Id of the selected row.
            int taskId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TaskId"].Value);

            task = context.ToDoTasks.FirstOrDefault(x => x.TaskId == taskId);

            txtName.Text = task.TaskName;
            txtDescription.Text = task.TaskDescription;
            txtDueDate.Text = task.TaskDueDate.ToString();
            txtStatus.Text = task.TaskStatus;
        }

        /// <summary>
        /// This method is basically the "CREATE/ADD OPERATION" of the ToDoTasks. When the user clicks on the Add Task button
        /// after filling the text boxes, the new task will be added to the DB, the text boxes will be cleared and the 
        /// new task will be displayed on the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            // Validating the user inputs.
            if (ValidateTextboxes())
            {
                ToDoTask taskToBeAdded = new ToDoTask();

                taskToBeAdded.TaskName = txtName.Text;
                taskToBeAdded.TaskDescription = txtDescription.Text;
                taskToBeAdded.TaskDueDate = Convert.ToDateTime(txtDueDate.Text);
                taskToBeAdded.TaskStatus = txtStatus.Text;

                context.ToDoTasks.Add(taskToBeAdded);
                context.SaveChanges();

                ClearTextBoxes();
                // Calling the LoadDataGridView so that the grid view is populated once the new task is added.
                LoadDataGridView();

                // Displaying message to the user.
                MessageBox.Show("Task added successfully.");
            }
        }

        /// <summary>
        /// This method is basically the "UPDATE OPERATION" of the ToDoTasks. When the user clicks on the Update Task button
        /// after filling the text boxes, the task will be updated in the DB, the text boxes will be cleared and the 
        /// updated task will be displayed on the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdateTask_Click(object sender, EventArgs e)
        {
            // Checking if the user selected a task to update.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Getting the Id of the selected task.
                int taskId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TaskId"].Value);
                var taskToUpdate = context.ToDoTasks.FirstOrDefault(x => x.TaskId == taskId);

                if (taskToUpdate != null)
                {
                    // Validating the user inputs.
                    if (ValidateTextboxes())
                    {
                        taskToUpdate.TaskName = txtName.Text;
                        taskToUpdate.TaskDescription = txtDescription.Text;
                        taskToUpdate.TaskDueDate = Convert.ToDateTime(txtDueDate.Text);
                        taskToUpdate.TaskStatus = txtStatus.Text;

                        context.Entry(taskToUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();

                        ClearTextBoxes();
                        // Calling the LoadDataGridView so that the grid view is populated once an existing task is updated.
                        LoadDataGridView();

                        // Displaying message to the user.
                        MessageBox.Show("Task updated successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to update.");
            }
        }

        /// <summary>
        /// This method is basically the "DELETE OPERATION" of the ToDoTasks. When the user clicks on the Delete Task button
        /// after selecting a task, the task will be deleted from the DB, the text boxes will be cleared and the 
        /// DataGridView will be updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            // Checking if the user selected a task to delete.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Getting the Id of the selected task.
                int taskId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TaskId"].Value);
                var taskToDelete = context.ToDoTasks.FirstOrDefault(x => x.TaskId == taskId);

                if (taskToDelete != null)
                {
                    context.ToDoTasks.Remove(taskToDelete);
                    context.SaveChanges();

                    ClearTextBoxes();
                    LoadDataGridView();

                    // Displaying message to the user.
                    MessageBox.Show("Task deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        /// <summary>
        /// This method clears the text boxes by setting their value to an empty string.
        /// </summary>
        public void ClearTextBoxes()
        {
            txtName.Text = txtDescription.Text = txtDueDate.Text = txtStatus.Text = string.Empty;
        }

        /// <summary>
        /// When the user clicks the Cancel button, the text boxes will be cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        /// <summary>
        /// This method validates the value of the textboxes for the ADD and UPDATE operations.
        /// </summary>
        /// <returns></returns>
        public bool ValidateTextboxes()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a task name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a task description.");
                return false;
            }

            DateTime dueDate;
            if (!DateTime.TryParse(txtDueDate.Text, out dueDate))
            {
                MessageBox.Show("Please enter a valid due date.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Please enter a task status.");
                return false;
            }

            return true;
        }
    }
}
