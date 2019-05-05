using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        IList<Employee> employees;
        public static int _Id { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee()
            {
                Id = ++_Id,
                Name = name_txt.Text,
                Surname = surname_txt.Text,
                Email = email_txt.Text,
                Position = vezife_txt.Text,
                Salary = Convert.ToDecimal(maash_txt.Text)
            };
            employees.Add(employee);
            SetData(employees);
            //name_txt.Text = "";
            //surname_txt.Text = "";
            //email_txt.Text = "";
            //vezife_txt.Text = "";
            //maash_txt.Text = "";
           
        }
        
        private void SetData(IEnumerable<Employee> employees)
        {

            DataGridView1.DataSource = null;
            DataGridView1.DataSource = employees;
            DataGridView1.Columns["Id"].Visible = false;
            DataGridView1.Columns["Name"].DisplayIndex = 0;
            DataGridView1.Columns["Surname"].DisplayIndex = 1;
            DataGridView1.Columns["Email"].DisplayIndex = 2;
            DataGridView1.Columns["Position"].DisplayIndex = 3;
            DataGridView1.Columns["Salary"].DisplayIndex = 4;
        }

        int selectedRow;


        private void DataGridView1_CellClick(object sender , DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = DataGridView1.Rows[selectedRow];

            name_txt.Text = row.Cells["Name"].Value.ToString();
            surname_txt.Text = row.Cells["Surname"].Value.ToString();
            email_txt.Text = row.Cells["Email"].Value.ToString();
            vezife_txt.Text = row.Cells["Position"].Value.ToString();
            maash_txt.Text = row.Cells["Salary"].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int rowIndex = DataGridView1.CurrentCell.RowIndex;
            DataGridView1.Rows.RemoveAt(rowIndex);
        }
    }

}
