using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;


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
            }
            catch (Exception ex)
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

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            PdF();
        }

        private void PdF()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {

            FileStream file = new FileStream(filename,
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite,
            FileShare.ReadWrite);
            PdfWriter.GetInstance(doc, file);
            doc.Open();
            string remito = "Autorizo: Juanelc197";
            string envio = "Fecha:" + DateTime.Now.ToString();

            Chunk chunk = new Chunk("Reporte de General Usuarios", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
            doc.Add(new Paragraph(chunk));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("N.L"));
            doc.Add(new Paragraph(remito));
            doc.Add(new Paragraph(envio));
            doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            GenerarDocumento(doc);
            doc.AddCreationDate();
            doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
            doc.Add(new Paragraph("Firma", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
            doc.Close();
            Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
        }
    }

    public void GenerarDocumento(Document document)
    {
        int i, j;
        PdfPTable datatable = new PdfPTable(dataMuestraD.ColumnCount);
        datatable.DefaultCell.Padding = 3;
        float[] headerwidths = GetTamañoColumnas(dataMuestraD);
        datatable.SetWidths(headerwidths);
        datatable.WidthPercentage = 100;
        datatable.DefaultCell.BorderWidth = 2;
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
        for (i = 0; i < dataMuestraD.ColumnCount; i++)
        {
            datatable.AddCell(dataMuestraD.Columns[i].HeaderText);
        }
        datatable.HeaderRows = 1;
        datatable.DefaultCell.BorderWidth = 1;
        for (i = 0; i < dataMuestraD.Rows.Count; i++)
        {
            for (j = 0; j < dataMuestraD.Columns.Count; j++)
            {
                if (dataMuestraD[j, i].Value != null)
                {
                    datatable.AddCell(new Phrase(dataMuestraD[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                }
            }
            datatable.CompleteRow();
        }
        document.Add(datatable);
    }

    public float[] GetTamañoColumnas(DataGridView dg)
    {
        float[] values = new float[dg.ColumnCount];
        for (int i = 0; i < dg.ColumnCount; i++)
        {
            values[i] = (float)dg.Columns[i].Width;
        }
        return values;
    }
      
 

    }
}
