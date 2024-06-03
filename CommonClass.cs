﻿using DGHCM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DGHCM.Controllers
{
    public class CommonClass
    {
        HumanCapitalManagementEntities context = new HumanCapitalManagementEntities();
        //public static string GenerateCompanyId()
        //{
        //    string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
        //    string randomComponent = Guid.NewGuid().ToString().Substring(0, 4); 
        //    string CompanyId = timestamp + randomComponent;
        //    return CompanyId;
        //}
        public string CompanyId()
        {
            // Generating company ID
            /*string companyId = CompanyId.GenerateCompanyId();*/
            var a = "dc62b4d7-d1d6-4b59-bbeb-b5da52249c74";
            return a;
        }
        public string AccountMasterCode()
        {
            var lastAccount = context.AccountMasters.OrderByDescending(a => a.AccountCode).FirstOrDefault();
            var newAccountCode = 1;
            if (lastAccount != null)
            {
                // Extract the numeric part from the code
                var lastCode = lastAccount.AccountCode.Substring(3);
                newAccountCode = int.Parse(lastCode) + 1;
            }
            string accountCode = "ACC" + newAccountCode.ToString().PadLeft(4, '0');
            return accountCode;
        }

        public string CustomerCode()
        {
            var lastCustomer = context.CustomerDetails.OrderByDescending(a => a.CustomerCode).FirstOrDefault();
            var newCustomerCode = 1;
            if (lastCustomer != null)
            {
                // Extract the numeric part from the code
                var lastCode = lastCustomer.CustomerCode.Substring(3);
                newCustomerCode = int.Parse(lastCode) + 1;
            }
            string customerCode = "ACC" + newCustomerCode.ToString().PadLeft(4, '0');
            return customerCode;
        }

        public string FinanceSupplyCode()
        {
            var lastSupplyCode = context.SupplyDetails.OrderByDescending(a => a.FinanceSupplyCode).FirstOrDefault();
            var newSupplyCode = 1;
            if (lastSupplyCode != null)
            {
                // Extract the numeric part from the code
                var lastCode = lastSupplyCode.FinanceSupplyCode.Substring(3);
                newSupplyCode = int.Parse(lastCode) + 1;
            }
            string supplyCode = "ACC" + newSupplyCode.ToString().PadLeft(4, '0');
            return supplyCode;
        }

        /*public string GeneralLedgerCode()
        {
            var lastGeneralLedgerCode = context.GeneralLedgerDetails.OrderByDescending(a => a.GeneralLedgerCode).FirstOrDefault();
            var newGeneralLedgerCode = 1;
            if (lastGeneralLedgerCode != null)
            {
                // Extract the numeric part from the code
                var lastCode = lastGeneralLedgerCode.GeneralLedgerCode.Substring(3);
                newGeneralLedgerCode = int.Parse(lastCode) + 1;
            }
            string generalLedgerCode = "ACC" + newGeneralLedgerCode.ToString().PadLeft(4, '0');
            return generalLedgerCode;
        }*/
        public string GeneralLedgerCode()
        {
            // Get the last GeneralLedgerCode ordered by descending
            var lastGeneralLedgerCode = context.GeneralLedgerDetails
                                               .OrderByDescending(a => a.GeneralLedgerCode)
                                               .FirstOrDefault();

            int newGeneralLedgerCode = 1; // Default starting code

            if (lastGeneralLedgerCode != null)
            {
                // Extract the numeric part from the code by skipping the first 3 characters
                var lastCode = lastGeneralLedgerCode.GeneralLedgerCode.Substring(3);

                // Try parsing the numeric part
                if (int.TryParse(lastCode, out int numericPart))
                {
                    newGeneralLedgerCode = numericPart + 1;
                }
                else
                {
                    // Handle the case where the numeric part is not valid
                    throw new FormatException("The GeneralLedgerCode format is invalid.");
                }
            }

            // Format the new code with the required padding (4 digits)
            string generalLedgerCode = "ACC" + newGeneralLedgerCode.ToString("D4");
            return generalLedgerCode;
        }


    }
}