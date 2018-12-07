namespace SistemaFacturacion
{
    partial class FormFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_llenar_datos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_busca_archivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_llenar_datos
            // 
            this.button_llenar_datos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_llenar_datos.FlatAppearance.BorderSize = 0;
            this.button_llenar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button_llenar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_llenar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_llenar_datos.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_llenar_datos.Image = ((System.Drawing.Image)(resources.GetObject("button_llenar_datos.Image")));
            this.button_llenar_datos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_llenar_datos.Location = new System.Drawing.Point(372, 155);
            this.button_llenar_datos.Name = "button_llenar_datos";
            this.button_llenar_datos.Size = new System.Drawing.Size(372, 42);
            this.button_llenar_datos.TabIndex = 2;
            this.button_llenar_datos.Text = "Llenar Registros";
            this.button_llenar_datos.UseVisualStyleBackColor = false;
            this.button_llenar_datos.Click += new System.EventHandler(this.button_llenar_datos_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(372, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 33);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Sistema de Facturación P&G";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_busca_archivo
            // 
            this.button_busca_archivo.FlatAppearance.BorderSize = 0;
            this.button_busca_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button_busca_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button_busca_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_busca_archivo.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_busca_archivo.Image = ((System.Drawing.Image)(resources.GetObject("button_busca_archivo.Image")));
            this.button_busca_archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_busca_archivo.Location = new System.Drawing.Point(372, 88);
            this.button_busca_archivo.Name = "button_busca_archivo";
            this.button_busca_archivo.Size = new System.Drawing.Size(372, 51);
            this.button_busca_archivo.TabIndex = 4;
            this.button_busca_archivo.Text = "Busca archivo de entrada ";
            this.button_busca_archivo.UseVisualStyleBackColor = true;
            this.button_busca_archivo.Click += new System.EventHandler(this.button_busca_archivo_Click);
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(756, 287);
            this.Controls.Add(this.button_busca_archivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_llenar_datos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormFacturacion";
            this.Text = "FromPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_llenar_datos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_busca_archivo;

    }
}