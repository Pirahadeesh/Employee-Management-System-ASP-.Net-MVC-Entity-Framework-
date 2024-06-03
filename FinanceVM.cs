using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DGHCM.ViewModel
{
    public class FinanceVM
    {
        public int PaymentDetailsId { get; set; }
        public int CashOrCheck { get; set; }
        public int ReciptOrPayment { get; set; }
        public int DetailsType { get; set; }
        public System.DateTime Date { get; set; }
        public string UploadDocument { get; set; }
        public bool IsActive { get; set; }
        public int DebitOrCredit { get; set; }
        public int BankId { get; set; }

        //sub details        
        public int FinanceSubDetails { get; set; }
        public int CustomerOrSupply { get; set; }
        public int CorS { get; set; }
        public decimal Amount { get; set; }
        public string Comments { get; set; }

        //GL
       
        public int GeneralLedgerDetailsId { get; set; }
        public string GeneralLedgerCode { get; set; }
        public int AccountMasterId { get; set; }
        
    }
}