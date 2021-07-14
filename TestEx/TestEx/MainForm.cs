using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestEx
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        

        private void Main_Edit_Click(object sender, EventArgs e)
        {
            
        }
        

        
        private void Main_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(dataGridView1);
            addForm.ShowDialog();
        }

        private void Main_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int c = dataGridView1.SelectedCells[0].RowIndex;
            
                using (MainDataContext db = new MainDataContext())
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedIndex = dataGridView1.SelectedRows[0].Index;

                        int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                        string sql = "DELETE FROM Projects WHERE id = '" + rowID + "';";

                        db.Database.ExecuteSqlCommand(sql);
                        db.SaveChanges();
                        dataGridView1.Rows.RemoveAt(c);

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        


        private void MainForm_Load(object sender, EventArgs e)
        {
            using(MainDataContext db = new MainDataContext())
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ID", HeaderText = "ID", Width = 20 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DateCreate", HeaderText = "Дата создания", Width = 150 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Название", Width = 300 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ProjectCountry", HeaderText = "Страна", Width = 150 });
                db.SaveChanges();


                var prjcts = db.Projects; 
                foreach (Project p in prjcts)
                {
                    dataGridView1.Rows.Add(p.ID, p.DateCreate, p.Name, p.ProjectCountry); // отображение содержимого SQLite-базы в dgv1
                }

            }
        }





        

        private void Main_AddCountry_Click(object sender, EventArgs e)
        {
           


            
        }

        
    }
}
