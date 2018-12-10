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

        }
        


        

        private void buttonCapturarDatos_Click(object sender, EventArgs e)
        {
            DataTable tabla_facturacion = new DataTable();
            
            //obtenemos los valores de cada uno de los richtextbox
            string invoiceDate = "";
            string invoiceNumber = "";
            string invoiceCreditFlag = "";
         
            //quantity * NetPrice = LineItemAmount(suma de cada uno de los registros) --> InvoiceAmount y aparece en todas los registros
            //groupbox de datos que si se repiten por registro
            DateTime dateFechaRegistro = dateTimePicker_InvoiceDate.Value;
            invoiceDate = dateFechaRegistro.ToString("yyy-MM-dd");
            invoiceCreditFlag = richTextBox_invoiceCreditFlag.Text;
            invoiceNumber = richTextBox_InvoiceNumber.Text;

            MessageBox.Show("holi"+tabla_facturacion);
      
                  
            if (tabla_facturacion != null)
            {
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
                        Form_datos_sin_captura siguiente = new Form_datos_sin_captura();
                        //Mostramos la ventana. 
                        siguiente.ShowDialog();
                        //Leemos los datos
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
                        juntar_tablas(); //funcion para hacer join entre la tabla de entrada y esta nueva con los datos capturados
                    }
                } 
            }
        }
        private void juntar_tablas()
        {
            string query = string.Format("SELECT " +
                "F1 as InvoiceCreditFlag " +
                ", F2 as InvoiceDate " +
                ", F3 as InvoiceNo " +
                ", F4 as PoNo_1 " +
                ", F5 as Currency_1 " +
                ", F6 as BIL " +
                ", F7 as SapBox " +
                ", '' as BaselineDate " +
                ", '' as ShipToCountry_A " +
                ", '' as ShipFromCountry " +
                ", F11 as LegalEntity_1 " +
                ", F12 as LE_Country" +
                ", F9 as Name_Lab " +
                ", '' as PGVAT_ID " + 
                ", F10 as Address_a " +
                ", F11 as Address1_1 " +
                ", F12 as City1_1 " +
                ", F13 as PostalCode_A " +
                ", F14 as Country_1 " +
                ", F15 as Vendor_No " +
                ", F16 as Name_Vendor " +
                ", ''  as PartnerVAT " +
                ", F17 as Address1_2" +
                ", F18 as Address2 " +
                ", F19 as City1_2 " +
                ", F20 as Country_2 " +
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
                ", F21 as LineItemNumber " +
                ", F22 as Quantity_1 " +
                ", F23 as UoM " +
                ", F24 as NetPrice " +
                ", F25 as LineItemAmount " +
                ", '' as PoNo_2 " +
                ", F26 as MaterialNumber " +
                ", '' as TaxID_A " +
                ", '' as TaxAmount_1 " +
                ", '' as TaxRate_a " +
                ", '' as UnplannedDeliveryCost " +
                ", '' as ISR_No " +
                ", '' as ISR_Ref_No " +
                ", '' as ScbIndicator " +
                ", '' as WithHoldingTax " +
                ", '' as NetAmount " +
                ", F27 as InvoiceAmount " +
                ", '' as TaxID_B " +
                ", '' as TaxType " +
                ", F28 as TaxAmount_2 " +
                ", F29 as TaxRate_b " +
                ", '' as AllowanceAmount " +
                ", '' as AllowanceDescription " +
                ", '' as AllowanceCode " +
                ", '' as ChargesAmount " +
                ", '' as ChargesDescription " +
                ", '' as ChargesCode " +
                ", F30 as InvoiceType " +
                ", '' as ShipToName " +
                ", '' as ShipToAddress " +
                ", '' as ShipToState " +
                ", '' as ShipToCity1 " +
                ", '' as ShipToPostalCode " +
                ", '' as ShipToCountry_B " +
                ", '' as TaxId1 " +
                ", '' as TaxType1 " +
                ", '' as TaxRate1 " +
                ", '' as TaxAmount1 " +
                "FROM  [{0}$] WHERE F5<>'Currency_1'", "hoja_entrada");
        }


    }
}
