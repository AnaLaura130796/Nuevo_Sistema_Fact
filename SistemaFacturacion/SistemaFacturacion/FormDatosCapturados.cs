using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FormDatosCapturados : Form
    {
        public FormDatosCapturados()
        {
            InitializeComponent();
        }



        private void FormDatosCapturados_Load(object sender, EventArgs e)
        {
            button_genera_factura_final.Visible = false;
            label_InoviceAmount.Visible = false;
            richTextBox_InvoiceAmount_calculado.Visible = false;
        }

        string invoiceDate = "";
        string invoiceNumber = "";
        string invoiceCreditFlag = "";
        string hoja = "hoja_entrada";

        DataTable tabla;

        private void buttonCapturarDatos_Click(object sender, EventArgs e)
        {

          
            DateTime dateFechaRegistro = dateTimePicker_InvoiceDate.Value;
            invoiceDate = dateFechaRegistro.ToString("yyyyMMdd");
            invoiceCreditFlag = richTextBox_invoiceCreditFlag.Text;
            invoiceNumber = richTextBox_InvoiceNumber.Text;
            //validación para que ambos campos estén llenos y entonces pueda elegir el archivo de entrada
            if (richTextBox_InvoiceNumber.Text == "")
            { MessageBox.Show("Por favor llena el número de folio"); return; }
            if (richTextBox_invoiceCreditFlag.Text == "")
            { MessageBox.Show("Por favor llena el tipo de operación."); return; }
              
                
       
                //abre la ruta 
                var fileContent = string.Empty;
                var filePath = string.Empty;
                using (OpenFileDialog openfiledialog = new OpenFileDialog())
                {   //abrirá en la ruta donde esta el archivo a entrar
                    openfiledialog.InitialDirectory = "C:\\Users\\PMM\\Desktop\\sistemas\\SFacturacion\\plantillas";
                    openfiledialog.RestoreDirectory = true;
                    //solo muestra los archivos de este tipo
                    openfiledialog.Filter = "xlsx files (*,.xlsx)|*.xlsx";
                    if (openfiledialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openfiledialog.FileName;
                        DataBase.pathBaseDeDatos = filePath;

                    }
                    else
                    {
                        Utilidades.mostrarMensajeValidacion("Por favor selecciona un archivo");
                        return;
                    }
                  
                }
               
               Form_datos_sin_captura siguiente = new Form_datos_sin_captura();
                    //Mostramos la ventana. 
                    siguiente.ShowDialog();
                    //Leemos los datos que no cambian
                    siguiente.richTextBoxnombre1.Text.ToString();
                    siguiente.richTextBoxaddress2.Text.ToString();
                    siguiente.richTextBoxcity.Text.ToString();
                    siguiente.richTextBoxPostalCode.Text.ToString();
                    siguiente.richTextBoxCountry.Text.ToString();
                    siguiente.richTextBoxVendorNo.Text.ToString();
                    siguiente.richTextBoxVendorName.Text.ToString();
                    siguiente.richTextBoxVendorAddress1.Text.ToString();
                    siguiente.richTextBoxVendorAddress2.Text.ToString();
                    siguiente.richTextBoxVendorCity.Text.ToString();
                    siguiente.richTextBoxVendorCountry.Text.ToString();
                    siguiente.richTextBoxPoNo.Text.ToString();
                    siguiente.richTextBoxSapBox.Text.ToString();
                    siguiente.richTextBoxCurrency.Text.ToString();
                    siguiente.richTextBoxUoM.Text.ToString();
                    siguiente.richTextBoxInvoiceType.Text.ToString();
                    siguiente.richTextBoxTaxRate.Text.ToString();
                    siguiente.richTextBoxTaxAmount.Text.ToString();
                    siguiente.richTextBoxTaxAmount1.Text.ToString();
                    siguiente.richTextBoxLECountry.Text.ToString();
                    siguiente.richTextBoxLegalEntity.Text.ToString();
                    siguiente.richTextBoxbil.Text.ToString();

                    string query = string.Format("SELECT " +
                     "'{0}' as InvoiceCreditFlag " +
                     ", '{1}' as InvoiceDate " +
                     ", '{2}' as InvoiceNo " +
                     ", '{3}' as PoNo_1 " +
                     ", '{4}' as Currency_1 " +
                     ", '{5}' as Bil_1 " +
                     ", '{6}' as SapBox " +
                     ", '' as BaselineDate " +
                     ", '' as ShipToCountry_A " +
                     ", '' as ShipFromCountry " +
                     ", '{7}' as LegalEntity_1 " +
                     ", '{8}' as LE_Country_1 " +
                     ", '{9}' as Name_1 " +
                     ", '' as PGVAT_ID " +
                     ", '{10}' as Address_1 " +
                     ", '{11}' as Address1_1 " +
                     ", '{12}' as City1_1 " +
                     ", '{13}' as PostalCode1 " +
                     ", '{14}' as Country_1 " +
                     ", '{15}' as Vendor_No " +
                     ", '{16}' as Vendor_Name " +
                     ", ''  as PartnerVAT " +
                     ", '{17}' as Address1_vendor " +
                     ", '{18}' as Addres2_vendor " +
                     ", '{19}' as City1_vendor " +
                     ", '{20}' as Country1_vendor " +
                     ", '' as BankCountryKey " +
                     ", '' as BankAccountNo " +
                     ", '' as RemitTo_No " +
                     ", '' as Name " +
                     ", '' as Address_b " +
                     ", '' as Address1_3 " +
                     ", '' as City1_3 " +
                     ", '' as PostalCode_B " +
                     ", '' as Country_3 " +
                     ", '' as ProfitCenter " +
                     ", '' as WbsElement " +
                     ", '' as customeServiceOrder " +
                     ", '' as Gobal_Bussinerss_Area " +
                     ", '' as PaymentMethod " +
                     ", '' as PaymentMethod_Supplement " +
                     ", '' as item_Text " +
                     ", '' as PartDescription " +
                     ", [F1] as LineItemNumber " +
                     ", [F2] as Quantity " +
                     ", '{21}' as UoM " +
                     ", [F3] as NetPrice " +
                     ", [F4] as LineItemAmount " +
                     ", '' as PoNo_2 " +
                     ", [F5] as MaterialNumber " +
                     ", '' as TaxID_A " +
                     ", '' as TaxAmount_1 " +
                     ", '' as TaxRate_a " +
                     ", '' as UnplannedDeliveryCost " +
                     ", '' as ISR_No " +
                     ", '' as ISR_Ref_No " +
                     ", '' as ScbIndicator " +
                     ", '' as WithHoldingTax " +
                     ", '' as NetAmount " + //Error
                     ",  [F6] as InvoiceAmount " +
                     ", '' as TaxID_B " +
                     ", '' as TaxType " +
                     ", '{22}' as Tax_Amount " + //Sin Error
                     ", '{23}' as Tax_Rate " +
                     ", '' as AllowanceAmount " +
                     ", '' as AllowanceDescription " +
                     ", '' as AllowanceCode " +
                     ", '' as ChargesAmount " +
                     ", '' as ChargesDescription " +
                     ", '' as ChargesCode " +
                     ", '{24}' as Invoice_Type " +
                     ", '' as ShipToName " +
                     ", '' as ShipToAddress " +
                     ", '' as ShipToState " +
                     ", '' as ShipToCity1 " +
                     ", '' as ShipToPostalCode " +
                     ", '' as ShipToCountry_B " +
                     ", '' as TaxId1 " +
                     ", '' as TaxType1 " +
                     ", '' as TaxRate1 " +
                     ", '{25}' as Tax_Amount1 " +
                     "FROM [{26}$] where [F1]<>'' " +
                     "and [F1]<>'LineItemNumber'"
                     , invoiceCreditFlag
                     , invoiceDate
                     , invoiceNumber
                     , siguiente.richTextBoxPoNo.Text
                     , siguiente.richTextBoxCurrency.Text
                     , siguiente.richTextBoxbil.Text
                     , siguiente.richTextBoxSapBox.Text
                     , siguiente.richTextBoxLegalEntity.Text
                     , siguiente.richTextBoxLECountry.Text
                     , siguiente.richTextBoxnombre1.Text
                     , siguiente.richTextBoxVendorAddress1.Text
                     , siguiente.richTextBoxaddress2.Text
                     , siguiente.richTextBoxcity.Text
                     , siguiente.richTextBoxPostalCode.Text
                     , siguiente.richTextBoxCountry.Text
                     , siguiente.richTextBoxVendorNo.Text
                     , siguiente.richTextBoxVendorName.Text
                     , siguiente.richTextBoxVendorAddress1.Text
                     , siguiente.richTextBoxVendorAddress2.Text
                     , siguiente.richTextBoxVendorCity.Text
                     , siguiente.richTextBoxVendorCountry.Text
                     , siguiente.richTextBoxUoM.Text
                     , siguiente.richTextBoxTaxAmount.Text
                     , siguiente.richTextBoxTaxRate.Text
                     , siguiente.richTextBoxInvoiceType.Text
                     , siguiente.richTextBoxTaxAmount1.Text
                     , hoja
                     );
                    tabla = DataBase.runSelectQuery(query);
                    Utilidades.exportarTablaExcel(tabla);
                    nuevo_form_llenado();

            
        }
            private void nuevo_form_llenado()
        {
            
            FormDatosCapturados ventana = new FormDatosCapturados();
            buttonCapturarDatos.Visible = false;
            button_genera_factura_final.Visible = true;
            label_InoviceAmount.Visible = true;
            richTextBox_InvoiceAmount_calculado.Visible = true;


            richTextBox_InvoiceAmount_calculado.Text = tabla.Rows[0]["InvoiceAmount"].ToString();
       
            richTextBox_InvoiceAmount_calculado.Text.ToString();
           
            richTextBox_invoiceCreditFlag.Text.ToString();
            richTextBox_InvoiceNumber.Text.ToString();

            }

            private void button_genera_factura_final_Click(object sender, EventArgs e)
            {
                richTextBox_InvoiceNumber.ReadOnly = true;
                richTextBox_invoiceCreditFlag.ReadOnly = true;
                Facturas.generarFacturaFinal(tabla);
            }

            private void label_LineItemAmount_Click(object sender, EventArgs e)
            {

            }
        }
   
}
