﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.Events.Category
{
    public class CategoryDeleted : Event
    {
        public int Id { get; set; }
    }
}
