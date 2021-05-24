using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using NLog;
namespace DZ
{
    public partial class Form1 : Form
    {
       // static Logger Logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
          SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
            con.Open();
            string query = "Select * from Author";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
            con.Open();
            string query = "Select * from Confirience";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
            con.Open();
            string query = "Select * from Hotel";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
                con.Open();
                string sql = "insert into Author" + " values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                cmd.ExecuteNonQuery();
             
                MessageBox.Show("INSERT ok");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //del
        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
            con.Open();
            string sqldel = "delete from Author where ID_Author ='"+textBox6.Text+"' ";
            SQLiteCommand cmd = new SQLiteCommand(sqldel, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("delete ok");
        }
        //update
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
                con.Open();
                string update = "update  Author set LastName = '" + textBox1.Text + "', Adress= '" + textBox2.Text + "',Number='" + textBox3.Text + "',ScienceStatus='" + textBox4.Text + "',ScienceLevel='" + textBox5.Text + "' where ID_Author = '" + textBox6.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(update, con);
               
                cmd.ExecuteNonQuery();

                MessageBox.Show("Update ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        public void MinAge()
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
            con.Open();
            string sqlExpression = "SELECT COUNT(*) FROM Author";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, con);

            command.CommandText = "SELECT MIN(ID_Author) FROM Author";  
            object minAge = command.ExecuteScalar();

            textBox8.Text = Convert.ToString(minAge);
        }
        public void AvgAge()
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\\Users\\proba\\OneDrive\\Desktop\\modul2OBD.db");
            con.Open();
            string sqlExpression = "SELECT COUNT(*) FROM Author";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, con);

            command.CommandText = "SELECT AVG(ID_Author)FROM Author";
            object AvgAge = command.ExecuteScalar();

            textBox7.Text = Convert.ToString(AvgAge);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MinAge();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AvgAge();
        }
    }            
}
