using SQLTest.Models;

namespace SQLTest.Forms
{
    partial class FormEmission
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
            this.Text = "FormEmission";
            ColumnSource = new DataGridViewComboBoxColumn();
            ColumnCount = new DataGridViewTextBoxColumn();
            ColumnText = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Insert(2, ColumnDate);
            dataGridView1.Columns.Insert(2, ColumnText);
            dataGridView1.Columns.Insert(2, ColumnCount);
            dataGridView1.Columns.Insert(2, ColumnSource);

            // 
            // ColumnName
            // 
            ColumnSource.HeaderText = "Emission";
            ColumnSource.MinimumWidth = 6;
            ColumnSource.Name = "Source";
            ColumnSource.Width = 125;
            // 
            // ColumnPrice
            // 
            ColumnCount.HeaderText = "Quantity";
            ColumnCount.MinimumWidth = 6;
            ColumnCount.Name = "Count";
            ColumnCount.Width = 125;
            // 
            // ColumnPrice
            // 
            ColumnText.HeaderText = "Comment";
            ColumnText.MinimumWidth = 6;
            ColumnText.Name = "Text";
            ColumnText.Width = 125;
            // 
            // ColumnPrice
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 6;
            ColumnDate.Name = "Date";
            ColumnDate.Width = 125;

        }

        #endregion

        private DataGridViewComboBoxColumn ColumnSource;
        private DataGridViewTextBoxColumn ColumnCount;
        private DataGridViewTextBoxColumn ColumnText;
        private DataGridViewTextBoxColumn ColumnDate;
    }
}