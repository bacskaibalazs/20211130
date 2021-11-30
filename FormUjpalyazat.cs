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
    public partial class FormUjpalyazat : Form
    {
        public FormUjpalyazat()
        {
            InitializeComponent();
        }

        public string ConnectionString { get; set; }
        /*
        private void btnujhirdetes_Click(object sender, EventArgs e)
        {
            int keretosszeg = tbA.Text;
            int szamlakosszege = int.TryParse(tbC.Text);

            var connection = new SqlConnection(ConnectionString);

            try
            {
                string errorMessage = "";
                if (!int.TryParse(tbA.Text, out _)) errorMessage += "nem számot adott meg!\n";
                if (!int.TryParse(tbC.Text, out _)) errorMessage += "nem számot adott meg!\n";
                if (int.TryParse((tbA) < 0) errorMessage += "nem adhat meg negatív számot!\n";
                if (int.TryParse((tbC) < 0) errorMessage += "nem adhat meg negatív számot!\n";

                connection.Open();

                var command = new SqlCommand(
                    "INSERT INTO palyazat VALUES " + $"('{tervezetA}' , '{tervezetC}');", connection);

                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = command,
                };
                adapter.InsertCommand.ExecuteNonQuery();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            finally
            {
                connection.Close();
            }

        }
        */

        private void FormUjpalyazat_Load(object sender, EventArgs e)
        {

        }
    }
}
