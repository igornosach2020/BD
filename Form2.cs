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

namespace DZ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            string login = Convert.ToString(textBox1);
            string parol = Convert.ToString(textBox2);

           if(textBox1.Text != null && textBox2.Text!=null)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
        }
    }
}
