using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form2 : Form
    {

        OleDbDataReader dr;
        OleDbCommand com = new OleDbCommand();
        //OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Juanelc197\\Desktop\\EjemProyec.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_verRe_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
                com.Connection = cnn;
                cnn.Open();
                string query = "select Nombre, Direccion, Telefono from Cliente";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataMuestraD.DataSource = dt;

                com.Clone();
            } catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());
            }

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* com.Connection = cnn;
            cnn.Open();
            string query = "select Id from Cliente";
            com.CommandText = query;

            OleDbDataReader leer = com.ExecuteReader();
            while (leer.Read())
            {

            } */
        }
    }
}
