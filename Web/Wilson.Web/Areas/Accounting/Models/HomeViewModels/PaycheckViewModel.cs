﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Wilson.Web.Areas.Accounting.Models.HomeViewModels
{
    public class PaycheckViewModel
    {
        public DateTime Date { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public decimal Total { get; set; }

        public decimal PayedAmount { get => this.Payments.Sum(p => p.Amount); }

        public decimal Diffrence { get => this.Total - this.PayedAmount; }

        public bool IsPaied { get; set; }

        public IEnumerable<PaymentViewModel> Payments { get; set; }
    }
}
