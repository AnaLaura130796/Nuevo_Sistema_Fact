namespace SistemaFacturacion
{
    partial class FormDatosCapturados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosCapturados));
            this.label_InvoiceDate = new System.Windows.Forms.Label();
            this.label_InoviceNumber = new System.Windows.Forms.Label();
            this.una_vez_por_cada_registro = new System.Windows.Forms.GroupBox();
            this.richTextBox_LineItemAmount_calculado = new System.Windows.Forms.RichTextBox();
            this.richTextBox_invoiceCreditFlag = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox_InvoiceAmount_calculado = new System.Windows.Forms.RichTextBox();
            this.label_InoviceAmount = new System.Windows.Forms.Label();
            this.label_LineItemAmount = new System.Windows.Forms.Label();
            this.richTextBox_InvoiceNumber = new System.Windows.Forms.RichTextBox();
            this.button_genera_factura_final = new System.Windows.Forms.Button();
            this.buttonCapturarDatos = new System.Windows.Forms.Button();
            this.button_genera_excel_sin_encabezado = new System.Windows.Forms.Button();
            this.una_vez_por_cada_registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_InvoiceDate
            // 
            this.label_InvoiceDate.AutoSize = true;
            this.label_InvoiceDate.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvoiceDate.Location = new System.Drawing.Point(20, 36);
            this.label_InvoiceDate.Name = "label_InvoiceDate";
            this.label_InvoiceDate.Size = new System.Drawing.Size(89, 20);
            this.label_InvoiceDate.TabIndex = 0;
            this.label_InvoiceDate.Text = "Invoice Date";
            // 
            // label_InoviceNumber
            // 
            this.label_InoviceNumber.AutoSize = true;
            this.label_InoviceNumber.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InoviceNumber.Location = new System.Drawing.Point(20, 82);
            this.label_InoviceNumber.Name = "label_InoviceNumber";
            this.label_InoviceNumber.Size = new System.Drawing.Size(109, 20);
            this.label_InoviceNumber.TabIndex = 1;
            this.label_InoviceNumber.Text = "Invoice Number";
            // 
            // una_vez_por_cada_registro
            // 
            this.una_vez_por_cada_registro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_LineItemAmount_calculado);
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_invoiceCreditFlag);
            this.una_vez_por_cada_registro.Controls.Add(this.label1);
            this.una_vez_por_cada_registro.Controls.Add(this.dateTimePicker_InvoiceDate);
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_InvoiceAmount_calculado);
            this.una_vez_por_cada_registro.Controls.Add(this.label_InoviceAmount);
            this.una_vez_por_cada_registro.Controls.Add(this.label_LineItemAmount);
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_InvoiceNumber);
            this.una_vez_por_cada_registro.Controls.Add(this.label_InvoiceDate);
            this.una_vez_por_cada_registro.Controls.Add(this.label_InoviceNumber);
            this.una_vez_por_cada_registro.Location = new System.Drawing.Point(12, 12);
            this.una_vez_por_cada_registro.Name = "una_vez_por_cada_registro";
            this.una_vez_por_cada_registro.Size = new System.Drawing.Size(762, 185);
            this.una_vez_por_cada_registro.TabIndex = 5;
            this.una_vez_por_cada_registro.TabStop = false;
            this.una_vez_por_cada_registro.Text = "Si se repiten";
            // 
            // richTextBox_LineItemAmount_calculado
            // 
            this.richTextBox_LineItemAmount_calculado.Location = new System.Drawing.Point(591, 15);
            this.richTextBox_LineItemAmount_calculado.Name = "richTextBox_LineItemAmount_calculado";
            this.richTextBox_LineItemAmount_calculado.ReadOnly = true;
            this.richTextBox_LineItemAmount_calculado.Size = new System.Drawing.Size(141, 24);
            this.richTextBox_LineItemAmount_calculado.TabIndex = 19;
            this.richTextBox_LineItemAmount_calculado.Text = "";
            // 
            // richTextBox_invoiceCreditFlag
            // 
            this.richTextBox_invoiceCreditFlag.Location = new System.Drawing.Point(310, 125);
            this.richTextBox_invoiceCreditFlag.Name = "richTextBox_invoiceCreditFlag";
            this.richTextBox_invoiceCreditFlag.Size = new System.Drawing.Size(141, 24);
            this.richTextBox_invoiceCreditFlag.TabIndex = 18;
            this.richTextBox_invoiceCreditFlag.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "InvoiceCreditFlag ( I = Factura, C = Crédito)";
            // 
            // dateTimePicker_InvoiceDate
            // 
            this.dateTimePicker_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_InvoiceDate.Location = new System.Drawing.Point(141, 36);
            this.dateTimePicker_InvoiceDate.Name = "dateTimePicker_InvoiceDate";
            this.dateTimePicker_InvoiceDate.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker_InvoiceDate.TabIndex = 16;
            // 
            // richTextBox_InvoiceAmount_calculado
            // 
            this.richTextBox_InvoiceAmount_calculado.Location = new System.Drawing.Point(591, 78);
            this.richTextBox_InvoiceAmount_calculado.Name = "richTextBox_InvoiceAmount_calculado";
            this.richTextBox_InvoiceAmount_calculado.ReadOnly = true;
            this.richTextBox_InvoiceAmount_calculado.Size = new System.Drawing.Size(141, 24);
            this.richTextBox_InvoiceAmount_calculado.TabIndex = 15;
            this.richTextBox_InvoiceAmount_calculado.Text = "Calculado";
            // 
            // label_InoviceAmount
            // 
            this.label_InoviceAmount.AutoSize = true;
            this.label_InoviceAmount.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InoviceAmount.Location = new System.Drawing.Point(469, 77);
            this.label_InoviceAmount.Name = "label_InoviceAmount";
            this.label_InoviceAmount.Size = new System.Drawing.Size(116, 20);
            this.label_InoviceAmount.TabIndex = 14;
            this.label_InoviceAmount.Text = "InvoiceAmount";
            // 
            // label_LineItemAmount
            // 
            this.label_LineItemAmount.AutoSize = true;
            this.label_LineItemAmount.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LineItemAmount.Location = new System.Drawing.Point(398, 19);
            this.label_LineItemAmount.Name = "label_LineItemAmount";
            this.label_LineItemAmount.Size = new System.Drawing.Size(187, 20);
            this.label_LineItemAmount.TabIndex = 11;
            this.label_LineItemAmount.Text = "LineItemAmount (Calculado)";
            // 
            // richTextBox_InvoiceNumber
            // 
            this.richTextBox_InvoiceNumber.Location = new System.Drawing.Point(141, 78);
            this.richTextBox_InvoiceNumber.Name = "richTextBox_InvoiceNumber";
            this.richTextBox_InvoiceNumber.Size = new System.Drawing.Size(141, 24);
            this.richTextBox_InvoiceNumber.TabIndex = 6;
            this.richTextBox_InvoiceNumber.Text = "";
            // 
            // button_genera_factura_final
            // 
            this.button_genera_factura_final.FlatAppearance.BorderSize = 0;
            this.button_genera_factura_final.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_genera_factura_final.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_genera_factura_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_genera_factura_final.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_genera_factura_final.Image = ((System.Drawing.Image)(resources.GetObject("button_genera_factura_final.Image")));
            this.button_genera_factura_final.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_genera_factura_final.Location = new System.Drawing.Point(3, 317);
            this.button_genera_factura_final.Name = "button_genera_factura_final";
            this.button_genera_factura_final.Size = new System.Drawing.Size(762, 41);
            this.button_genera_factura_final.TabIndex = 26;
            this.button_genera_factura_final.Text = "Genera la Factura con los datos";
            this.button_genera_factura_final.UseVisualStyleBackColor = true;
            // 
            // buttonCapturarDatos
            // 
            this.buttonCapturarDatos.FlatAppearance.BorderSize = 0;
            this.buttonCapturarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCapturarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCapturarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapturarDatos.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapturarDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonCapturarDatos.Image")));
            this.buttonCapturarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCapturarDatos.Location = new System.Drawing.Point(3, 203);
            this.buttonCapturarDatos.Name = "buttonCapturarDatos";
            this.buttonCapturarDatos.Size = new System.Drawing.Size(762, 45);
            this.buttonCapturarDatos.TabIndex = 24;
            this.buttonCapturarDatos.Text = "Capturar datos";
            this.buttonCapturarDatos.UseVisualStyleBackColor = true;
            this.buttonCapturarDatos.Click += new System.EventHandler(this.buttonCapturarDatos_Click);
            // 
            // button_genera_excel_sin_encabezado
            // 
            this.button_genera_excel_sin_encabezado.FlatAppearance.BorderSize = 0;
            this.button_genera_excel_sin_encabezado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.button_genera_excel_sin_encabezado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.button_genera_excel_sin_encabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_genera_excel_sin_encabezado.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_genera_excel_sin_encabezado.Image = ((System.Drawing.Image)(resources.GetObject("button_genera_excel_sin_encabezado.Image")));
            this.button_genera_excel_sin_encabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_genera_excel_sin_encabezado.Location = new System.Drawing.Point(3, 254);
            this.button_genera_excel_sin_encabezado.Name = "button_genera_excel_sin_encabezado";
            this.button_genera_excel_sin_encabezado.Size = new System.Drawing.Size(762, 45);
            this.button_genera_excel_sin_encabezado.TabIndex = 25;
            this.button_genera_excel_sin_encabezado.Text = "Genera ahora el excel sin encabezados";
            this.button_genera_excel_sin_encabezado.UseVisualStyleBackColor = true;
            // 
            // FormDatosCapturados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 425);
            this.Controls.Add(this.button_genera_factura_final);
            this.Controls.Add(this.button_genera_excel_sin_encabezado);
            this.Controls.Add(this.buttonCapturarDatos);
            this.Controls.Add(this.una_vez_por_cada_registro);
            this.Name = "FormDatosCapturados";
            this.Text = "FormDatosCapturados";
            this.Load += new System.EventHandler(this.FormDatosCapturados_Load);
            this.una_vez_por_cada_registro.ResumeLayout(false);
            this.una_vez_por_cada_registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_InvoiceDate;
        private System.Windows.Forms.Label label_InoviceNumber;
        private System.Windows.Forms.GroupBox una_vez_por_cada_registro;
        private System.Windows.Forms.RichTextBox richTextBox_InvoiceAmount_calculado;
        private System.Windows.Forms.Label label_InoviceAmount;
        private System.Windows.Forms.Label label_LineItemAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_genera_factura_final;
        private System.Windows.Forms.Button buttonCapturarDatos;
        public System.Windows.Forms.RichTextBox richTextBox_InvoiceNumber;
        public System.Windows.Forms.DateTimePicker dateTimePicker_InvoiceDate;
        public System.Windows.Forms.RichTextBox richTextBox_invoiceCreditFlag;
        public System.Windows.Forms.RichTextBox richTextBox_LineItemAmount_calculado;
        private System.Windows.Forms.Button button_genera_excel_sin_encabezado;
    }
}