using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _20211130
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; set; }
        public Form1()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = palyazatok";
            InitializeComponent();
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand("SELECT * FROM palyazat;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgv.Rows.Add(
               /*id*/         reader.GetInt32(0),
               /*tervezetA*/  reader.GetInt32(1),

               /*tervezetC*/  reader.GetInt32(3));
              /*  dgv.Sort(id); */

               
            }
            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnujpalyazat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUjpalyazat f2 = new FormUjpalyazat();
            f2.ShowDialog();
        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
