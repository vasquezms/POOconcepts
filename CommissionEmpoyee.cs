﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class CommissionEmpoyee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales  { get; set; }


        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentaje: {$"{CommissionPercentaje:P2}", 15}" +
                $"\n\tSales...............: {$"{Sales:C2}", 15}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}", 15}";
        }
    }

}