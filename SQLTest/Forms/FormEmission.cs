using SQLTest.Models;
using SQLTest.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest.Forms
{
    public partial class FormEmission : FormCRUD<Emission>
    {
        public FormEmission() : base(new EmissionRepository())
        {
            InitializeComponent();
        }

        protected override async Task FillDataGrid()
        {
            await base.FillDataGrid();

            ColumnSource?.Items.Clear();

            foreach (var source in await (_repository as EmissionRepository).GetSources())
            {
                ColumnSource.Items.Add(source);
            }

            ColumnSource.DisplayMember = "Name";
            ColumnSource.ValueMember = "IdSource";

            int i = 1;
            foreach (var emission in Items)
            {
                dataGridView1.Rows.Add(emission.IdEmission, i++, emission.IdSource, emission.Count, emission.Text, emission.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            }
        }

        protected override void FillSaveList()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (!int.TryParse(dataGridView1.Rows[j].Cells[1].Value.ToString(), out int serial))
                {
                    Emission emission;
                    try
                    {
                        emission = new Emission()
                        {
                            IdSource = (int)dataGridView1.Rows[j].Cells["Source"].Value,
                            Count = Convert.ToDecimal(dataGridView1.Rows[j].Cells["Count"].Value),
                            Text = dataGridView1.Rows[j].Cells["Text"].Value?.ToString(),
                            Date = DateTime.Parse(dataGridView1.Rows[j].Cells["Date"].Value.ToString(), CultureInfo.InvariantCulture)
                        };
                        StatusList.Status.Add("Ok");
                    }
                    catch (Exception ex)
                    {
                        emission = new Emission();
                        StatusList.Status.Add("error");
                    }
                    StatusList.ItemsToSave.Add(emission);
                    StatusList.RowIndex.Add(j);
                }
            }
        }
    }
}
