using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GaduGaduGadu
{
    public partial class GaduForm : Form
    {
        public GaduForm()
        {
            InitializeComponent();
        }


        string connectionString = @"Data Source=KOMP180\LAB1;Initial Catalog=IXI;"
            + "Integrated Security=true";
        string queryReaderString =
            "SELECT DISTINCT Rodzaj FROM Ubrania;";

        public void Reader_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection =
                           new SqlConnection(connectionString))
                {
                    SqlCommand command =
                        new SqlCommand(queryReaderString, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    //comboBox1.Items.Clear();
                    //while (reader.Read())
                    //    comboBox1.Items.Add(reader[0].ToString());
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                debugTextBox.Text = ex.StackTrace + "\n@@@\n" + ex.ToString();
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            debugTextBox.Text = e.ToString();
        }
        private void textBoxInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && !e.Shift && textBoxInput.Text.Length > 0)
            {
                textBoxChat.AppendText(textBoxInput.Text + "\n");
                textBoxInput.Clear();
                textBoxInput.ClearUndo();
                textBoxChat.ScrollToCaret();
            }
        }
    }
}
