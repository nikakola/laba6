using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba6
{

    public partial class Form2 : Form
    {
        DataTable dataTable = new DataTable();
        string connectionString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\veronika\\Desktop\\laba6\\laba6\\bin\\Debug;Extended Properties='text;HDR=Yes;FMT=Delimited'";
        public Form2()
        {
            InitializeComponent();
            getColumns();
            getValues();
            getV();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void columnsSecond_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void getColumns()
        {
            columnsFirst.Items.Clear();
            try
            {
                columnsFirst.Items.Add("*");
                columnsFirst.Items.Add("student_id");
                columnsFirst.Items.Add("Subject");
                columnsFirst.Items.Add("Mark");
                columnsFirst.Items.Add("Name");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getV()
        {
            
            try
            {
                col1.Items.Add("id");
                col1.Items.Add("Subject");
                col1.Items.Add("Mark");
                col1.Items.Add("student_id");
                col1.Items.Add("Name");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void getValues()
        {
            
            try
            {
                
                using (OleDbConnection connection = new OleDbConnection(connectionString2))
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [combinedData.txt]", connection);
                    adapter.Fill(dataTable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void columnsFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void col1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            val1.Items.Clear();
            int selectedColumn = col1.SelectedIndex;
            foreach (DataRow row in dataTable.Rows)
            {
                val1.Items.Add(row[selectedColumn].ToString());
            }
        }

        private void val1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void execute1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedValues = new List<string>();
                foreach (object item in columnsFirst.CheckedItems)
                {
                    selectedValues.Add(item.ToString());
                }

                string selectedValuesString = string.Join(", ", selectedValues);
                string selectedValue = col1.SelectedItem.ToString();
                string selectedValue2 = val1.SelectedItem.ToString();
                OleDbConnection connection = new OleDbConnection(connectionString2);
                string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + selectedValue2;
                textBox1.Text = Select2;
                OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);

              
                DataSet ds = new DataSet();
                connection.Open();
                adapter2.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                
            
                connection.Close();
            }
            catch (Exception ex)
            {
                OleDbConnection connection = new OleDbConnection(connectionString2);
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void execute2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
