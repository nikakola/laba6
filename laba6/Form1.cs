using ADOX;
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
    public partial class Form1 : Form
    {
        string connectionString1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\;Extended Properties='text;HDR=Yes;FMT=Delimited'";
        string connectionString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\laba6\\laba6\\bin\\Debug;Extended Properties='text;HDR=Yes;FMT=Delimited'";
        //OleDbConnection StrCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\;Extended Properties='Text;HDR=Yes;FMT=Delimited;IMEX=1';Persist Security Info=False");
        public Form1()
        {
            InitializeComponent();
        }

      
     
        

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Connection strings for the two text files
               

                // Create a DataSet to store the data from the two text files
                DataSet dataSet = new DataSet();

                // Read data from the first text file
                using (OleDbConnection connection = new OleDbConnection(connectionString1))
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [student.txt]", connection);
                    adapter.Fill(dataSet, "Table1");
                }

                // Read data from the second text file
                using (OleDbConnection connection = new OleDbConnection(connectionString1))
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [student2.txt]", connection);
                    adapter.Fill(dataSet, "Table2");
                }


                
                DataTable combinedData = dataSet.Tables["Table2"].Clone();
                combinedData.Columns.Add();
                combinedData.Columns.Add();
                combinedData.Rows.Add("id", "Subject", "Mark", "student_id", "Name");

                // Join the data from both tables on the ID column
                var query = from t2 in dataSet.Tables["Table2"].AsEnumerable()
                            join t1 in dataSet.Tables["Table1"].AsEnumerable()
                            on t2.Field<string>("id") equals t1.Field<string>("id") into joined
                            from j in joined.DefaultIfEmpty()
                            select t2.ItemArray.Concat(j == null ? Enumerable.Repeat<object>(DBNull.Value, dataSet.Tables["Table2"].Columns.Count) : j.ItemArray).ToArray();

         
                // Copy the results of the join into the result table
                foreach (var row in query)
                {
                    combinedData.Rows.Add(row);
                }

                // Write the combined data to a new text file
                using (StreamWriter writer = new StreamWriter("combinedData.txt"))
                {
                    foreach (DataRow row in combinedData.Rows)
                    {
                        writer.WriteLine(string.Join(",", row.ItemArray));
                    }
                }
                string Select1 = "SELECT * FROM [combinedData.txt]";
                OleDbConnection StrCon = new OleDbConnection(connectionString2);
                OleDbCommand comand1 = new OleDbCommand(Select1, StrCon);

                //Определяем объект Adapter для взаимодействия с источником данных
                OleDbDataAdapter adapter1 = new OleDbDataAdapter(comand1);


                //Определяем объект DataSet
                DataSet AllTables = new DataSet();
                //Открываем подключение
                StrCon.Open();
                //Заполняем DataSet таблицей из источника данных
                adapter1.Fill(AllTables);

                //Заполняем обект datagridview для отображения данных на форме
                dataGridView1.DataSource = AllTables.Tables[0];
                StrCon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(1);
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        OleDbConnection connection = new OleDbConnection(connectionString2);
        //        string Select2 = textBox1.Text;
        //        OleDbCommand comand2 = new OleDbCommand(Select2, connection);

        //        OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);

        //        DataSet AllTables = new DataSet();
        //        connection.Open();

        //        adapter2.Fill(AllTables);

        //        dataGridView1.DataSource = AllTables.Tables[0];
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        OleDbConnection connection = new OleDbConnection(connectionString2);
        //        connection.Close();
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        public void ShowData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
