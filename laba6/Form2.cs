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
        string connectionString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\laba6\\laba6\\bin\\Debug;Extended Properties='text;HDR=Yes;FMT=Delimited'";
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
                columnsSecond.Items.Add("*");
                columnsSecond.Items.Add("student_id");
                columnsSecond.Items.Add("Subject");
                columnsSecond.Items.Add("Mark");
                columnsSecond.Items.Add("Name");
                columnsThird.Items.Add("*");
                columnsThird.Items.Add("student_id");
                columnsThird.Items.Add("Subject");
                columnsThird.Items.Add("Mark");
                columnsThird.Items.Add("Name");


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
                col2.Items.Add("id");
                col2.Items.Add("Subject");
                col2.Items.Add("Mark");
                col2.Items.Add("student_id");
                col2.Items.Add("Name");
                col3.Items.Add("id");
                col3.Items.Add("Subject");
                col3.Items.Add("Mark");
                col3.Items.Add("student_id");
                col3.Items.Add("Name");
                col4.Items.Add("id");
                col4.Items.Add("Subject");
                col4.Items.Add("Mark");
                col4.Items.Add("student_id");
                col4.Items.Add("Name");


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
            Object selectedItem = col1.SelectedItem;

            OleDbConnection connection = new OleDbConnection(connectionString2);
            string Select2 = "SELECT DISTINCT " + selectedItem.ToString() + " FROM [combinedData.txt]";
            //textBox1.Text = Select2;
            OleDbCommand comand2 = new OleDbCommand(Select2, connection);

            OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);
            DataSet d = new DataSet();
            connection.Open();
            adapter2.Fill(d);
            foreach (DataRow row in d.Tables[0].Rows)
            {
                val1.Items.Add(row[selectedItem.ToString()].ToString());
            }

            connection.Close();
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    val1.Items.Add(row[selectedColumn].ToString());
            //}
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
                if (selectedValue == "Subject" || selectedValue == "Name")
                { 
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + "\"" + selectedValue2 + "\"";
                   // textBox1.Text = Select2;
                    OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);


                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter2.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];


                    connection.Close();
                }
                else 
                {
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + selectedValue2;
                       // textBox1.Text = Select2;
                    OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);


                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter2.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];


                    connection.Close();
                }
               
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

            try
            {
                List<string> selectedValues = new List<string>();
                foreach (object item in columnsSecond.CheckedItems)
                {
                    selectedValues.Add(item.ToString());
                }

                string selectedValuesString = string.Join(", ", selectedValues);
                string selectedValue = col2.SelectedItem.ToString();
                string selectedValue2 = val2.SelectedItem.ToString();
                string selectedValue3 = col3.SelectedItem.ToString();
                string selectedValue4 = val3.SelectedItem.ToString();
                OleDbConnection connection = new OleDbConnection(connectionString2);
                if (selectedValue == "Subject" || selectedValue == "Name")
                {
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + "\"" + selectedValue2 + "\"" + " AND " + selectedValue3 + "=" + selectedValue4;
                  //  textBox1.Text = Select2;
                    OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);


                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter2.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];


                    connection.Close();
                }
                else if (selectedValue3 == "Subject" || selectedValue3 == "Name")
                {
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + selectedValue2  + " AND " + selectedValue3 + "=" + "\"" + selectedValue4 + "\"";
                 //   textBox1.Text = Select2;
                    OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);


                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter2.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];


                    connection.Close();
                }
                else if ((selectedValue3 == "Subject" || selectedValue3 == "Name") && (selectedValue == "Subject" || selectedValue == "Name"))
                {
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + "\"" + selectedValue2 + "\""+ " AND " + selectedValue3 + "=" + "\"" + selectedValue4 + "\"";
                 //   textBox1.Text = Select2;
                    OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);


                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter2.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];


                    connection.Close();
                }
                else
                {
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + "=" + selectedValue2 + " AND " + selectedValue3 + "=" + selectedValue4;
                  //  textBox1.Text = Select2;
                    OleDbCommand comand2 = new OleDbCommand(Select2, connection);

                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);


                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter2.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];


                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                OleDbConnection connection = new OleDbConnection(connectionString2);
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void val2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void col2_SelectedIndexChanged(object sender, EventArgs e)
        {
            val2.Items.Clear();
            int selectedColumn = col2.SelectedIndex;
            Object selectedItem = col2.SelectedItem;

            OleDbConnection connection = new OleDbConnection(connectionString2);
            string Select2 = "SELECT DISTINCT " + selectedItem.ToString() + " FROM [combinedData.txt]";
            //textBox1.Text = Select2;
            OleDbCommand comand2 = new OleDbCommand(Select2, connection);

            OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);
            DataSet d = new DataSet();
            connection.Open();
            adapter2.Fill(d);
            foreach (DataRow row in d.Tables[0].Rows)
            {
                val2.Items.Add(row[selectedItem.ToString()].ToString());
            }

            connection.Close();
        }

        private void col3_SelectedIndexChanged(object sender, EventArgs e)
        {
            val3.Items.Clear();
            int selectedColumn = col3.SelectedIndex;
            Object selectedItem = col3.SelectedItem;

            OleDbConnection connection = new OleDbConnection(connectionString2);
            string Select2 = "SELECT DISTINCT " + selectedItem.ToString() + " FROM [combinedData.txt]";
           // textBox1.Text = Select2;
            OleDbCommand comand2 = new OleDbCommand(Select2, connection);

            OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);
            DataSet d = new DataSet();
            connection.Open();
            adapter2.Fill(d);
            foreach (DataRow row in d.Tables[0].Rows)
            {
                val3.Items.Add(row[selectedItem.ToString()].ToString());
            }

            connection.Close();
        }

        private void val3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void columnsThird_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void col4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pattern_TextChanged(object sender, EventArgs e)
        {

        }

        private void execute3_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedValues = new List<string>();
                foreach (object item in columnsThird.CheckedItems)
                {
                    selectedValues.Add(item.ToString());
                }

                string selectedValuesString = string.Join(", ", selectedValues);
                string selectedValue = col4.SelectedItem.ToString();
                string selectedValue2 = pattern.Text.ToString();
                OleDbConnection connection = new OleDbConnection(connectionString2);
                
                    string Select2 = "SELECT " + selectedValuesString + " FROM [combinedData.txt] WHERE " + selectedValue + " LIKE " + "\'" + selectedValue2 + "\'";
                   // textBox1.Text = Select2;
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
    }
}
