using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Schedule
{
    public partial class FormSchedule : Form
    {
        string filename = "schedule.txt";

        public FormSchedule()
        {
            InitializeComponent();
            load_grid();
        }

        public void load_grid()
        {
            grid_week.Rows.Clear();
            StreamReader txt = new StreamReader(filename, Encoding.UTF8);
            int row_index = 0;
            while(!txt.EndOfStream)
            {
                grid_week.Rows.Add();
                foreach (DataGridViewColumn col in grid_week.Columns)
                {
                    if (txt.EndOfStream)
                        break;
                    string item = txt.ReadLine();
                    grid_week[col.Index, row_index].Value = item;
                }
                row_index++;
            }
            txt.Close();
        }

        public void save_grid()
        {
            StreamWriter txt = new StreamWriter (filename, false, Encoding.UTF8);
            foreach(DataGridViewRow row in grid_week.Rows)
            {
                if (row.Index == grid_week.Rows.Count - 1)
                    break;
                foreach(DataGridViewColumn col in grid_week.Columns)
                {
                    string item;
                    if (grid_week[col.Index, row.Index].Value == null)
                        item = "";
                    else
                        item = grid_week[col.Index, row.Index].Value.ToString();
                    txt.WriteLine(item);
                }
            }
            txt.Close();
        }

        private void grid_week_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            save_grid();
        }
    }
}
