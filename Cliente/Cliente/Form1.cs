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

        //OleDbConnection cnn;
        //OleDbCommand com;
        OleDbDataReader dr;
        OleDbCommand com = new OleDbCommand();
        OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //OleDbCommand com = new OleDbCommand();
            //string connetionString = null;
            //OleDbConnection cnn;
            //connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb";
            //cnn = new OleDbConnection(connetionString);

            //com.CommandText = "insert into Cliente (Nombre, Direccion, Telefono) VALUES ('" + txt_nom.Text + "','" + txt_direc.Text + "','" + txt_tel.Text +

            com.CommandText = "insert into Cliente (Nombre, Direccion, Telefono) VALUES ('" + txt_nom.Text + "','" + txt_direc.Text + "','" + txt_tel.Text + "')";
            com.Connection = cnn;
            cnn.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Conexion exitosa");
            //cnn.Close();

            
        }

        private void btn_vista_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            /* string cadena = "Select * from Cliente where Nombre='" + txt_busqueda.Text + "' ";

            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() ==true)
            {
                MessageBox.Show("El registro se a encontrado");
            } else
            {
                MessageBox.Show("No se encontro");
            }
            cnn.Close(); */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                com.Connection = cnn;
                cnn.Open();
                string query = "select Id from Cliente";
                com.CommandText = query;

                OleDbDataReader leer = com.ExecuteReader();
                while (leer.Read())
                {
                    comInfo.Items.Add(leer["Id"].ToString());
                }
                com.Clone();
            } catch (Exception ex)
            {
                MessageBox.Show("No se lleno" + ex.ToString());
            }
            

        }

        private void comInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                com.Connection = cnn;
                cnn.Open();

                string query = "select Nombre, Direccion, Telefono from Cliente where Id'" + comInfo.Text + "'";
                com.CommandText = query;

                OleDbDataReader leer = com.ExecuteReader();
                while (leer.Read())
                {
                    txt_nom.Text = leer["Nombre"].ToString();
                    txt_direc.Text = leer["Direccion"].ToString();
                    txt_tel.Text = leer["Telefono"].ToString();
                }
                com.Clone();
            } catch (Exception ex)
            {
                MessageBox.Show("No se encontro" + ex.ToString());
            }
        }
    }
}
