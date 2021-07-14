using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEx
{
    public partial class AddForm : Form
    {
        DataGridView parentDGV; // для добавления в datagridview1
        public AddForm(DataGridView dgv)
        {
            parentDGV = dgv; // для добавления в datagridview1
            InitializeComponent();
            
        }

        private void AF_UndoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AF_SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(parentDGV.CurrentCell.Value) == In_ID)
                {
                    MessageBox.Show("ID должен быть уникален", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    
                    parentDGV.Rows.Add(In_ID, In_DateCreate, In_Name, In_Country);
                }

                using (MainDataContext db = new MainDataContext()) 
                {
                    Project project = new Project { ID = In_ID, DateCreate = In_DateCreate, Name = In_Name, ProjectCountry = In_Country };
                    db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Projects ON INSERT INTO Projects (ID, DateCreate, Name, ProjectCountry) VALUES (" + project.ID.ToString() + ", '" + project.DateCreate + "', '" + project.Name + "', '"  + project.ProjectCountry + "');");
                    //parentDGV.Rows.Add(In_ID, In_DateCreate, In_Name, In_Country);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public int In_ID
        {
            get
            {
                return Convert.ToInt32(ID_textbox.Text);
            }
        } // получение значений из текстбоксов в свойства (In = Input)

        public string In_DateCreate
        {
            get
            {
                return DC_textBox.Text.ToString();
            }
        }
        public string In_Name
        {
            get
            {
                return Name_textBox.Text.ToString();
            }
        }
        public string In_Country
        {
            get
            {
                return Country_textBox.Text.ToString();
            }
        }
        
    }
}
