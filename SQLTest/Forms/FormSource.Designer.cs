
namespace SQLTest.Forms
{
    partial class FormSource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormSource";
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnMinEmission = new DataGridViewTextBoxColumn();
            ColumnMaxEmission = new DataGridViewTextBoxColumn();
            ColumnAverageEmission = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Insert(2, ColumnAverageEmission);
            dataGridView1.Columns.Insert(2, ColumnMaxEmission);
            dataGridView1.Columns.Insert(2, ColumnMinEmission);
            dataGridView1.Columns.Insert(2, ColumnAddress);
            dataGridView1.Columns.Insert(2, ColumnName);
            
            // 
            // ColumnSource
            // 
            ColumnName.HeaderText = "Source";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "Name";
            ColumnName.Width = 125;
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Address";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "Address";
            ColumnAddress.Width = 125;
            // 
            // ColumnMinEmission
            // 
            ColumnMinEmission.HeaderText = "Minimun";
            ColumnMinEmission.MinimumWidth = 6;
            ColumnMinEmission.Name = "Minimun";
            ColumnMinEmission.ReadOnly = true;
            ColumnMinEmission.Width = 125;
            // 
            // ColumnMaxEmission
            // 
            ColumnMaxEmission.HeaderText = "Maximum";
            ColumnMaxEmission.MinimumWidth = 6;
            ColumnMaxEmission.Name = "Maximum";
            ColumnMaxEmission.ReadOnly = true;
            ColumnMaxEmission.Width = 125;
            // 
            // ColumnAverageEmission
            // 
            ColumnAverageEmission.HeaderText = "Average";
            ColumnAverageEmission.MinimumWidth = 6;
            ColumnAverageEmission.Name = "Average";
            ColumnAverageEmission.ReadOnly = true;
            ColumnAverageEmission.Width = 125;

        }

        #endregion

        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnMinEmission;
        private DataGridViewTextBoxColumn ColumnMaxEmission;
        private DataGridViewTextBoxColumn ColumnAverageEmission;

    }
}