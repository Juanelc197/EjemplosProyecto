using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cliente
{
    class Conex
    {
        OleDbConnection cnn;
        OleDbCommand com;
        OleDbDataReader dr;

        public Conex()
        {
            try
            {
                cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
                cnn.Open();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
        }

        public void ItemLLenar(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select Nombre from Cliente", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                //cb.SelectedIndex = 0;
                dr.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno correctamente: " + ex.ToString());
            }
        }
    }
}
