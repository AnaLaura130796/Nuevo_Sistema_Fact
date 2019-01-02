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
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_invoiceCreditFlag = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox_InvoiceAmount_calculado = new System.Windows.Forms.RichTextBox();
            this.label_InoviceAmount = new System.Windows.Forms.Label();
            this.richTextBox_InvoiceNumber = new System.Windows.Forms.RichTextBox();
            this.button_genera_factura_final = new System.Windows.Forms.Button();
            this.buttonCapturarDatos = new System.Windows.Forms.Button();
            this.una_vez_por_cada_registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_InvoiceDate
            // 
            this.label_InvoiceDate.AutoSize = true;
            this.label_InvoiceDate.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvoiceDate.Location = new System.Drawing.Point(20, 96);
            this.label_InvoiceDate.Name = "label_InvoiceDate";
            this.label_InvoiceDate.Size = new System.Drawing.Size(101, 20);
            this.label_InvoiceDate.TabIndex = 0;
            this.label_InvoiceDate.Text = "Invoice Date";
            // 
            // label_InoviceNumber
            // 
            this.label_InoviceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_InoviceNumber.AutoSize = true;
            this.label_InoviceNumber.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InoviceNumber.Location = new System.Drawing.Point(20, 232);
            this.label_InoviceNumber.Name = "label_InoviceNumber";
            this.label_InoviceNumber.Size = new System.Drawing.Size(123, 20);
            this.label_InoviceNumber.TabIndex = 1;
            this.label_InoviceNumber.Text = "Invoice Number";
            // 
            // una_vez_por_cada_registro
            // 
            this.una_vez_por_cada_registro.BackColor = System.Drawing.Color.GhostWhite;
            this.una_vez_por_cada_registro.Controls.Add(this.label2);
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_invoiceCreditFlag);
            this.una_vez_por_cada_registro.Controls.Add(this.label1);
            this.una_vez_por_cada_registro.Controls.Add(this.dateTimePicker_InvoiceDate);
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_InvoiceAmount_calculado);
            this.una_vez_por_cada_registro.Controls.Add(this.label_InoviceAmount);
            this.una_vez_por_cada_registro.Controls.Add(this.richTextBox_InvoiceNumber);
            this.una_vez_por_cada_registro.Controls.Add(this.label_InvoiceDate);
            this.una_vez_por_cada_registro.Controls.Add(this.label_InoviceNumber);
            this.una_vez_por_cada_registro.Location = new System.Drawing.Point(12, 12);
            this.una_vez_por_cada_registro.Name = "una_vez_por_cada_registro";
            this.una_vez_por_cada_registro.Size = new System.Drawing.Size(722, 278);
            this.una_vez_por_cada_registro.TabIndex = 5;
            this.una_vez_por_cada_registro.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(206, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sistema de Facturación";
            // 
            // richTextBox_invoiceCreditFlag
            // 
            this.richTextBox_invoiceCreditFlag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox_invoiceCreditFlag.Location = new System.Drawing.Point(170, 157);
            this.richTextBox_invoiceCreditFlag.MaxLength = 1;
            this.richTextBox_invoiceCreditFlag.Name = "richTextBox_invoiceCreditFlag";
            this.richTextBox_invoiceCreditFlag.Size = new System.Drawing.Size(212, 24);
            this.richTextBox_invoiceCreditFlag.TabIndex = 1;
            this.richTextBox_invoiceCreditFlag.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "InvoiceCreditFlag";
            // 
            // dateTimePicker_InvoiceDate
            // 
            this.dateTimePicker_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_InvoiceDate.Location = new System.Drawing.Point(170, 96);
            this.dateTimePicker_InvoiceDate.Name = "dateTimePicker_InvoiceDate";
            this.dateTimePicker_InvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_InvoiceDate.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker_InvoiceDate.TabIndex = 0;
            // 
            // richTextBox_InvoiceAmount_calculado
            // 
            this.richTextBox_InvoiceAmount_calculado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox_InvoiceAmount_calculado.Location = new System.Drawing.Point(544, 224);
            this.richTextBox_InvoiceAmount_calculado.Name = "richTextBox_InvoiceAmount_calculado";
            this.richTextBox_InvoiceAmount_calculado.ReadOnly = true;
            this.richTextBox_InvoiceAmount_calculado.Size = new System.Drawing.Size(150, 24);
            this.richTextBox_InvoiceAmount_calculado.TabIndex = 15;
            this.richTextBox_InvoiceAmount_calculado.Text = "";
            // 
            // label_InoviceAmount
            // 
            this.label_InoviceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_InoviceAmount.AutoSize = true;
            this.label_InoviceAmount.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InoviceAmount.Location = new System.Drawing.Point(411, 228);
            this.label_InoviceAmount.Name = "label_InoviceAmount";
            this.label_InoviceAmount.Size = new System.Drawing.Size(121, 20);
            this.label_InoviceAmount.TabIndex = 14;
            this.label_InoviceAmount.Text = "InvoiceAmount ";
            // 
            // richTextBox_InvoiceNumber
            // 
            this.richTextBox_InvoiceNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox_InvoiceNumber.Location = new System.Drawing.Point(170, 228);
            this.richTextBox_InvoiceNumber.Name = "richTextBox_InvoiceNumber";
            this.richTextBox_InvoiceNumber.Size = new System.Drawing.Size(212, 24);
            this.richTextBox_InvoiceNumber.TabIndex = 2;
            this.richTextBox_InvoiceNumber.Text = "";
            // 
            // button_genera_factura_final
            // 
            this.button_genera_factura_final.BackColor = System.Drawing.Color.GhostWhite;
            this.button_genera_factura_final.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_genera_factura_final.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_genera_factura_final.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_genera_factura_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_genera_factura_final.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_genera_factura_final.Image = ((System.Drawing.Image)(resources.GetObject("button_genera_factura_final.Image")));
            this.button_genera_factura_final.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_genera_factura_final.Location = new System.Drawing.Point(382, 305);
            this.button_genera_factura_final.Name = "button_genera_factura_final";
            this.button_genera_factura_final.Size = new System.Drawing.Size(352, 51);
            this.button_genera_factura_final.TabIndex = 26;
            this.button_genera_factura_final.Text = "Generar Factura";
            this.button_genera_factura_final.UseVisualStyleBackColor = false;
            this.button_genera_factura_final.Click += new System.EventHandler(this.button_genera_factura_final_Click);
            // 
            // buttonCapturarDatos
            // 
            this.buttonCapturarDatos.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonCapturarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCapturarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCapturarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCapturarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapturarDatos.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapturarDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonCapturarDatos.Image")));
            this.buttonCapturarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCapturarDatos.Location = new System.Drawing.Point(12, 305);
            this.buttonCapturarDatos.Name = "buttonCapturarDatos";
            this.buttonCapturarDatos.Size = new System.Drawing.Size(364, 51);
            this.buttonCapturarDatos.TabIndex = 0;
            this.buttonCapturarDatos.Text = "Capturar registros";
            this.buttonCapturarDatos.UseVisualStyleBackColor = false;
            this.buttonCapturarDatos.Click += new System.EventHandler(this.buttonCapturarDatos_Click);
            // 
            // FormDatosCapturados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 378);
            this.Controls.Add(this.button_genera_factura_final);
            this.Controls.Add(this.buttonCapturarDatos);
            this.Controls.Add(this.una_vez_por_cada_registro);
            this.Name = "FormDatosCapturados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.FormDatosCapturados_Load);
            this.una_vez_por_cada_registro.ResumeLayout(false);
            this.una_vez_por_cada_registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_InvoiceDate;
        private System.Windows.Forms.Label label_InoviceNumber;
        private System.Windows.Forms.GroupBox una_vez_por_cada_registro;
        private System.Windows.Forms.Label label_InoviceAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_genera_factura_final;
        private System.Windows.Forms.Button buttonCapturarDatos;
        public System.Windows.Forms.RichTextBox richTextBox_InvoiceNumber;
        public System.Windows.Forms.DateTimePicker dateTimePicker_InvoiceDate;
        public System.Windows.Forms.RichTextBox richTextBox_invoiceCreditFlag;
        public System.Windows.Forms.RichTextBox richTextBox_InvoiceAmount_calculado;
        private System.Windows.Forms.Label label2;
    }
}