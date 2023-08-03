using Microsoft.EntityFrameworkCore;
using SQLTest.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest.Forms
{
    public partial class FormCRUD<T> : Form
    {
        protected IBaseRepository<T> _repository;

        protected StatusList<T> StatusList;

        protected IEnumerable<T> Items;

        public FormCRUD(IBaseRepository<T> repository)
        {
            InitializeComponent();

            StatusList = new StatusList<T>();

            _repository = repository;

            FillDataGrid();
        }

        protected virtual async Task FillDataGrid()
        {
            dataGridView1.Rows.Clear();

            Items = await _repository.GetAll();
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Add("new","new");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("To delete record press \"Ok\" button", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "new")
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                else
                {
                    try
                    {
                        _repository.Delete((int)dataGridView1.CurrentRow.Cells[0].Value);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Unable to delete record", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            FillSaveList();

            await SaveEntries();

            UpdateDataGrid();
        }
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "new")
            {
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = "edited";
            }
        }

        private void UpdateDataGrid()
        {
            for (int i = 0; i < StatusList.ItemsToSave.Count; i++)
            {
                if (StatusList.Status[i] != "error")
                {
                    dataGridView1.Rows[StatusList.RowIndex[i]].Cells[0].Value = StatusList.Id[i];
                    dataGridView1.Rows[StatusList.RowIndex[i]].Cells[1].Value = StatusList.RowIndex[i] + 1;
                }
                else
                {
                    dataGridView1.Rows[StatusList.RowIndex[i]].Cells[1].Value = StatusList.Status[i];
                }
            }
            StatusList.Clear();
        }

        protected virtual void FillSaveList()
        {
            //Should be filled in derived class
            throw new NotImplementedException();
        }

        private async Task SaveEntries()
        {
            foreach (var entry in StatusList)
            {
                if (entry.Item1 == "Ok")
                {
                    try
                    {
                        StatusList.Id.Add(await _repository.SaveItem(entry.Item2));
                    }
                    catch (DbUpdateException ex)
                    {
                        StatusList.Id.Add(0);
                        StatusList.Status[StatusList.Index] = "error";
                    }
                }
            }

        }
        
    }
}
