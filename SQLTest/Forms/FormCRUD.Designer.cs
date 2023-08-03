using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SQLTest.Forms
{
    partial class FormCRUD<T>
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonRefresh = new Button();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnSerial = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnSerial });
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ColumnSerial
            // 
            ColumnSerial.HeaderText = "№";
            ColumnSerial.MinimumWidth = 6;
            ColumnSerial.Name = "ColumnSerial";
            ColumnSerial.ReadOnly = true;
            ColumnSerial.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonRefresh, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonDelete, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(794, 399);
            dataGridView1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Dock = DockStyle.Fill;
            buttonRefresh.Location = new Point(3, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(394, 39);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(3, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(394, 39);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(394, 39);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Location = new Point(403, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(394, 39);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormCategories";
            Text = "FormCategories";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        protected DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonRefresh;
        private Button buttonDelete;
        private Button buttonSave;
        private DataGridViewTextBoxColumn ColumnSerial;
        private DataGridViewTextBoxColumn ColumnProductsCount;
        private DataGridViewTextBoxColumn ColumnId;
    }
}