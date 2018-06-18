﻿using tax_planning.Models.Tax_Calculation;

namespace tax_planning.Models
{
    public class BrokerageHolding : Asset
    {
        protected override decimal CalculateTaxOnAddition(decimal addition) => 0.00M;

        protected override decimal CalculateTaxOnWithdrawal(decimal withdrawal, decimal income)
        {
            return IncomeTaxCalculator.CapitalGainsTaxFor(Data.FilingStatus, withdrawal, income);
        }
    }
}