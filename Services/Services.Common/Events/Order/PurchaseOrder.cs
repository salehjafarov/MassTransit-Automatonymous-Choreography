﻿using Services.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.Events.Order
{
    public class PurchaseOrder : Event
    {
        public CardDetails CardDetails { get; set; }
    }
}
