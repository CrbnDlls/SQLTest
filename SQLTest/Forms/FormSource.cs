using SQLTest.Models;
using SQLTest.Repositories;

namespace SQLTest.Forms
{
    public partial class FormSource : FormCRUD<Source>
    {
        public FormSource() : base(new SourceRepository())
        {
            InitializeComponent();
        }

        protected override async Task FillDataGrid()
        {
            await base.FillDataGrid();

            int i = 1;
            
            foreach (var source in Items)
            {
                try
                {
                    decimal? test = source.Emissions?.Min(x => x.Count);
                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                }
                dataGridView1.Rows.Add(source.IdSource, 
                                       i++, 
                                       source.Name, 
                                       source.Address, 
                                       source.Emissions?.Count > 0 ? source.Emissions.Min(x=> x.Count) : 0,
                                       source.Emissions?.Count > 0 ? source.Emissions.Max(x => x.Count) : 0,
                                       source.Emissions?.Count > 0 ? source.Emissions.Average(x=> x.Count) : 0);
            }
        }

        protected override void FillSaveList()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (!int.TryParse(dataGridView1.Rows[j].Cells[1].Value.ToString(), out int serial))
                {
                    Source source;
                    try
                    {
                        source = new Source()
                        {
                            Name = dataGridView1.Rows[j].Cells["Name"].Value?.ToString(),
                            Address = dataGridView1.Rows[j].Cells["Address"].Value?.ToString()
                        };
                        StatusList.Status.Add("Ok");
                    } 
                    catch (Exception ex) 
                    {
                        source = new Source();
                        StatusList.Status.Add("error");
                    }
                    StatusList.ItemsToSave.Add(source);
                    StatusList.RowIndex.Add(j);
                }
            }
        }
    }
}
