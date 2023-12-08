﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class Supplier : IEntity
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
