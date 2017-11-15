using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {

        
        

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
            OleDbCommand com = new OleDbCommand();
            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");

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

        

        private void Form1_Load(object sender, EventArgs e)
        {
            /* try
             {
                 OleDbCommand com = new OleDbCommand();
                 OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
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
             } */

            Conex c = new Conex();

            c.ItemLLenar(comInfo);
        }

        private void comInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            


            /* try
             {
                 OleDbCommand com = new OleDbCommand();
                 OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
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
             } */


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("update Cliente set Nombre= @nombre, Direccion= @direccion, Telefono= @telefono where Id = @id", con);

                cmd.Parameters.AddWithValue("@nombre", txt_nom.Text);
                cmd.Parameters.AddWithValue("@direccion", txt_direc.Text);
                cmd.Parameters.AddWithValue("@telefono", txt_tel.Text);
                //cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@id", lbl_con.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Completado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }


        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            string cadena = "Select * from Cliente where Nombre ='" + comInfo.Text + "' ";

            

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //MessageBox.Show("El registro se a encontrado");

                txt_nom.Text = leer["Nombre"].ToString();
                txt_direc.Text = leer["Direccion"].ToString();
                txt_tel.Text = leer["Telefono"].ToString();
                //txt_ID.Text = leer["Id"].ToString();
                lbl_con.Text = leer["Id"].ToString();

                //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

            }
            else
            {
                //MessageBox.Show("No se encontro");

                txt_nom.Text = "";
                txt_direc.Text = "";
                txt_tel.Text = "";
            }
            cnn.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
