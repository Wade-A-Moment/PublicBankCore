using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankCore.Models.ManageViewModels
{
    public class TransactionViewModel
    {
        public string BankAccountId { get; set; }
        // [DataType(DataType.Currency)] 
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:0.00}")]
        [Range(typeof(Decimal), "0", "9999999999999999.99",ErrorMessage = "Value must be a decimal value between 0 and 9999999999999999.99.")]
        public Decimal TransactionAmount { get; set; }
    }
}
