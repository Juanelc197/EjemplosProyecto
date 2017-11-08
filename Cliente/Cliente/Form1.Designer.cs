namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_vista = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_direc = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_tele = new System.Windows.Forms.Label();
            this.lbl_direc = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(146, 25);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_vista
            // 
            this.btn_vista.Location = new System.Drawing.Point(293, 186);
            this.btn_vista.Name = "btn_vista";
            this.btn_vista.Size = new System.Drawing.Size(67, 25);
            this.btn_vista.TabIndex = 20;
            this.btn_vista.Text = "Ver datos";
            this.btn_vista.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(9, 9);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(54, 13);
            this.Buscar.TabIndex = 18;
            this.Buscar.Text = "busqueda";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(218, 186);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(56, 26);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(64, 183);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(114, 20);
            this.txt_tel.TabIndex = 16;
            // 
            // txt_direc
            // 
            this.txt_direc.Location = new System.Drawing.Point(67, 135);
            this.txt_direc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.Size = new System.Drawing.Size(111, 20);
            this.txt_direc.TabIndex = 15;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(59, 86);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(119, 20);
            this.txt_nom.TabIndex = 14;
            // 
            // lbl_tele
            // 
            this.lbl_tele.AutoSize = true;
            this.lbl_tele.Location = new System.Drawing.Point(8, 186);
            this.lbl_tele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tele.Name = "lbl_tele";
            this.lbl_tele.Size = new System.Drawing.Size(52, 13);
            this.lbl_tele.TabIndex = 13;
            this.lbl_tele.Text = "Telefono:";
            // 
            // lbl_direc
            // 
            this.lbl_direc.AutoSize = true;
            this.lbl_direc.Location = new System.Drawing.Point(8, 138);
            this.lbl_direc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_direc.Name = "lbl_direc";
            this.lbl_direc.Size = new System.Drawing.Size(55, 13);
            this.lbl_direc.TabIndex = 12;
            this.lbl_direc.Text = "Direccion:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(8, 89);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(47, 13);
            this.lbl_nom.TabIndex = 11;
            this.lbl_nom.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 227);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_vista);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_direc);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_tele);
            this.Controls.Add(this.lbl_direc);
            this.Controls.Add(this.lbl_nom);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_vista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_direc;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_tele;
        private System.Windows.Forms.Label lbl_direc;
        private System.Windows.Forms.Label lbl_nom;
    }
}

