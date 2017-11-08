namespace Cliente
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataMuestraD = new System.Windows.Forms.DataGridView();
            this.btn_verRe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMuestraD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMuestraD
            // 
            this.dataMuestraD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMuestraD.Location = new System.Drawing.Point(12, 12);
            this.dataMuestraD.Name = "dataMuestraD";
            this.dataMuestraD.Size = new System.Drawing.Size(515, 150);
            this.dataMuestraD.TabIndex = 0;
            // 
            // btn_verRe
            // 
            this.btn_verRe.Location = new System.Drawing.Point(13, 183);
            this.btn_verRe.Name = "btn_verRe";
            this.btn_verRe.Size = new System.Drawing.Size(75, 23);
            this.btn_verRe.TabIndex = 1;
            this.btn_verRe.Text = "Ver";
            this.btn_verRe.UseVisualStyleBackColor = true;
            this.btn_verRe.Click += new System.EventHandler(this.btn_verRe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 218);
            this.Controls.Add(this.btn_verRe);
            this.Controls.Add(this.dataMuestraD);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMuestraD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMuestraD;
        private System.Windows.Forms.Button btn_verRe;
    }
}