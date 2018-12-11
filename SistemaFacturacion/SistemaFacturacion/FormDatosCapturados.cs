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
                        DataBase.pathBaseDeDatos = filePath;//lee la ruta del archivo que ya contine los datos cargados en el excel de entradaa

                    }
                }
            }
            Form_datos_sin_captura siguiente = new Form_datos_sin_captura();//revisa los datos que se suponen no cambian y siempre aparecen en cada registro
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
            string query = string.Format("SELECT "+
                "F1  " +
                ", F2 as InvoiceDate" +
                ", F3 as InvoiceNo" +
                ", F4 as PoNo_1 " +
                ", F5 as Currency_1 " +
                ", F6 as Bil_1 " +
                ", F7 as SapBox " +
                ", '' as BaselineDate " +
                ", '' as ShipToCountry_A " +
                ", '' as ShipFromCountry " +
                ", F11 as LegalEntity_1 " +
                ", F12 as LE_Country_1 " +
                ", F13 as Name_1 " +
                ", '' as PGVAT_ID " +
                ", F15 as Address_1 " +
                ", F16 as Address1_1 " +
                ", F17 as City1_1 " +
                ", F18 as PostalCode1 " +
                ", F19 as Country_1 " +
                ", F20 as Vendor_No " +
                ", F21 as Vendor_Name " +
                ", ''  as PartnerVAT " +
                ", F23 as Address1_vendor " +
                ", F24 as Addres2_vendor " +
                ", F25 as City1_vendor " +
                ", F26 as Country1_vendor " +
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
                ", F44 as Line_Item_Number " +
                ", F45 as Quantity " +
                ", F46 as UoM " +
                ", F47 as NetPrice " +
                ", '' as Line_Item_Amount " +
                ", '' as PoNo_2 " +
                ", F50 as Material_Number " +
                ", '' as TaxID_A " +
                ", '' as TaxAmount_1 " +
                ", '' as TaxRate_a " +
                ", '' as UnplannedDeliveryCost " +
                ", '' as ISR_No " +
                ", '' as ISR_Ref_No " +
                ", '' as ScbIndicator " +
                ", '' as WithHoldingTax " +
                ", '' as NetAmount " +
                ", F60 as Invoice_Amount " +
                ", '' as TaxID_B " +
                ", '' as TaxType " +
                ", F63 as Tax_Amount " +
                ", F64 as Tax_Rate " +
                ", '' as AllowanceAmount " +
                ", '' as AllowanceDescription " +
                ", '' as AllowanceCode " +
                ", '' as ChargesAmount " +
                ", '' as ChargesDescription " +
                ", '' as ChargesCode " +
                ", F71 as Invoice_Type " +
                ", '' as ShipToName " +
                ", '' as ShipToAddress " +
                ", '' as ShipToState " +
                ", '' as ShipToCity1 " +
                ", '' as ShipToPostalCode " +
                ", '' as ShipToCountry_B " +
                ", '' as TaxId1 " +
                ", '' as TaxType1 " +
                ", '' as TaxRate1 " +
                ", F81 as Tax_Amount1 " +
                " FROM [{0}$]  ", "hoja_entrada");
           
            tabla_facturacion = DataBase.runSelectQuery(query);
          //  Utilidades.exportarTablaExcel(tabla_facturacion);
            Facturas.generar_excel(tabla_facturacion);
          

        }
    }
}
