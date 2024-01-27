﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Shared.Models.DataTransferObjects;
public class CalculatedTaxDto: BaseDataTransferObject
{
    public DateTime Date { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string MonetaryUnit { get; set; }
    public decimal AmountOfDay { get; set; }
}
