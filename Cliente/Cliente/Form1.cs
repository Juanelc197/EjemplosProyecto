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
    public partial class Form1 : Form
    {

        OleDbConnection cnn;
        OleDbCommand com;
        OleDbDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            string connetionString = null;
            OleDbConnection cnn;
            connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb";
            cnn = new OleDbConnection(connetionString);

            com.CommandText = "insert into Cliente (Nombre, Direccion, Telefono) VALUES ('" + txt_nom.Text + "','" + txt_direc.Text + "','" + txt_tel.Text + "')";
            try
            {
                cnn.Open();
                MessageBox.Show("Conexion exitosa");
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexion");
            }
        }
    }
}
