using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asset.Models
{
    public class CreatePurchaseView
    {
        public int PID { get; set; }

        public int BRCODE { get; set; }

        public int VENDOR_CODE { get; set; }

        public string ENTRY_TYPE { get; set; }

        public DateTime ENTRY_DATE { get; set; }

        public int A_ID { get; set; }

        public int ASEC_ID { get; set; }

        public int ASSUB_ID { get; set; }

        public int QUANTITY { get; set; }

        public byte[] INVOICE { get; set; }

        public int PBID { get; set; }

        public long Bill_NO { get; set; }

        public DateTime BILL_DATE { get; set; }

        public string COMPANY_NAME { get; set; }

        public string PRODUCT_DESCRIPTION { get; set; }

    
        public decimal PAMOUNT { get; set; }

      
        public decimal TAMOUNT { get; set; }

    }
}
